using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Data.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(int id);
        void AddProject(Project project);
        void DeleteProject(int id);
    }
}
