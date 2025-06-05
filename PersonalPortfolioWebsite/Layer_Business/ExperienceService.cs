using PersonalPortfolioWebsite.Layer_Business.Interfaces;
using PersonalPortfolioWebsite.Layer_Data.Repositories.Interfaces;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Business
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _experience;

        public ExperienceService(IExperienceRepository experience)
        {
            _experience = experience;
        }
        public void AddExperience(Experience experience)
        {
            _experience.Add(experience);
        }

        public Experience GetExperience(int id)
        {
            return _experience.GetById(id);
        }

        public IEnumerable<Experience> GetExperiences()
        {
            return _experience.GetAll();
        }

        public void UpdateExperience(Experience experience)
        {
            _experience.Update(experience);
        }
    }
}
