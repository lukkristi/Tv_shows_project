using System;
using System.Collections.Generic;
using System.Text;

namespace lukkristi_zadaca_1
{
    class Emisija_concrete : Datoteka_creator
    {
        

        internal override List<Emisija> UrediPodatkeZaEmisije(string[] datoteka)
        {
            List<Emisija> emisije = new List<Emisija>();
            foreach (var red in datoteka)
            {
                string[] podaci = red.Split(";");
                List<Osoba_uloga> popisOsobaiUloga = new List<Osoba_uloga>();
                if (podaci.Length>3 && podaci[3]!="")
                    
                {
                    string[] osobeUloge = podaci[3].Split(",");
                    foreach (var item in osobeUloge)
                    {
                        string[] osobaIUloga = item.Split("-");
                        Osoba_uloga novaOsobaUloga = new Osoba_uloga();
                        novaOsobaUloga.Osoba.ID = int.Parse(osobaIUloga[0]);
                        novaOsobaUloga.Uloga.ID = int.Parse(osobaIUloga[0]);
                        popisOsobaiUloga.Add(novaOsobaUloga);
                    }
                }
                Emisija novaEmisija = new Emisija(int.Parse(podaci[0]), podaci[1], int.Parse(podaci[2]));
                novaEmisija.DohvatiUlogeZaEmisiju(popisOsobaiUloga);
                emisije.Add(novaEmisija);

            }
            return emisije;
        }

        internal override List<Osoba> UrediPodatkeZaOsobe(string[] datoteka)
        {
            throw new NotImplementedException();
        }

        internal override List<Tv_program> UrediPodatkeZaPrograme(string[] datoteka)
        {
            throw new NotImplementedException();
        }

        internal override List<Uloga> UrediPodatkeZaUloge(string[] datoteka)
        {
            throw new NotImplementedException();
        }
    }
}
