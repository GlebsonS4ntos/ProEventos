using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Infraestructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set;}
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<RedeSocial> RedeSocials { get; set; }
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PalestranteEvento>()
                .HasKey(PE => new { PE.PalestranteId, PE.EventoId}); //chave primaria composta 
            
            modelBuilder.Entity<PalestranteEvento>().HasOne(pe => pe.Palestrante)
                .WithMany(p => p.PalestrantesEventos).HasForeignKey(pe => pe.PalestranteId); //expressando o N para N

            modelBuilder.Entity<PalestranteEvento>().HasOne(pe => pe.Evento)
                .WithMany(e => e.PalestrantesEventos).HasForeignKey(pe => pe.EventoId); //expressando o N para N

            modelBuilder.Entity<Lote>().HasOne(lote => lote.Evento)
                .WithMany(evento => evento.Lotes).HasForeignKey(lote => lote.EventoId); //UmParaMuitos

            modelBuilder.Entity<RedeSocial>().HasOne(redeSocial => redeSocial.Evento)
                .WithMany(evento => evento.RedesSociais).HasForeignKey(redeSocial => redeSocial.EventoId); //UmParaMuitos

            modelBuilder.Entity<RedeSocial>().HasOne(redeSocial => redeSocial.Palestrante)
                .WithMany(palestrante => palestrante.RedesSociais).HasForeignKey(redeSocial => redeSocial.PalestranteId); //UmParaMuitos

        }
    }
}
