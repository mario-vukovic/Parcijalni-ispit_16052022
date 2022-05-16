using Ispit.Konzola.Sucelja;
using System;
using System.Linq;

namespace Ispit.Konzola.Model
{
    public class PametniTelefon : IPametniTelefon

    {
        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Model { get; private set; }

        public string Surfaj(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                Console.WriteLine("Moguce je surfati na url {0}", url);
            }

            else
            {
                Console.WriteLine("Neispravan url!");
                throw new Exception("Neispravan url!");
            }

            return url;
        }

        public string Poziv(string telefonskiBroj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonskiBroj))
            {
                Console.WriteLine("Moguce je zvati na {0}", telefonskiBroj);
            }

            else
            {

                Console.WriteLine("Neispravan telefonski broj!");
                throw new Exception("Neispravan telefonski broj!");
            }

            return telefonskiBroj;
        }

        private static bool ProvjeriAkoJeValidanUrl(string url)
        {
            return !url.Any(char.IsDigit);
        }

        private static bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            return telefonski_broj.All(char.IsDigit);
        }


    }
}
