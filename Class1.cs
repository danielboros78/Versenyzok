using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzok
{
    class Adatok
    {
        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        private string szuletesiDatum;

        public string SzuletesiDatum
        {
            get { return szuletesiDatum; }
            set { szuletesiDatum = value; }
        }

        private string nemzetiseg;

        public string Nemzetiseg
        {
            get { return nemzetiseg; }
            set { nemzetiseg = value; }
        }

        private int rajtszam;

        public int Rajtszam
        {
            get { return rajtszam; }
            set { rajtszam = value; }
        }

        public Adatok(string egySor)
        {
            string[] sor = egySor.Split(';');
            this.nev = sor[0];
            this.szuletesiDatum = sor[1];
            this.nemzetiseg = sor[2];
            if (!string.IsNullOrEmpty(sor[3]))
            {
                this.rajtszam = int.Parse(sor[3]);
            }
        }
    }
}
