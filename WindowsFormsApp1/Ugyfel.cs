using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Ugyfel
    {
        int id;
        string nev;
        int szulev;
        int irszam;
        string orszag;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Szulev { get => szulev; set => szulev = value; }
        public int Irszam { get => irszam; set => irszam = value; }
        public string Orszag { get => orszag; set => orszag = value; }

        public Ugyfel(int id, string nev, int szulev, int irszam, string orszag)
        {
            this.Id = id;
            this.Nev = nev;
            this.Szulev = szulev;
            this.Irszam = irszam;
            this.Orszag = orszag;
        }
        public override string ToString()
        {
            return this.nev;
        }
    }
}
