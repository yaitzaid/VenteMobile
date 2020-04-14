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

        public DbSet<Critique> Critique { get; set; }
        public DbSet<Vendeur> Vendeur { get; set; }
        public DbSet<Manufacturier> Manufacturier { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<VendeurManufacturier> VendeurManufacturier { get; set; }
        public DbSet<VenteMobile.Models.TelephoneVendeur> TelephoneVendeur { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendeur>().HasData(
                new Vendeur { VendeurId =1 , VendeurNom = "Amazon", VendeurAddress = "1263 Boulevard Jolibourg #107, Laval, QC H7Y 1Z8", VendeurNoTel = "(514) 865-6220" },
                new Vendeur { VendeurId = 2, VendeurNom = "Best Buy", VendeurAddress = "2995 Boulevard Moïse-Vincent, Saint-Hubert, QC J3Z 1K2", VendeurNoTel = "(450) 710-2037" },
                new Vendeur { VendeurId =3 , VendeurNom = "KGE Électronique", VendeurAddress = "1040 Boulevard du Grand Héron, Saint-Jérôme, QC J7Y 5K8", VendeurNoTel = "(450) 420-1464" },
                new Vendeur { VendeurId =4 , VendeurNom = "Addison Électronique", VendeurAddress = "401 Boul Labelle Unit M-20, Rosemère, Quebec J7A 3T2", VendeurNoTel = "(514) 376-1740" },
                new Vendeur { VendeurId =5 , VendeurNom = "MONTREAL INFORMATIQUE", VendeurAddress = "3075 Chemin d'Oka local 110, Sainte-Marthe-sur-le-Lac, Quebec J0N 1P0", VendeurNoTel = "450) 766-2300" },
                new Vendeur { VendeurId =6, VendeurNom = "CIPC", VendeurAddress = " 8480 Boulevard Leduc Unit 100, Brossard, Quebec J4Y 0K7", VendeurNoTel = "(450) 461-1557" },
                new Vendeur { VendeurId =7, VendeurNom = "Dantech", VendeurAddress = "149 Boulevard Desjardins, Maniwaki, QC J9E 2C9", VendeurNoTel = "(450) 781-2030" },
                new Vendeur { VendeurId =8, VendeurNom = "Accès Electronique", VendeurAddress = "3908 Rue Saint-Denis, Montréal, QC H2W 2M4", VendeurNoTel = "(450) 744-0444" },
                new Vendeur { VendeurId =9 , VendeurNom = "The Source", VendeurAddress = "175 Chemin Jean-Adam, Saint-Sauveur, QC J0R 1R6", VendeurNoTel = "(450) 436-4883" },
                new Vendeur { VendeurId =10 , VendeurNom = "Top Laptop", VendeurAddress = "1025 Boulevard Lachapelle, Saint-Jérôme, QC J7Z 7M4", VendeurNoTel = "" },
                new Vendeur { VendeurId =11 , VendeurNom = "Lozeau", VendeurAddress = "1800 Avenue Auguste, Longueuil, QC J4V 3R4", VendeurNoTel = "(450) 443-3817" },
                new Vendeur { VendeurId =12, VendeurNom = "Dumoulin", VendeurAddress = " 4526 Rue Saint-Denis, Montréal, QC H2J 2L3", VendeurNoTel = "(514) 495-4636" },
                new Vendeur { VendeurId =13 , VendeurNom = "SONXPLUS", VendeurAddress = "145 Montée Masson, Mascouche, QC J7K 3B4", VendeurNoTel = "(514) 849-2999" },
                new Vendeur { VendeurId =14 , VendeurNom = "Centre Hi-Fi", VendeurAddress = "319 Rue Notre-Dame, Repentigny, QC J6A 2S1", VendeurNoTel = "(450) 704-4400" }

                );

            modelBuilder.Entity<Manufacturier>().HasData(
                 new Manufacturier { ManufacturierId=1 , ManufacturierMarque= "Apple ", ManufacturierSiteWeb= "www.apple.com", ManufacturierOrigine= "américaine" },
                 new Manufacturier { ManufacturierId =2 , ManufacturierMarque = "Samsung ", ManufacturierSiteWeb = "www.samsung.com", ManufacturierOrigine = "coréen" },
                 new Manufacturier { ManufacturierId =3 , ManufacturierMarque = "Nokia ", ManufacturierSiteWeb = "www.nokia.com", ManufacturierOrigine = "finlandaise" },
                 new Manufacturier { ManufacturierId =4 , ManufacturierMarque = "Blackberry", ManufacturierSiteWeb = "www.Blackberry.com", ManufacturierOrigine = "canadienne" },
                 new Manufacturier { ManufacturierId =5 , ManufacturierMarque = "Huawei", ManufacturierSiteWeb = "www.huawei.com", ManufacturierOrigine = "chinois" },
                 new Manufacturier { ManufacturierId =6 , ManufacturierMarque = "Htc", ManufacturierSiteWeb = "www.htc.com", ManufacturierOrigine = "Taïwan" },
                 new Manufacturier { ManufacturierId =7 , ManufacturierMarque = "LG", ManufacturierSiteWeb = "www.lg.com", ManufacturierOrigine = "coréen" },
                 new Manufacturier { ManufacturierId =8 , ManufacturierMarque = "Sony", ManufacturierSiteWeb = "www.sony.com", ManufacturierOrigine = "japonaise" },
                 new Manufacturier { ManufacturierId =9 , ManufacturierMarque = "Sharp", ManufacturierSiteWeb = "www.sharp.com", ManufacturierOrigine = "japonais " },
                 new Manufacturier { ManufacturierId =10 , ManufacturierMarque = "UMIDIGI ", ManufacturierSiteWeb = "www.umidigi.com", ManufacturierOrigine = "chinoise " }
                );

            modelBuilder.Entity<Telephone>().HasData(
                new Telephone { TelephoneId=1, TelephoneModel= "UMIDIGI F2 ", TelephoneCout=120, TelephoneCouleur="Noir", ManufacturierId=10 },
                new Telephone { TelephoneId =2, TelephoneModel = "UMIDIGI A3S", TelephoneCout =150, TelephoneCouleur = "Bleu", ManufacturierId = 10 },
                new Telephone { TelephoneId =3, TelephoneModel = "IPHONE 7 PLUS", TelephoneCout =450, TelephoneCouleur = "Blanc", ManufacturierId =1 },
                new Telephone { TelephoneId =4, TelephoneModel = "Samsung Galaxy S10+", TelephoneCout =350, TelephoneCouleur = "Blanc", ManufacturierId = 2 },
                new Telephone { TelephoneId =5, TelephoneModel = "SHARP AQUOS S2", TelephoneCout =199, TelephoneCouleur = "Bleu", ManufacturierId =9 },
                new Telephone { TelephoneId =6, TelephoneModel = "iphone 11 pro", TelephoneCout =900, TelephoneCouleur = "Gris", ManufacturierId = 1 },
                new Telephone { TelephoneId =7, TelephoneModel = "LG G8X", TelephoneCout =90, TelephoneCouleur = "Blanc", ManufacturierId =7 },
                new Telephone { TelephoneId =8, TelephoneModel = "UMIDIGI A3S", TelephoneCout =99, TelephoneCouleur = "Bleu", ManufacturierId = 10 },
                new Telephone { TelephoneId =9, TelephoneModel = "HUAWEI P30 Pro", TelephoneCout =89, TelephoneCouleur = "Gris", ManufacturierId = 5 },
                new Telephone { TelephoneId =10, TelephoneModel = "Huawei P Smart", TelephoneCout =199, TelephoneCouleur = "", ManufacturierId = 5 },
                new Telephone { TelephoneId =11, TelephoneModel = "Huawei Y5 ", TelephoneCout =149, TelephoneCouleur = "Blanc", ManufacturierId = 5 },
                new Telephone { TelephoneId =12, TelephoneModel = "iPhone X", TelephoneCout =840, TelephoneCouleur = "Noir", ManufacturierId = 1 },
                new Telephone { TelephoneId =13, TelephoneModel = "Blackberry Key2", TelephoneCout =250, TelephoneCouleur = "Gris", ManufacturierId =4 },
                new Telephone { TelephoneId =14, TelephoneModel = "LG K30", TelephoneCout =129, TelephoneCouleur = "Bleu", ManufacturierId =7 },
                new Telephone { TelephoneId =15, TelephoneModel = " iPhone 8", TelephoneCout =589, TelephoneCouleur = "Noir", ManufacturierId = 1 },
                new Telephone { TelephoneId =16, TelephoneModel = "NOKIA 5.1 Global ", TelephoneCout =89, TelephoneCouleur = "Noir", ManufacturierId =3 },
                new Telephone { TelephoneId =17, TelephoneModel = "Samsung Galaxy A70 ", TelephoneCout =249, TelephoneCouleur = "Noir", ManufacturierId = 2 },
                new Telephone { TelephoneId =18, TelephoneModel = "UMIDIGI A3X ", TelephoneCout =129, TelephoneCouleur = "Gris", ManufacturierId = 10 }
                  );
            modelBuilder.Entity<Critique>().HasData(
                new Critique { CritiqueId=1, CritiqueText="Le meilleur", CritiqueEtoiles=6, CritiqueNom="Alice", TelephoneId=1 },
                new Critique { CritiqueId =2, CritiqueText = "Mauvais", CritiqueEtoiles = 1, CritiqueNom = "Kamal", TelephoneId =2 },
                new Critique { CritiqueId =3, CritiqueText = "Parfait", CritiqueEtoiles = 5, CritiqueNom = "Jean", TelephoneId =3 },
                new Critique { CritiqueId =4, CritiqueText = "Bien", CritiqueEtoiles = 5, CritiqueNom = "Nassin", TelephoneId =4 },
                new Critique { CritiqueId =5, CritiqueText = "Tres bien", CritiqueEtoiles = 6, CritiqueNom = "Maxi", TelephoneId =5 },
                new Critique { CritiqueId =6, CritiqueText = "j'aime", CritiqueEtoiles = 5, CritiqueNom = "Bob", TelephoneId =6 },
                new Critique { CritiqueId =7, CritiqueText = "Super", CritiqueEtoiles = 5, CritiqueNom = "Mizo", TelephoneId =6 },
                new Critique { CritiqueId =8, CritiqueText = "pas bien", CritiqueEtoiles = 2, CritiqueNom = "Kana", TelephoneId =8 },
                new Critique { CritiqueId =9, CritiqueText = "Probleme ecran", CritiqueEtoiles = 3, CritiqueNom = "Annir", TelephoneId =8 },
                new Critique { CritiqueId =10, CritiqueText = "Probleme affichage", CritiqueEtoiles = 3, CritiqueNom = "Yannis", TelephoneId =7 },
                new Critique { CritiqueId =11, CritiqueText = "Parfait", CritiqueEtoiles = 5, CritiqueNom = "Med", TelephoneId =6 },
                new Critique { CritiqueId =12, CritiqueText = "J'adore", CritiqueEtoiles = 5, CritiqueNom = "Basso", TelephoneId =4 },
                new Critique { CritiqueId =13, CritiqueText = "le meilleur de l'annee", CritiqueEtoiles = 6, CritiqueNom = "Youri", TelephoneId =3 },
                new Critique { CritiqueId =14, CritiqueText = "J'adore", CritiqueEtoiles = 6, CritiqueNom = "Max", TelephoneId = 1},
                new Critique { CritiqueId =15, CritiqueText = "Probleme batterie", CritiqueEtoiles = 1, CritiqueNom = "Tony", TelephoneId =2 },
                new Critique { CritiqueId =16, CritiqueText = "Mauvais", CritiqueEtoiles = 2, CritiqueNom = "Berry", TelephoneId = 2},
                new Critique { CritiqueId =17, CritiqueText = "Le meilleur", CritiqueEtoiles = 6, CritiqueNom = "Hanid", TelephoneId =2 },
                new Critique { CritiqueId =18, CritiqueText = "Mauvais", CritiqueEtoiles = 3, CritiqueNom = "Pepo", TelephoneId =4 },
                new Critique { CritiqueId =19, CritiqueText = "Tres bien", CritiqueEtoiles = 6, CritiqueNom = "Loka", TelephoneId =6 },
                new Critique { CritiqueId =20, CritiqueText = "Probleme affichage", CritiqueEtoiles = 2, CritiqueNom = "Lucie", TelephoneId =8 },
                new Critique { CritiqueId =21, CritiqueText = "Probleme batterie", CritiqueEtoiles = 1, CritiqueNom = "Bob", TelephoneId =10 },
                new Critique { CritiqueId =22, CritiqueText = "Probleme ecran", CritiqueEtoiles = 1, CritiqueNom = "Yannis", TelephoneId = 11},
                new Critique { CritiqueId =23, CritiqueText = "Bien", CritiqueEtoiles = 5, CritiqueNom = "Vanissa", TelephoneId =16 },
                new Critique { CritiqueId =24, CritiqueText = "Probleme tactile", CritiqueEtoiles =3 , CritiqueNom = "Youry", TelephoneId =16 },
                new Critique { CritiqueId =25, CritiqueText = "Je recommande", CritiqueEtoiles =5 , CritiqueNom = "Phelipe", TelephoneId =18 }
                );

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
