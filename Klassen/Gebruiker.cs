using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Gebruiker
    {
        // DATA
        private string naam;
        private string wachtwoord;

        // CONSTRUCTOR
        public Gebruiker (string naam, string wachtwoord)
        {
            this.naam = naam;
            this.wachtwoord = wachtwoord;
        }

        // PROPERTIES
        public string Naam
        {
            get { return naam; }
        }

        public string Wachtwoord
        {
            get { return wachtwoord; }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Naam: " + Naam + " Wachtwoord: " + Wachtwoord;
        }
    }
}
