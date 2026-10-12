using Microsoft.EntityFrameworkCore;
using ConsultorioApp.Models;

namespace ConsultorioApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<AntecedenteGinecologico> AntecedentesGinecologicos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de relaciones en la base de datos
            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.AntecedenteGinecologico)
                .WithOne(a => a.Paciente)
                .HasForeignKey<AntecedenteGinecologico>(a => a.PacienteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Paciente>()
                .HasMany(p => p.Consultas)
                .WithOne(c => c.Paciente)
                .HasForeignKey(c => c.PacienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}