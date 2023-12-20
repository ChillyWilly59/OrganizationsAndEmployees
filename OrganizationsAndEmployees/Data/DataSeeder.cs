using Microsoft.EntityFrameworkCore;
using Bogus;
using OrganizationsAndEmployees.Data;

public class DataSeeder
{
    private readonly AppDbContext _context;

    public DataSeeder(AppDbContext context)
    {
        _context = context;
    }

    public void SeedData(int organizationsCount, int employeesCount)
    {
        SeedOrganizations(organizationsCount);
        SeedEmployees(employeesCount);
    }

    private void SeedOrganizations(int count)
    {
        var faker = new Faker<Organization>()
            .RuleFor(o => o.Name, f => f.Company.CompanyName())
            .RuleFor(o => o.INN, f => f.Random.Replace("##########"))
            .RuleFor(o => o.LegalAddress, f => f.Address.FullAddress())
            .RuleFor(o => o.ActualAddress, f => f.Address.FullAddress());

        var organizations = faker.Generate(count);
        _context.Organizations.AddRange(organizations);
        _context.SaveChanges();
    }

    private void SeedEmployees(int count)
    {
        var faker = new Faker<Employee>()
            .RuleFor(e => e.LastName, f => f.Person.LastName)
            .RuleFor(e => e.FirstName, f => f.Person.FirstName)
            .RuleFor(e => e.MiddleName, f => f.Person.LastName)
            .RuleFor(e => e.BirthDate, f => f.Person.DateOfBirth)
            .RuleFor(e => e.PassportSeries, f => f.Random.Replace("####"))
            .RuleFor(e => e.PassportNumber, f => f.Random.Replace("########"));

        var employees = faker.Generate(count);
        _context.Employees.AddRange(employees);
        _context.SaveChanges();
    }
}
