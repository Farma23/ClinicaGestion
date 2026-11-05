using Microsoft.EntityFrameworkCore;
using ClinicaGestion.Models;

namespace ClinicaGestion.Data
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options) { }
        public DbSet<Patient> Patients { get; set; }
    }
}
