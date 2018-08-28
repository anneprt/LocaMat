using LocaMat.Business;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat.DAL
{
    public class DonneesClient : IDonneesClient
    {
        public void Enregistrer(Client client)
        {
            if (client.Id == 0)
            {
                Ajouter(client);
            }
            else
            {
                Modifier(client);
            }
        }

        public IEnumerable<Client> GetListe()
        {
            var listeContacts = new List<Client>();

            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText = "SELECT * FROM Clients";
                var reader = commande.ExecuteReader();
                while (reader.Read())
                {

                    var client = new Client();
                    client.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    client.Nom = reader.GetString(reader.GetOrdinal("Nom"));
                    client.Prenom = reader.GetString(reader.GetOrdinal("Prenom"));
                    client.Adresse = reader.GetString(reader.GetOrdinal("Adresse"));


                    listeContacts.Add(client);
                }
            }

            return listeContacts;
        }

        public void Supprimer(Client client)
        {
            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText = "DELETE Clients WHERE Id = @IdClient";
                commande.Parameters.AddWithValue("@IdContact", client.Id);
                commande.ExecuteNonQuery();
            }
        }

        private void Ajouter(Client client)
        {
            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText =
                    @"INSERT INTO Contacts (Nom, Prenom, Adresse)
                        VALUES (@Nom, @Prenom, @Adresse)";
                commande.Parameters.AddWithValue("@Nom", client.Nom);
                commande.Parameters.AddWithValue("@Prenom", client.Prenom);
                commande.Parameters.AddWithValue("@Adresse", client.Adresse);
                commande.ExecuteNonQuery();
            }
        }

        private void Modifier(Client client)
        {
            using (var connexion = CreerConnexion())
            {
                connexion.Open();

                var commande = connexion.CreateCommand();
                commande.CommandText =
                    @"UPDATE Contacts SET Nom = @Nom, Prenom = @Prenom, 
                                          Adresse=@Adresse
                      WHERE Id = @Id";
                commande.Parameters.AddWithValue("@Id", client.Id);
                commande.Parameters.AddWithValue("@Nom", client.Nom);
                commande.Parameters.AddWithValue("@Prenom", client.Prenom);
                commande.Parameters.AddWithValue("@Adresse", client.Adresse);

                commande.ExecuteNonQuery();
            }
        }

        private SqlConnection CreerConnexion()
        {
            return new SqlConnection(
                ConfigurationManager
                .ConnectionStrings["Contexte"]
                .ConnectionString);
        }
    }
}
