using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Bezienswaardigheid
    {
        // DATA
        private string adres;
        private double entreeprijs;
        private string naam;
        private string plaats;
        private string postcode;

        // CONSTRUCTOR
        public Bezienswaardigheid(string adres, double entreeprijs, string naam, string plaats, string postcode)
        {
            this.adres = adres;
            this.entreeprijs = entreeprijs;
            this.naam = naam;
            this.plaats = plaats;
            this.postcode = postcode;
        }

        // PROPETIES
        public string Adres
        {
            get { return adres; }
        }

        public double Entreeprijs
        {
            get { return entreeprijs; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public string Plaats
        {
            get { return plaats; }
        }

        public string Postcode
        {
            get { return postcode; }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Adres: " + Adres + " Entreeprijs " + Entreeprijs + " Naam: " + Naam + " Plaats: " + Plaats + " Postcode: " + Postcode;
        }
    }
}
