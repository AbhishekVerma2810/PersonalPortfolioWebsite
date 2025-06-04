namespace PersonalPortfolioWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RoleAndResponsibility { get; set; }
        public string ProjectUrl { get; set; }
        public List<string> SkillsUsed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
