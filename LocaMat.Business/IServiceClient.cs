using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LocaMat.Business
{
    public interface IServiceClient
    {
        IEnumerable<Client> GetClients();

        void CreerClient(Client client);

        void SupprimerClient(Client Client);


    }
}
