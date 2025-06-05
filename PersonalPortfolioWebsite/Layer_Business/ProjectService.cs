using PersonalPortfolioWebsite.Layer_Business.Interfaces;
using PersonalPortfolioWebsite.Layer_Data.Repositories.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Business
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _project;

        public ProjectService(IProjectRepository project)
        {
            _project = project;
        }

        public void AddProject(Project project)
        {
            _project.AddProject(project);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _project.GetAllProjects();
        }
    }
}
