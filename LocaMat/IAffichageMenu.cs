using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat
{
    public interface IMenuClient<T>
    {
        // Récupérer une liste
        IEnumerable<T> Lister();

        //Créer un item de liste
        void Creer(T donnée);

        //Supprimer un item de menu
        void Supprimer(T donnée);

        //Modifier un item de menu
        void Modifier(T donnée);


    }
}
