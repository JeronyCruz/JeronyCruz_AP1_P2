using JeronyCruz_AP1_P2.Models;
using Microsoft.EntityFrameworkCore;

namespace JeronyCruz_AP1_P2.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Registro> Registro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
