using PersonalPortfolioWebsite.Layer_Data.Repositories.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Data.Repositories
{
    public class ExperienceRepository : IExperienceRepository
    {
        private readonly PortfolioDbContext _dbContext;

        public ExperienceRepository(PortfolioDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Experience entity)
        {
            _dbContext.Experiences.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var experience = GetById(id);

            if (experience != null)
            {
                _dbContext.Experiences.Remove(experience);
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Experience> GetAll()
        {
            return _dbContext.Experiences.AsEnumerable();
        }

        public Experience GetById(int id)
        {
            return _dbContext.Experiences.Find(id);
        }

        public void Update(Experience entity)
        {
            _dbContext.Experiences.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
