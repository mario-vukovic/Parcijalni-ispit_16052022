using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Sucelja
{
    public interface ITelefon
    {
        public string Model { get; }
        string Poziv(string telefonskiBroj);
    }
}
