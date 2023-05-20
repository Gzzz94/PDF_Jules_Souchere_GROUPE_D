using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF
{
    //modélise un poulailler
    public class Poulailler
    {
        string nomDuPO;
        static int CapaciteMAX;

        List<Poule> poulailler = new List<Poule>();

        public Poulailler(string nomPO, int CapaciteMax)
        {
            nomDuPO = nomPO;
            CapaciteMAX = CapaciteMax;

        }

        /// <summary>
        /// Création d'une nouvelle instance d'un objet Poulailler
        /// </summary>
        /// <param name="nomDuPO">Nom du poulailler</param>
        /// <param name="CapaciteMAX">Capacité maximum du poulailler </param>


        // Afficher le numéro de la poule dans le poulailler

        public void AfficherPoulailler()
        {

            int numero = 0;
            foreach (Poule poule in poulailler)
            {
                Console.Write($"{numero} : ");
                poule.Afficher();
                numero++;
            }
        }

        // fonction pour ajouter une poule au poulailler
        public void Ajouter(Poule poule)
        {
            if (Poulailler.CapaciteMAX <= poulailler.Count)
            {
                Console.WriteLine("Impossible d'ajouter une poule");
            }
            else
            {
                poulailler.Add(poule);
            }
        }

        // fonction pour supprimer une poule au poulailler
        public void Supprimer(int a)
        {
            poulailler.RemoveAt(a);
            Console.WriteLine("La poule a été supprimée");
        }

    }
}
