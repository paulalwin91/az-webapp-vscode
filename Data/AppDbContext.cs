using System;
using Microsoft.EntityFrameworkCore;

namespace Azure_williams.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public required DbSet<Person> Persons { get; set; }

}

public class Person
{
    public int Id { get; set; }
    public required string Name { get; set; }
}