using JeronyCruz_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace JeronyCruz_AP1_P2.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Combos> Combos { get; set; }
        public DbSet<CombosDetalle> CombosDetalles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
        {
            new Productos(){ArticuloId = 1, Descripcion = "Disco Duro", Costo = 570, Precio = 650, Existencia = 30},
            new Productos(){ArticuloId = 2, Descripcion = "Memoria Ram", Costo = 800, Precio = 2200, Existencia = 70},
            new Productos(){ArticuloId = 3, Descripcion = "Procesador", Costo = 2050, Precio = 2810, Existencia = 60},
            new Productos(){ArticuloId = 4, Descripcion = "Tarjeta Grafica", Costo = 1310, Precio = 2530, Existencia = 50}
        });
        }
    }
}
