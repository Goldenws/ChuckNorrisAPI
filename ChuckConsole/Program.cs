using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace ChuckConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetJokes();
            Console.WriteLine(message);
            
        }

        public static string GetJokes()
        {
            string url = "http://api.icndb.com/jokes/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var Response = responseReader.ReadToEnd();
                Joke joke = JsonConvert.DeserializeObject<Joke>(Response);
                

                return joke.value.joke;
            }

        }
    }
}
