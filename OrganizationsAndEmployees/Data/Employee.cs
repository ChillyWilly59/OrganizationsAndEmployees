namespace OrganizationsAndEmployees.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
    }
}