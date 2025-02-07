using System.Text.Json;
using RPGfront.Models;

namespace RPGfront.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // desserialização do json
        public async Task<Cartas> GetDataFromApiAsync(string url)
        {
            var response = await _httpClient.GetStringAsync(url);
            return JsonSerializer.Deserialize<Cartas>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
