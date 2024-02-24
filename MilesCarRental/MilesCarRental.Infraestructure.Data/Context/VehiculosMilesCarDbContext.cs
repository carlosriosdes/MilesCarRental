using Microsoft.EntityFrameworkCore;
using MilesCarRental.Domain.Models;

namespace MilesCarRental.Infraestructure.Data.Context
{
    public class VehiculosMilesCarDbContext : DbContext
    {
        public VehiculosMilesCarDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehiculoLocalidad>()
                .HasKey(vl => vl.VehiculoLocalidadId);

            modelBuilder.Entity<VehiculoLocalidad>()
                .HasOne(vl => vl.Vehiculo)
                .WithMany(v => v.VehiculoLocalidades)
                .HasForeignKey(vl => vl.VehiculoId);

            modelBuilder.Entity<VehiculoLocalidad>()
                .HasOne(vl => vl.LocalidadRecogida)
                .WithMany(l => l.VehiculoLocalidadesRecogida)
                .HasForeignKey(vl => vl.LocalidadRecogidaId);

            modelBuilder.Entity<VehiculoLocalidad>()
                .HasOne(vl => vl.LocalidadEntrega)
                .WithMany(l => l.VehiculoLocalidadesEntrega)
                .HasForeignKey(vl => vl.LocalidadEntregaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
