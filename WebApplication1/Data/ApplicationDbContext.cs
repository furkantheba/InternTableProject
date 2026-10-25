using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Intern>  Interns { get; set; }
    public DbSet<User>  Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       
        modelBuilder.Entity<Intern>().HasData(
            new Intern { Id = 1, Name = "Bugatti" },
            new Intern { Id = 2, Name = "Lambo"},
            new Intern() { Id = 3, Name = "Vosvo"}
        );
    }
}