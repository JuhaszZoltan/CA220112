using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220112
{
    internal class Futo
    {
        public string Nev { get; set; }
        public int Rajtszam { get; set; }
        public bool Kategoria { get; set; }
        public TimeSpan Ido { get; set; }
        public int TavSzazalek { get; set; }

        public Futo(string sor)
        {
            var v = sor.Split(';');
            Nev = v[0];
            Rajtszam = int.Parse(v[1]);
            Kategoria = v[2] == "Ferfi";
            var t = v[3].Split(':');
            Ido = new TimeSpan(
                hours: int.Parse(t[0]),
                minutes: int.Parse(t[1]),
                seconds: int.Parse(t[2]));            
            TavSzazalek = int.Parse(v[4]);
        }
    }
}
