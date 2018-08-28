using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.Business
{
    public class OffreProduit
    {
        public int Id { get; set; }

        public int IdProduit { get; set; }
        [ForeignKey("IdProduit")]
        public virtual Produit Produit { get; set; }

        public int IdAgence { get; set; }
        [ForeignKey("IdAgence")]
        public virtual Agence Agence { get; set; }


        public int Quantité { get; set; }

    }
}
