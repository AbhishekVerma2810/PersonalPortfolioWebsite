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
            _project.Add(project);
        }

        public Project GetProject(int id)
        {
            return _project.GetById(id);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _project.GetAll();
        }

        public void UpdateProject(Project project)
        {
            _project.Update(project);
        }
    }
}
