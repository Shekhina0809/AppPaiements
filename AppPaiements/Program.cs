﻿using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carte1 = new CarteCredit(14.68, "Le Beau", 509089123);
        CarteCredit carte2 = new CarteCredit(20.99 , "Canada WonderLand", 618119893);
        CarteCredit carte3 = new CarteCredit(80.56, "No Frills", 763248654);


        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();


        Paypal pay1 = new Paypal(75.98, "Zara paiement", "princess@gmail.com");
        Paypal pay2 = new Paypal(11.02, "Amazon paiement", "princ@gmail.com");
        Paypal pay3 = new Paypal(125.98, "COS paiement", "miss@hotmail.com");

        pay1.AfficherDetails();
        pay2.AfficherDetails();
        pay3.AfficherDetails();




        Paiement paiement1 = new Paiement(200.89, "Stradivarus");
        Paiement paiement2 = new Paiement(20.89, "Shop");
        Paiement paiement3 = new Paiement(87.35, "Stradivarus");


        Utilisateur user1 = new Utilisateur ("Shekhina");
        Utilisateur user2 = new Utilisateur("Bidossessi");
        Utilisateur user3 = new Utilisateur("Aigline");


        user1.AjouterPaiement (paiement1);
        user1.AfficherInfos();


        user2.AjouterPaiement(paiement2);
        user2.AfficherInfos();


        user3.AjouterPaiement(paiement3);
        user3.AfficherInfos();


    }
}