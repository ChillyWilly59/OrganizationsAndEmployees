namespace OrganizationsAndEmployees.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}