using System;
using System.Collections.Generic;
using System.Text;
namespace MusicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "WsaXjRTTmWnSFnWzpDewaiyuRDDiFMffOaUcQUwl";
            string url = "https://api.discogs.com/database/search?";
            List<Attribute> l1 = new List<Attribute>();
            l1.Add(new Attribute { attributeName = "artist", attributeValue = "radiohead" });
            //l1.Add(new Attribute { attributeName = "title", attributeValue = "in_rainbows" });
            l1.Add(new Attribute { attributeName = "per_page", attributeValue = "1" });

            Request r1 = new Request(token, url, l1);
            r1.constructURL();
            Console.WriteLine(r1.formedURL);

            RequestBroker broker1 = new RequestBroker(r1);
        }
    }
}
