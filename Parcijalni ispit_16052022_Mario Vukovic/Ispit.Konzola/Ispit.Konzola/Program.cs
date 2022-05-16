using Ispit.Konzola.Sucelja;
using System;
using System.Runtime.Intrinsics.Arm;
using Ispit.Konzola.Model;



namespace Ispit.Konzola
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var pametniTelefon = new PametniTelefon("Samsung Galaxy S22");

            TestirajTelefon(pametniTelefon);
        }

        public static void TestirajTelefon(IPametniTelefon telefon)
        {
            var objekt = (PametniTelefon) telefon;
            Console.WriteLine("=====================================");
            Console.WriteLine($"Model mobitela je: {objekt.Model}");
            Console.WriteLine("=====================================");
            
            Console.WriteLine("Unesite telefonski broj: ");
            var telefonskiBroj = Console.ReadLine();
            telefon.Poziv(telefonskiBroj);
            
            Console.WriteLine("Unesite URL: ");
            var url = Console.ReadLine();
            telefon.Surfaj(url);

            Console.ReadKey();

        }




    }
}
