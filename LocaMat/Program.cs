using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaMat
{
    class Program
    {
        static void Main(string[] args)
        {
            OutilsConsole.AfficherEntete();
            Console.ReadKey();
            AfficherMenuPrincipal();

            //TODO module de connexion à l'appli
            Console.WriteLine();
            /* while (true)
             {
                 var choix = AfficherMenu();
                 switch (choix)
                 {
                     case 1:
                         var marque = ChoisirMarque();
                         AfficherModeles(marque);
                         break;
                     case 2:
                         AfficherMarques();
                         break;
                     case 3:
                         CreerMarque();
                         break;
                     case 4:
                         ModifierMarque();
                         break;
                     case 5:
                         SupprimerMarque();
                         break;
                     case 9:
                         Environment.Exit(0);
                         break;
                 }
                 Console.WriteLine("Appuyez pour retourner au menu...");
                 Console.ReadKey();*/
        }

        private static int AfficherMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1. Gestion des Agences");
            Console.WriteLine("2. Gestion des Produits");
            Console.WriteLine("3. Gestion des clients");
            Console.WriteLine("4. Gestion des locations");
            Console.WriteLine("5. Gestion des offres produits");
            Console.WriteLine("9. Quitter");
            Console.Write("Votre choix: ");
            return int.Parse(Console.ReadLine());
        }

        public static int AfficherMenuGestion

    }    }
    

