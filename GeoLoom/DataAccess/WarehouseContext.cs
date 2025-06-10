using GeoLoom.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLoom.DataAccess
{
    public class Geoloom : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<FamilleArticle> FamilleArticles { get; set; }
        public DbSet<Emplacement> Emplacements { get; set; }
        public DbSet<Magasin> Magasins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MvtStk> MvtStks { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<LgnCmd> LgnCmds { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=YourDatabase;Trusted_Connection=True;");
        }
    }
}
