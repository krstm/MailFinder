using System.Collections.Generic;

namespace MailFinder
{
    public class Url
    {
        private string _urlAdress;
        private List<string> eMails;
        private string _source;

        public string UrlAdress { get => _urlAdress; set => _urlAdress = value; }
        public List<string> EMails { get => eMails; set => eMails = value; }
        public string Source { get => _source; set => _source = value; }
    }
}