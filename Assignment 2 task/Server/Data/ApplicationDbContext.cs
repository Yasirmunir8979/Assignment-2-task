using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_2_task.Shared.Shared;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<DiabetesInput> DiabetesInputs { get; set; }
    public DbSet<Course> Courses { get; set; }
}




