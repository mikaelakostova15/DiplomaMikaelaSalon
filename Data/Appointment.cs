using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FriziorskiSalon.Data
{
    public class Appointment
    {
        public int Id { get; set; }

        [ForeignKey("Clients")]
        public int IdClient { get; set; }
        public Client Client { get; set; }

        [ForeignKey("Service")]
        public int IdService { get; set; }
        public Service Service { get; set; }

        public DateTime dateApropr { get; set; }

        [ForeignKey("HairDresser")]
        public int IdHairDresser { get; set; }
        public Hairdresser Hairdresser { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
    }
}
