using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace MailFinder
{
    public static class Utilities
    {
        public static List<string> ExtractMails(string source)
        {
            Regex regex = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}", RegexOptions.IgnoreCase);
            Match match;

            List<string> results = new List<string>();
            for (match = regex.Match(source); match.Success; match = match.NextMatch())
            {
                if (!(results.Contains(match.Value)))
                    results.Add(match.Value);
            }
            return results;
        }

        public static List<string> ExtractUrlAddresses(string source)
        {
            List<string> results = new List<string>();
            Regex regex = new Regex(@"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*", RegexOptions.IgnoreCase);

            MatchCollection matches = regex.Matches(source);
            foreach (Match match in matches)
            {
                results.Add(match.Value);
            }
            return results;
        }

        public static string ExtractSource(string urlAddress)
        {
            string source = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                HttpWebResponse respond = (HttpWebResponse)request.GetResponse();

                if (respond.StatusCode == HttpStatusCode.OK)
                {
                    Stream receiveStream = respond.GetResponseStream();
                    StreamReader readStream = null;

                    if (String.IsNullOrWhiteSpace(respond.CharacterSet))
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(respond.CharacterSet));

                    source = readStream.ReadToEnd();

                    respond.Close();
                    readStream.Close();

                    return source;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static List<string> RemoveDuplicates(List<string> list)
        {
            return list.Distinct().ToList();
        }

        public static bool IsSameDomain(string pUrl, string sUrl)
        {
            try
            {
                Uri primerUrl = new Uri(pUrl);
                string primerHost = primerUrl.Host;

                Uri seconderUrl;
                string seconderHost;

                seconderUrl = new Uri(sUrl);
                seconderHost = seconderUrl.Host;

                if (primerHost == seconderHost)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static string HttpControl(string url)
        {
            if (url != "" && url.Substring(0, 4) == "http")
            {
                return url;
            }
            else
            {
                return "http://" + url;
            }
        }
    }
}