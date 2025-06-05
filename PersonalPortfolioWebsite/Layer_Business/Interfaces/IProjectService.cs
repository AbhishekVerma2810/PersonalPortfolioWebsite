using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Business.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
        void AddProject(Project project);
        void UpdateProject(Project project);
        Project GetProject(int id);
    }
}
