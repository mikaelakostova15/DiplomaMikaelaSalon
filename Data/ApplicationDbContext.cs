using FriziorskiSalon.Data.hairdressingSalon.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FriziorskiSalon.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Hairdresser> Hairdressers { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}