using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace MusicInfo
{
    class RequestBroker
    {
        private Request request;
        //private Response response;

        public RequestBroker(Request _request)
        {
            this.request = _request;
            this.sendRequest();
        }

        private async void sendRequest()
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(this.request.formedURL);
            myRequest.Headers["user-agent"] = "ScheetzPSU/0.1 +https://github.com/bryeetz/pi";
            HttpWebResponse response = (HttpWebResponse)myRequest.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader sR1 = new StreamReader(resStream);
            //Console.WriteLine(sR1.ReadLine());
            string myResponse = sR1.ReadToEnd();

            string jsonString;
            jsonString = JsonSerializer.Serialize(myResponse);

            Console.WriteLine(jsonString);


            
        }

        public void handleResponse()
        {
             
        }

    }
}
