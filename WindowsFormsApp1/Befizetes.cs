using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Befizetes
    {
        int id;
        DateTime szul;
        int osszeg;

        public int Id { get => id; set => id = value; }
        public DateTime Szul { get => szul; set => szul = value; }
        public int Osszeg { get => osszeg; set => osszeg = value; }

        public Befizetes(int id, DateTime szul, int osszeg)
        {
            this.Id = id;
            this.Szul = szul;
            this.Osszeg = osszeg;
        }
    }
}
