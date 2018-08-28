using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.Business
{
    public class Produit

    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        public int IdCategorie { get; set; }
        [ForeignKey("IdCategorie")]
        public virtual CategorieProduit CategorieProduit { get; set; }

        public decimal PrixJourHT { get; set; }

    }
}
