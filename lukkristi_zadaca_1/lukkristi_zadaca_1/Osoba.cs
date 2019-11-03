using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    public class Osoba
    {
        public int ID { get; set; }
        public string ImePrezime { get; set; }

        public Osoba(int id, string imePrezime)
        {
            this.ID = id;
            this.ImePrezime = imePrezime;
        }
        public Osoba()
        {

        }
    }
}
