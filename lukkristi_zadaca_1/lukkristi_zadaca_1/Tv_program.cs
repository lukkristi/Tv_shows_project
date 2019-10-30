using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Tv_program
    {
        public int ID { get; set; }
        public List<String> DaniUTjednu { get; set; }
        public int VrijemePocetka { get; set; }
        public List<Osoba_uloga> Uloge { get; set; }

        public Tv_program(int id, string dan, int vrijemePocetka)
        {
            this.ID = id;
            //this.Dan = dan;
            this.VrijemePocetka = vrijemePocetka;
        }

        public void OdrediDaneUTjednu(string dan)
        {

        }
    }
}
