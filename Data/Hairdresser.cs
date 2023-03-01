using Microsoft.EntityFrameworkCore;

namespace FriziorskiSalon.Data
{
    public class Hairdresser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public virtual DbSet<Hairdresser> Hairdressers { get; set; }
    }
}
