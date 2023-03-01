using Microsoft.AspNetCore.Identity;

namespace FriziorskiSalon.Data
{
    public class Client : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
