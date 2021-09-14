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

    }
}
