using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Uloga
    {
        public int ID;
        public string Opis_Uloge;


        public Uloga(int id , string opis_uloge)
        {
            this.ID = id;
            this.Opis_Uloge = opis_uloge;
        }
        public Uloga() { }
    }
}
