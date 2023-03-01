using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FriziorskiSalon.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Service> Services { get; set; }
        public ICollection<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
