using FirstApp.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
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
        /*
        public void SetAuthenticationToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        */
        public async Task<string> PostRequest(Model Data)
        {
            string JsonRequest = JsonConvert.SerializeObject(Data);
            Debug.WriteLine(JsonRequest);
            StringContent content = new StringContent(JsonRequest, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(Constants.GetToken, content);
            if (response.IsSuccessStatusCode)
            {
                return await Task.FromResult(await response.Content.ReadAsStringAsync());
            }
            return null;
        }
    }
}
