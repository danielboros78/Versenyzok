using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Versenyzok
{
    class Program
    {
        static List<Adatok> adat = new List<Adatok>();
        static void Main(string[] args)
        {
            MasodikFeladat();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();
            Console.ReadKey();
        }

        private static void HetedikFeladat()
        {

        }

        private static void HatodikFeladat()
        {

        }

        private static void OtodikFeladat()
        {
            DateTime[] datum = new DateTime[adat.Count];
            for (int i = 0; i < datum.Length; i++)
            {
                datum[i] = DateTime.Parse(adat[i].SzuletesiDatum);
            }
            for (int i = 0; i < datum.Length; i++)
            {
                if (datum[i] < DateTime.Parse("1901.01.01"))
                {
                    Console.WriteLine($"\t{adat[i].Nev} ( {adat[i].SzuletesiDatum} )");
                }
            }
        }

        private static void NegyedikFeladat()
        {
            Console.WriteLine($"4. feladat: {adat.Last().Nev}");
        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine($"3. feladat: {adat.Count}");
        }

        private static void MasodikFeladat()
        {
            Console.WriteLine("2. feladat: Adatok beolvasása");
            StreamReader olvas = new StreamReader("pilotak.csv");
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                adat.Add(new Adatok(olvas.ReadLine()));

            }
            olvas.Close();
        }
    }
}
