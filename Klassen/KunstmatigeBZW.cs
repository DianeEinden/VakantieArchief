using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class KunstmatigeBZW : Bezienswaardigheid
    {
        // DATA
        private char afspraakNodig;
        private int bouwjaar;
        private string functie;
        private string omschrijving;
        private string oprichter;
        private char rondleiding;
        private string telefoonnummer;
        private string type;

        // CONSTRUCTOR
        public KunstmatigeBZW(char afspraakNodig, int bouwjaar, string functie, string omschrijving, string oprichter, char rondleiding, string telefoonnummer, string type, string adres,string naam, double entreeprijs, string plaats, string postcode)
            :base (adres, entreeprijs, naam, plaats, postcode)
        {
            this.afspraakNodig = afspraakNodig;
            this.bouwjaar = bouwjaar;
            this.functie = functie;
            this.omschrijving = omschrijving;
            this.oprichter = oprichter;
            this.rondleiding = rondleiding;
            this.telefoonnummer = telefoonnummer;
            this.type = type;
        }

        // PROPETIES
        public char AfspraakNodig
        {
            get { return afspraakNodig; }
        }

        public int Bouwjaar
        {
            get { return bouwjaar; }
        }

        public string Functie
        {
            get { return functie; }
        }

        public string Omschrijving
        {
            get { return omschrijving; }
        }

        public string Oprichter
        {
            get { return oprichter; }
        }

        public char Rondleiding
        {
            get { return rondleiding; }
        }

        public string Telefoonnummer
        {
            get { return telefoonnummer; }
        }

        public string Type
        {
            get { return type; }
        }

        // TOSTRING
        public override string ToString()
        {
            return base.ToString() + " Afspraak nodig:" + AfspraakNodig + " Bouwjaar: " + bouwjaar + " Funtie: " + Functie + " Omschrijving " + Omschrijving + " Oprichter: " + Oprichter + " Rondleiding: " + Rondleiding + " Telefoonnummer: " + Telefoonnummer + " Type: " + Type;
        }
    }
}
