using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ChuckForm
{
    public partial class ChuckNorrisJokeGenerator : Form
    {
        public ChuckNorrisJokeGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JokeBox.Text = GetJokes();
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
