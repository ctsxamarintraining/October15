using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JsonHttpRequestDemo
{
    public class NonBlockingHttp
    {
        private Uri baseUri = null;
        public NonBlockingHttp(string baseUrl) {
            this.baseUri = new Uri(baseUrl);
        }

        public Task<string> Get(string urlRelative="") { 
            return Task<string>.Run(() => getUrl(urlRelative));        
        }

        private string getUrl(string urlRelative, string accept = "application/json")
        {
            Uri getUri  = new Uri(this.baseUri, urlRelative);
            return getResponseString(getUri.OriginalString, accept, "GET");
        }

        private string getResponseString(string url, string accept, string method)
        {

            HttpWebRequest httpReq = WebRequest.CreateHttp(url);
            httpReq.Method = method;
            httpReq.Accept = accept;
            string response;
            using (StreamReader reader = new StreamReader(httpReq.GetResponse().GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            return response;
        }

    }
}
