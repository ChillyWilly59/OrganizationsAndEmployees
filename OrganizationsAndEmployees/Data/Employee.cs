using CsvHelper.Configuration.Attributes;

namespace OrganizationsAndEmployees.Data
{
    public class Employee
    {
        [Name("Id")]
        public int Id { get; set; }

        [Name("LastName")]
        public string LastName { get; set; }

        [Name("FirstName")]
        public string FirstName { get; set; }

        [Name("MiddleName")]
        public string MiddleName { get; set; }

        [Name("BirthDate")]
        public DateTime BirthDate { get; set; }

        [Name("PassportSeries")]
        public string PassportSeries { get; set; }

        [Name("PassportNumber")]
        public string PassportNumber { get; set; }
    }
}