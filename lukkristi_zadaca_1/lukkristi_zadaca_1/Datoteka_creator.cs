using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace lukkristi_zadaca_1
{
    abstract class Datoteka_creator
    {
        public List<Emisija> Emisije { get;  set; } = new List<Emisija>();
        public List<Osoba> Osobe { get;  set; } = new List<Osoba>();
        public List<Tv_program> Programi { get;  set; } = new List<Tv_program>();
        public List<Uloga> Uloge  { get;  set; } = new List<Uloga>();
        public virtual void UcitajDatoteku(string putanja)
        {
            if (File.Exists(putanja))
            {
                string[] datoteka = File.ReadAllLines(putanja + "DZ_1_uloge.txt").Skip(1).Distinct().ToArray();
                if (putanja.Contains("emisije"))
                    Emisije = UrediPodatkeZaEmisije(datoteka);
                else if (putanja.Contains("osobe"))
                    Osobe = UrediPodatkeZaOsobe(datoteka);
                else if (putanja.Contains("uloge"))
                    Uloge = UrediPodatkeZaUloge(datoteka);

            }
            Console.WriteLine( "DATOTEKA NE POSTOJI!");
            return;
        }

        internal abstract List<Osoba> UrediPodatkeZaOsobe(string[] datoteka);
        internal abstract List<Uloga> UrediPodatkeZaUloge(string[] datoteka);
        internal abstract List<Emisija> UrediPodatkeZaEmisije(string[] datoteka);
        
    }
}
