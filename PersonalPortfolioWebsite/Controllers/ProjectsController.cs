using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebsite.Layer_Business.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectService _projectService;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetProjects();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectService.AddProject(project);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}
