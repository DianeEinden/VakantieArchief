using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class NatuurlijkeBZW : Bezienswaardigheid
    {
        // DATA
        private string geschiedenis;
        private string omschrijving;
        private string ontstaan;
        private double oppervlakte;

        // CONSTRUCTOR
        public NatuurlijkeBZW (string geschiedenis, string omschrijving, string ontstaan, double oppervlakte, string adres, double entreeprijs, string naam, string plaats, string postcode) 
            :base (adres, entreeprijs, naam, plaats, postcode)
        {
            this.geschiedenis = geschiedenis;
            this.omschrijving = omschrijving;
            this.ontstaan = ontstaan;
            this.oppervlakte = oppervlakte;
        }

        // PROPERTIES
        public string Geschiedenis
        {
            get { return geschiedenis; }
        }

        public string Omschrijving
        {
            get { return omschrijving; }
        }

        public string Ontstaan
        {
            get { return ontstaan; }
        }

        public double Oppervlakte
        {
            get { return oppervlakte; }
        }


        // TOSTRING
        public override string ToString()
        {
            return base.ToString() + " Geschiedenis: " + Geschiedenis + " Omschrijving: " + Omschrijving + " Ontstaan: " + Ontstaan + " Oppervlakte: " + Oppervlakte;
        }
    }
}
