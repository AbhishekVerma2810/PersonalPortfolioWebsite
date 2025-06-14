﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PersonalPortfolioWebsite.Layer_Business.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectService _projectService;
        private readonly IExperienceService _experienceService;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectService projectService, IExperienceService experienceService)
        {
            _logger = logger;
            _projectService = projectService;
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            var projects = _projectService.GetProjects();
            return View(projects);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Experiences = new SelectList(_experienceService.GetExperiences(), "Id", "CompanyName");

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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var project = _projectService.GetProject(id);
            if (project == null)
                return NotFound();

            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                _projectService.UpdateProject(project);
                return RedirectToAction("Index");
            }
            return View(project);
        }
    }
}
