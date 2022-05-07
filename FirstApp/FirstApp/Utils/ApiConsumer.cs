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
        private HttpClient _httpClient;
        public ApiConsumer()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> PostRequest(Model Data)
        {
            Debug.WriteLine("consuming api");
            string JsonRequest = JsonConvert.SerializeObject(Data);
            StringContent content = new StringContent(JsonRequest, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(Constants.GetToken, content);
            string responseText = response.Content.ToString();
            Debug.WriteLine(responseText);
            return responseText;
        }
    }
}
