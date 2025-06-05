using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Business.Interfaces
{
    public interface IExperienceService
    {
        IEnumerable<Experience> GetExperiences();
        void AddExperience(Experience experience);
        void UpdateExperience(Experience experience);
        Experience GetExperience(int id);
    }
}
