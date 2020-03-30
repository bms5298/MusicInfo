using System;
using System.Collections.Generic;
using System.Text;

namespace MusicInfo
{
    class Request
    {
        private string token;
        private string baseURL;
        private List<Attribute> attributes;
        public string formedURL;

        public Request(string _token, string _baseURL, List<Attribute> _attributes)
        {
            this.token = _token;
            this.baseURL = _baseURL;
            this.attributes = _attributes;
            this.formedURL = this.baseURL;
        }

        // this method creates a fully formed url for the discogs API
        public void constructURL()
        {
            foreach(Attribute attr in this.attributes)
            {
                this.formedURL = this.formedURL + attr.attributeName + "=" + attr.attributeValue + "&";
            }

            this.formedURL = this.formedURL + "token=" + this.token;

        }

    }
}
