using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace Data
{

   public class ExamenContext:DbContext
    {
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Entraineur> Entraineurs { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Membre> Membres { get; set; }
        public DbSet<Trophee> Trophees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog=FederationBD;
                                        Integrated Security=true;
                                        MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TABLE HERITAGE TPH TYPES AND VALUES
            modelBuilder.Entity<Membre>().HasDiscriminator<Char>("Type").HasValue<Entraineur>('E').HasValue<Joueur>('J').HasValue<Membre>('M');
            //RELATION MANY TO MANY COMPOSITE KEY
            modelBuilder.Entity<Contrat>().HasKey(c => new { c.EquipeId, c.Identifiant, c.DateContrat });
            //RELATION ONE TO MANY 
            modelBuilder.Entity<Trophee>()
                .HasOne(t => t.Equipe).WithMany(e => e.Trophees)
                .HasForeignKey(t => t.EquipeFK);


            /*
             * // Configure Student & StudentAddress entity
                 modelBuilder.Entity<Student>()
                .HasOptional(s => s.Address) // Mark Address property optional in Student entity
                .WithRequired(ad => ad.Student); // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student

             // Configure StudentId as FK for StudentAddress
                 modelBuilder.Entity<Student>()
                .HasRequired(s => s.Address) 
                .WithRequiredPrincipal(ad => ad.Student); 

            */
            base.OnModelCreating(modelBuilder);
        }
    }
   

}
