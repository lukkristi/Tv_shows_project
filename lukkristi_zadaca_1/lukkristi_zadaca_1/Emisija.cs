using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Emisija
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }
        public List<Osoba_uloga> Uloge { get; set; }

        public Emisija(int id, string naziv, int trajanje )
        {
            this.ID = id;
            this.Naziv = naziv;
            this.Trajanje = trajanje;
            
        }

        public void DohvatiUlogeZaEmisiju(List<Osoba_uloga> uloge)
        {
            foreach (Osoba_uloga item in uloge)
            {
                this.Uloge.Add(item);
            }
        }
       
    }
}
