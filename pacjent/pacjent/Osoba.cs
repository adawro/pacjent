using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacjent
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void WypiszInfo()
        {
            Console.Write("{0} {1} ", imie,nazwisko);
        }


    }
    class Pacjent : Osoba
    {
        private int wiek;

        public Pacjent(string imie, string nazwisko, int wiek)
            :base (imie,nazwisko)
        {
            this.wiek = wiek;

        }
        public void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("{0}", wiek);
        }

    }
}
 
