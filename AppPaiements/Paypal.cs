using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }

        public Paypal(double montant, string description, string email) : base(montant, description)
        {

            Courriel = email;

        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"La description du paiement est {Description}, il a une valeur de {Montant}$ et l'email est {Courriel}.");
        }


    }
}
