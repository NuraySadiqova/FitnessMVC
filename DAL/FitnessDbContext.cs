using FitnessMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FitnessMVC.DAL
{
    public class FitnessDbContext:IdentityDbContext<AppUser>
    {
        public FitnessDbContext(DbContextOptions<FitnessDbContext> options):base(options) {}
       public DbSet<Trainer> Traniers { get; set; }
       public DbSet<Category> Categories { get; set; }
       
    }
}
