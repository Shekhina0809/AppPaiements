using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom {  get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom ) {

            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public virtual void AfficherInfos()
        {
            Console.WriteLine($"Le nom de l'utilisateur est {Nom}.");

            foreach (var paiement in Paiements)
            {

                paiement.AfficherDetails();

            }

        }

        public virtual void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add( paiement );
        }
    }
}
