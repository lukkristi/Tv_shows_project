using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Osoba_concrete : Datoteka_creator
    {
        internal override List<Emisija> UrediPodatkeZaEmisije(string[] datoteka)
        {
            throw new NotImplementedException();
        }

        internal override List<Osoba> UrediPodatkeZaOsobe(string[] datoteka)
        {
            List<Osoba> osobe = new List<Osoba>();
            foreach (var red in datoteka)
            {
                string[] podaci = red.Split(";");               
                
                Osoba novaOsoba = new Osoba(int.Parse(podaci[0]), podaci[1]);
                
                osobe.Add(novaOsoba);

            }
            return osobe;
        }

        internal override List<Uloga> UrediPodatkeZaUloge(string[] datoteka)
        {
            throw new NotImplementedException();
        }
    }
}
