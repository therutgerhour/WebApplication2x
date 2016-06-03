using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using WebApplication2.Models;



namespace WebApplication2.DataAccess
{
    public class LitmusAPI
    {

        public string BaseAddress { get; set; }
        private string apiBase = "https://instant-api.litmus.com/v1";
        private string apiKey = "gabedefelippis";
        //private Task http;

        public async Task<BrowserClients> GetListOfClients()
        {
            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", apiKey, "")));

            using (var httpClient = new HttpClient())
            {
                //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);


               var response = await httpClient.GetAsync(apiBase);

                // var responseContent = await response.Content.ReadAsStringAsync();
               Console.Write(response);
            }

            //var test = "https://litmus.com/pages/clients.json";
            var test = "[{\"name\":\"Chrome\",\"type\":\"page\",\"status\":0,\"average_time\":-103,\"code\":\"chrome2\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Chrome (OS X)\",\"type\":\"page\",\"status\":0,\"average_time\":-4,\"code\":\"chromelatestosx\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Explorer 8.0\",\"type\":\"page\",\"status\":0,\"average_time\":-84,\"code\":\"ie8\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Explorer 9.0\",\"type\":\"page\",\"status\":0,\"average_time\":-87,\"code\":\"ie9\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Explorer 10.0\",\"type\":\"page\",\"status\":0,\"average_time\":0,\"code\":\"ie10\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Explorer 11.0\",\"type\":\"page\",\"status\":0,\"average_time\":0,\"code\":\"ie11\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Firefox\",\"type\":\"page\",\"status\":0,\"average_time\":-109,\"code\":\"fflatest\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Firefox (OS X)\",\"type\":\"page\",\"status\":0,\"average_time\":-10,\"code\":\"fflatestosx\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"iPhone 5S\",\"type\":\"page\",\"status\":0,\"average_time\":-32,\"code\":\"iphone4page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"iPad Air\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"ipadios8page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Galaxy S5\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"android44page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Galaxy Tab 4\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"androidtablet44page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"iPhone 6\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"iphone6page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"iPhone 6 Plus\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"iphone6pluspage\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Google Nexus 9\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"androidtablet5page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Google Nexus 5\",\"type\":\"page\",\"status\":0,\"average_time\":null,\"code\":\"androidphone5page\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}},{\"name\":\"Safari 7.0 (OS X)\",\"type\":\"page\",\"status\":0,\"average_time\":-15,\"code\":\"saf4m\",\"message\":{\"head\":\"OK\",\"body\":\"This client is performing well.\"}}]";

            BrowserClients broswerClientList = new BrowserClients(new JavaScriptSerializer().Deserialize<IList<Browser>>(test));

            return broswerClientList;
        }
    }
}