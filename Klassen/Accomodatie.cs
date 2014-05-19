using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Accomodatie
    {
        #region ENUM
        public enum AcSoort
        {
            Aparthotel,
            Appartement,
            BedAndBreakfast,
            Boot,
            Bungalow,
            Camping,
            CruiseSchip,
            Hostel,
            Hotel,
            JungleHut,
            NachtTrein,
            VakantieWoning
        }

        public enum AcType
        {
            EenSter,
            TweeSterren,
            DrieSterren,
            VierSterren,
            VijfSterren
        }

        public enum Verzorging
        {
            AllInclusief,
            HalfPension,
            Logies,
            LogiesOntbijt,
            VolPension
        }
        #endregion

        private string adres;
        private string categorie;
        private string naam;
        private string postcode;
        private AcSoort soort;
        private string telefoonnummer;
        private AcType type;
        private Verzorging verzorging;
        private string website;

        // CONSTRUCTOR
        public Accomodatie(string adres, string categorie, string naam, string postcode, AcSoort soort, string telefoonnummer, AcType type, Verzorging verzorging, string website)
        {
            this.adres = adres;
            this.categorie = categorie;
            this.naam = naam;
            this.postcode = postcode;
            this.soort = soort;
            this.telefoonnummer = telefoonnummer;
            this.type = type;
            this.verzorging = verzorging;
            this.website = website;
        }

        // PROPERTIES
        public string Adres
        {
            get { return adres; }
        }

        public string Categorie
        {
            get { return categorie; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public string Postcode
        {
            get { return postcode; }
        }

        public AcSoort Soort
        {
            get { return soort; }
        }

        public string Telefoonnummer
        {
            get { return telefoonnummer; }
        }

        public AcType Type
        {
            get { return type; }
        }

        public Verzorging Verzorgings
        {
            get { return verzorging; }
        }

        public string Website
        {
            get { return website; }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Adres: " + Adres + " Categorie: " + Categorie + " Naam: " + Naam + " Postcode: " + Postcode + " Soort: " + Soort + " Telefoonnummer: " + Telefoonnummer + " Type: " + Type + " Verzorging: " + Verzorgings + " Website: " + Website;
        }
    }
}
