using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Activiteit
    {
        // DATA
        private string adres;
        private char arragement;
        private string naam;
        private string omschrijving;
        private string organisatie;
        private string plaats;
        private string postcode;
        private double prijs;
        private string telefoonnummer;
        private string type;

        // CONSTRUCTOR
        public Activiteit(string adres, char arragement, string naam, string omschrijving, string organisatie, string plaats, string postcode, double prijs, string telefoonnummer, string type)
        {
            this.adres = adres;
            this.arragement = arragement;
            this.naam = naam;
            this.omschrijving = omschrijving;
            this.organisatie = organisatie;
            this.plaats = plaats;
            this.postcode = postcode;
            this.prijs = prijs;
            this.telefoonnummer = telefoonnummer;
            this.type = type;
        }

        // PROPERTIES
        public string Adres
        {
            get { return adres; }
        }

        public char Arragement
        {
            get { return arragement; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public string Omschrijving
        {
            get { return omschrijving; }
        }

        public string Organisatie
        {
            get { return organisatie; }
        }

        public string Plaats
        {
            get { return plaats; }
        }

        public string Postcode
        {
            get { return postcode; }
        }

        public double Prijs
        {
            get { return prijs; }
        }

        public string Telefoonnnummer
        {
            get { return telefoonnummer; }
        }

        public string Type
        {
            get { return type; }
        }

        public override string ToString()
        {
            return " Adres: " + Adres + " Arragement mogelijk: " + Arragement + " Naam: " + Naam + " Omschrijving: " + Omschrijving + " Organisatie: " + Organisatie + " Plaats: " + Plaats + " Postcode: " + Postcode + " Prijs: " + Prijs + " Telefoonnummer: " + Telefoonnnummer + " Type: " + type;
        }
            
    }
}
