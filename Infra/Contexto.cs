using DevWebBasico.Dominio;
using Microsoft.EntityFrameworkCore;

namespace DevWebBasico.Infra
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        public DbSet<Sala> Sala { get; set; }
        public DbSet<Evento> Evento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}