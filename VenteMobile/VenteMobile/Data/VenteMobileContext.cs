using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VenteMobile.Models;

namespace VenteMobile.Data
{
    public class VenteMobileContext : DbContext
    {
        public VenteMobileContext (DbContextOptions<VenteMobileContext> options)
            : base(options)
        {
        }

        public DbSet<VenteMobile.Models.Critique> Critique { get; set; }
        public DbSet<VenteMobile.Models.Vendeur> Vendeur { get; set; }
        public DbSet<VenteMobile.Models.Manufacturier> Manufacturier { get; set; }
        public DbSet<VenteMobile.Models.Telephone> Telephone { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TelephoneVendeur>()
                .HasKey(tv => new { tv.TelephoneId, tv.VendeurId });
            modelBuilder.Entity<TelephoneVendeur>()
                .HasOne(tv => tv.Telephone)
                .WithMany(t => t.TelephonesVendeurs)
                .HasForeignKey(tv => tv.TelephoneId);
            modelBuilder.Entity<TelephoneVendeur>()
                .HasOne(tv => tv.Vendeur)
                .WithMany(v => v.TelephonesVendeurs)
                .HasForeignKey(tv => tv.VendeurId);

            modelBuilder.Entity<VendeurManufacturier>()
                .HasKey(mv => new { mv.ManufacturierId, mv.VendeurId });
            modelBuilder.Entity<VendeurManufacturier>()
                .HasOne(mv => mv.Manufacturier)
                .WithMany(m => m.VendeursManufacturiers)
                .HasForeignKey(mv => mv.ManufacturierId);
            modelBuilder.Entity<VendeurManufacturier>()
                .HasOne(mv => mv.Vendeur)
                .WithMany(v => v.VendeursManufacturiers)
                .HasForeignKey(mv => mv.VendeurId);
        }
    }
}
