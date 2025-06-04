using Microsoft.AspNetCore.Mvc;

namespace PersonalPortfolioWebsite.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly ILogger<AboutMeController> _logger;

        public AboutMeController(ILogger<AboutMeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
