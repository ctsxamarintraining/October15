using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest httpReq = WebRequest.CreateHttp("http://www.cognizant.com");
            httpReq.Method = "GET";
            httpReq.Accept = "text/html";

            var responseObj = httpReq.GetResponse();

            using (StreamReader reader = new StreamReader(httpReq.GetResponse().GetResponseStream())) {
                string response = reader.ReadToEnd();
                File.WriteAllText("C:\\users\\131377\\desktop\\get-request.html", response);
                //Console.WriteLine(response);
            }
            
            //---------------------------------------------------------------------------------------------

            string jsonString = getResponse("http://jsonplaceholder.typicode.com/posts");
            List<Post> posts = GetPosts(jsonString);


            //----------------------------------------------------------------------------------------------

            Post postForUpdation = posts[0];
            postForUpdation.Title = "ABCD";

            string responsePatch = patchRequest("http://jsonplaceholder.typicode.com/posts/" + posts[0].Id, GetJson(postForUpdation));
            Post updatedPost = GetPost(responsePatch);

            Console.ReadLine();
        }

        static string getResponse(string url)
        {

            HttpWebRequest httpReq = WebRequest.CreateHttp(url);
            httpReq.Method = "GET";
            httpReq.Accept = "application/json";
            string response;
            using (StreamReader reader = new StreamReader(httpReq.GetResponse().GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            return response;
        }


        static string patchRequest(string url, string jsonData) {
            HttpWebRequest httpReq = WebRequest.CreateHttp(url);
            httpReq.Method = "PUT";
            httpReq.Accept = "application/json";

            Stream reqStream = httpReq.GetRequestStream();
            byte[] data = Encoding.UTF8.GetBytes(jsonData);
            reqStream.Write(data, 0, data.Length);
            reqStream.Close();
            
            string response;
            using (StreamReader reader = new StreamReader(httpReq.GetResponse().GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            return response;
        } 

        static List<Post> GetPosts(string json) {
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(List<Post>));
            MemoryStream ms  = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            sw.Write(json);
            sw.Flush();
            ms.Position = 0;
            List<Post> posts = (List<Post>)dcjs.ReadObject(ms);

            sw.Close();
            return posts;
        }

        static Post GetPost(string json) {
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Post));
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);
            sw.Write(json);
            sw.Flush();
            ms.Position = 0;
            Post post = (Post)dcjs.ReadObject(ms);

            sw.Close();
            return post;
        }

        static string GetJson(Post p) {
            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(Post));
            MemoryStream ms = new MemoryStream();
            dcjs.WriteObject(ms, p);
            ms.Position = 0;

            string json = null;
            using (StreamReader sr = new StreamReader(ms)) {

                json = sr.ReadToEnd();
            }

            return json;
        }
    }


    [DataContract]
    public class Post {
        [DataMember(Name="userId")]
        public string UserId { get; set; }
        
        [DataMember(Name="id")]
        public int Id { get; set; }

        [DataMember(Name="title")]
        public string Title { get; set; }

        [DataMember(Name="body")]
        public string Body { get; set; }    
    }
}
