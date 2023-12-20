using CsvHelper.Configuration.Attributes;

namespace OrganizationsAndEmployees.Data
{
    public class Organization
    {
        [Name("Id")]
        public int Id { get; set; }

        [Name("Name")]
        public string Name { get; set; }

        [Name("INN")]
        public string INN { get; set; }

        [Name("LegalAddress")]
        public string LegalAddress { get; set; }

        [Name("ActualAddress")]
        public string ActualAddress { get; set; }
    }
}