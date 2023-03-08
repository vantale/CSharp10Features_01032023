namespace MinimalwebAPI.Models
{
    public class PersonalData
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CountryOfBirth { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
