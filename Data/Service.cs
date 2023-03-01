using FriziorskiSalon.Data.hairdressingSalon.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriziorskiSalon.Data
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Category")]
        public int IdCategory { get; set; }
        public CategoryType Category { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public double Price { get; set; }
        public DateTime DateOfEntry { get; set; }   
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual DbSet<Service> Services { get; set; }
    }
}
