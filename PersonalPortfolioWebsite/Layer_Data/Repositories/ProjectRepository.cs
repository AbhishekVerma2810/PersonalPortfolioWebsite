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

        public void Add(Project project)
        {
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var project = GetById(id);

            if (project != null)
            {
                _dbContext.Projects.Remove(project);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Project> GetAll()
        {
            return _dbContext.Projects.AsEnumerable();
        }

        public Project GetById(int id)
        {
            return _dbContext.Projects.Find(id);
        }

        public void Update(Project entity)
        {
            _dbContext.Projects.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
