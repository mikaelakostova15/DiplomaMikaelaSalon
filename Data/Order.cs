using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriziorskiSalon.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int IdClient { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Product")]
        public int IdProduct { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
