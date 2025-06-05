using PersonalPortfolioWebsite.Layer_Data.Repositories.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly PortfolioDbContext _dbContext;

        public ProjectRepository(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddProject(Project project)
        {
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }

        public void DeleteProject(int id)
        {
            var project = GetProjectById(id);

            if (project != null)
            {
                _dbContext.Projects.Remove(project);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _dbContext.Projects.AsEnumerable();
        }

        public Project GetProjectById(int id)
        {
            return _dbContext.Projects.Find(id);
        }
    }
}
