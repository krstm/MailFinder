using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task Find()
        {
            await Task.Run(() =>
            {
                Control.CheckForIllegalCrossThreadCalls = false;

                LockElements();

                SendNotification("Searching...");

                List<string> allUrlAdresses = new List<string>();
                List<string> allMails = new List<string>();

                Url urls = new Url();
                urls.Source = Utilities.ExtractSource(tbxUrl.Text);

                foreach (string url in Utilities.ExtractUrlAddresses(urls.Source))
                {
                    if (Utilities.IsSameDomain(tbxUrl.Text, url))
                    {
                        allUrlAdresses.Add(url);
                    }
                }
                allUrlAdresses.Add(tbxUrl.Text);
                allUrlAdresses = Utilities.RemoveDuplicates(allUrlAdresses);

                foreach (string url in allUrlAdresses)
                {
                    lbxUrlAdresses.Items.Add(url);
                }

                foreach (string url in lbxUrlAdresses.Items)
                {
                    if (Utilities.IsSameDomain(tbxUrl.Text, url))
                    {
                        urls.Source = Utilities.ExtractSource(url);

                        foreach (string url2 in Utilities.ExtractUrlAddresses(urls.Source))
                        {
                            allUrlAdresses.Add(url2);
                        }
                    }
                }
                allUrlAdresses = Utilities.RemoveDuplicates(allUrlAdresses);

                foreach (string url in lbxUrlAdresses.Items)
                {
                    urls.Source = Utilities.ExtractSource(url);

                    foreach (string mail in Utilities.ExtractMails(urls.Source))
                    {
                        allMails.Add(mail);
                    }
                }

                allMails = Utilities.RemoveDuplicates(allMails);

                foreach (string mail in allMails)
                {
                    lbxMails.Items.Add(mail);
                }

                SendNotification("Finished.");
                OpenElements();
            });
        }

        public async Task SendNotification(string notification)
        {
            await Task.Run(() =>
            {
                lblNotification.Text = notification;
            });
        }

        public void LockElements()
        {
            btnFind.Enabled = false;
            lbxUrlAdresses.Enabled = false;
            lbxMails.Enabled = false;
            tbxUrl.Enabled = false;
            btnSave.Enabled = false;
            lbxMails.Items.Clear();
            lbxUrlAdresses.Items.Clear();
        }

        public void OpenElements()
        {
            btnFind.Enabled = true;
            lbxUrlAdresses.Enabled = true;
            lbxMails.Enabled = true;
            tbxUrl.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tbxUrl.Text = Utilities.HttpControl(tbxUrl.Text);
            Find();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxMails.HorizontalScrollbar = true;
            lbxUrlAdresses.HorizontalScrollbar = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string path;
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = "Mails " + DateTime.Now.ToString("MM.dd.yyyy.h.mm") + ".txt";
                path = folderBrowserDialog.SelectedPath + @"\" + fileName;

                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path);
                foreach (var item in lbxMails.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();

                SendNotification("Saved");
            }
        }
    }
}