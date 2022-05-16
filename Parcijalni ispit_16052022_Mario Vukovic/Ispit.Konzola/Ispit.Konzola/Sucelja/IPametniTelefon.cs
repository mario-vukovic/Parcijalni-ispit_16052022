using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Sucelja
{
    public interface IPametniTelefon : ITelefon
    {
        public string Surfaj(string url);
    }
}
