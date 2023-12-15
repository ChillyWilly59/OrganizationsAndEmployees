namespace OrganizationsAndEmployees.Data
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string LegalAddress { get; set; }
        public string ActualAddress { get; set; }
    }
}