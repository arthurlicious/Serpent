using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace SerpantWebApp.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class Error403Model : PageModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public Error403Model(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
