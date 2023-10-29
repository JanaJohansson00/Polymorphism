namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här nedan kommer mina beräkningar av olika geometriformer i area!");
            Console.WriteLine("-----------------------------------------------------------------");

            Geometri geometri; //Skapar en instans av Geometri som refererar till objekt av olika figurer.

            geometri = new Fyrkant(); //Skapar ett objekt av Fyrkant och kopplar det till Geometri instansen.
            Console.WriteLine($"Arean av Fyrkant: {geometri.Area()} cm"); //Anropar Area metoden och skriver ut resultat.

            geometri = new Cirkel();
            Console.WriteLine($"Arean av Cirkel: {geometri.Area()} cm");

            geometri = new Rektangel();
            Console.WriteLine($"Arean av Rektangel: {geometri.Area()} cm");

            geometri = new Parallellogram();
            Console.WriteLine($"Arean av Parallellogram: {geometri.Area()} cm");

            geometri = new Ellips();
            Console.WriteLine($"Arean av Ellips: {geometri.Area()} cm");

        }
    }
}