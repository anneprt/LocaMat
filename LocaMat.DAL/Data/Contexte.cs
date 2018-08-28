using LocaMat.Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.DAL.Data
{
    public class Contexte : DbContext
    {
        public DbSet<Agence> Agences { get; set; }
        public DbSet<CategorieProduit> CategorieProduits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OffreProduit> OffreProduits { get; set; }
        public DbSet<Produit> Produits { get; set; }

    }
}
