using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPGfront.Models;
using RPGfront.Services;

namespace RPGfront.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApiService _apiService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ApiService apiService)
        {
            _logger = logger;

            _apiService = apiService;
        }

        // faz o request
        // ele não converte para string, então fiz assim
        public Cartas ApiData { get; set; }
        public async Task OnGetAsync() => ApiData = await _apiService.GetDataFromApiAsync("http://localhost:5159/api/cartas/1");
    }
}
