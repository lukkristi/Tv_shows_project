using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Osoba_uloga
    {
        public string ImePrezime { get; set; }
        public string Uloga { get; set; }

        public Osoba_uloga(string imePrezime, string uloga)
        {
            this.ImePrezime = imePrezime;
            this.Uloga = uloga;
        }
    }
}
