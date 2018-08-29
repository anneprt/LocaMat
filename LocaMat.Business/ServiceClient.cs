using LocaMat.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.Business
{
    public class ServiceClient : IServiceClient
    {

        private readonly IDonneesClient donnees;

        public ServiceClient()
        {
            this.donnees = new DonneesClient();
        }

        public void CreerClient(Client client)
        {
            if (client == null)
            {
                throw new BusinessException("Aucun client n'a été fourni");
            }

            if (string.IsNullOrWhiteSpace(client.Nom))
            {
                throw new BusinessException("Le nom est requis");
            }

            if (string.IsNullOrWhiteSpace(client.Prenom))
            {
                throw new BusinessException("Le prénom est requis");
            }

            this.donnees.Enregistrer(client);
        }

        public void SupprimerClient(Client client)
        {
            if (client == null)
            {
                throw new BusinessException("Aucun client n'a été fourni");
            }

            this.donnees.Supprimer(client);
        }

        public IEnumerable<Client> GetClients()
        {
            return this.donnees.GetListe();
        }

        public IEnumerable<Client> ChercherClient(string texte)
        {
            if (string.IsNullOrWhiteSpace(texte))
            {
                return this.donnees.GetListe();
            }

            return this.donnees.GetListe()
                .Where(x => x.Prenom.StartsWith(texte, StringComparison.OrdinalIgnoreCase)
                            || x.Nom.StartsWith(texte, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
