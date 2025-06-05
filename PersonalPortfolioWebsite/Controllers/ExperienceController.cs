using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebsite.Layer_Business;
using PersonalPortfolioWebsite.Layer_Business.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ILogger<ExperienceController> _logger;
        private readonly IExperienceService _experienceService;

        public ExperienceController(ILogger<ExperienceController> logger, IExperienceService experienceService)
        {
            _logger = logger;
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var experiences = _experienceService.GetExperiences();
            return View(experiences);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _experienceService.AddExperience(experience);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var experience = _experienceService.GetExperience(id);
            if (experience == null)
                return NotFound();

            return View(experience);
        }

        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            if (ModelState.IsValid)
            {
                _experienceService.UpdateExperience(experience);
                return RedirectToAction("Index");
            }
            return View(experience);
        }
    }
}
