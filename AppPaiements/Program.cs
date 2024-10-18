using AppPaiements;

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
       

    }
}