using FirstApp.Models;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.Utils
{
    public class ApiConsumer
    {
        public ApiConsumer()
        {
            Client = new HttpClient();
        }

        public HttpClient Client
        {
            get { return Client; }
            set { Client = new HttpClient();}
        }
        public async Task<String> PostRequest(Model Data)
        {
            Debug.WriteLine("consuming api");
            try
            {
                string JsonRequest = JsonConvert.SerializeObject(Data);
                StringContent content = new StringContent(JsonRequest, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await Client.PostAsync(Constants.GetToken, content);
                string responseText = await response.Content.ReadAsStringAsync();
                return responseText;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
