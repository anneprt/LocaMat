using LocaMat.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.DAL
{
    public interface IDonneesClient
    {
        IEnumerable<Client> GetListe();
        void Enregistrer(Client client);
        void Supprimer(Client client);
    }
}
