namespace PersonalPortfolioWebsite.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public required string Role { get; set; }
        public required string CompanyName { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public required DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }


    }
}
