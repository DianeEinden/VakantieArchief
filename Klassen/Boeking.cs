using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Boeking
    {
        #region ENUM
        public enum VakSoort
        {
            ActieveVakantie,
            Alleengaandenreis,
            AutoVakantie,
            Busreis,
            Cruise,
            FlyDrive,
            Rondreis,
            SingleReis,
            Stedentrip,
            ZonVakantie
        }
        #endregion

        // DATA
        private string boekingsNummer;
        private DateTime datumRetour;
        private DateTime datumVertrek;
        private string organisatie;
        private string paspoortID;
        private VakSoort soortVakantie;
        private double totaalPrijs;
        private bool visum;
        private string voertuig;
        private List<Accomodatie> accomodatieLijst;
        private List<Reis> reisLijst;

        // CONSTRUCTOR
        public Boeking(string boekingsNummer, DateTime datumRetour, DateTime datumVertrek, string organisatie, string paspoortID, VakSoort soortVakantie, double totaalPrijs, bool visum, string voertuig)
        {
            this.boekingsNummer = boekingsNummer;
            this.datumRetour = datumRetour;
            this.datumVertrek = datumVertrek;
            this.organisatie = organisatie;
            this.paspoortID = paspoortID;
            this.soortVakantie = soortVakantie;
            this.totaalPrijs = totaalPrijs;
            this.visum = visum;
            this.voertuig = voertuig;
            accomodatieLijst = new List<Accomodatie>();
            reisLijst = new List<Reis>();
        }

        // PROPERTIES
        public string BoekingsNummer
        {
            get { return boekingsNummer; }
        }

        public DateTime DatumRetour
        {
            get { return datumRetour; }
        }

        public DateTime DatumVertrek
        {
            get { return datumVertrek; }
        }

        public string Organisatie
        {
            get { return organisatie; }
        }

        public string PaspoortID
        {
            get { return paspoortID; }
        }

        public VakSoort SoortVakantie
        {
            get { return soortVakantie; }
        }

        public double TotaalPrijs
        {
            get { return totaalPrijs; }
        }

        public bool Visum
        {
            get { return visum; }
        }

        public string Voertuig
        {
            get { return voertuig; }
        }

        public List<Accomodatie> AccomodatieLijst
        {
            get { return new List<Accomodatie>(accomodatieLijst); }
        }

        public List<Reis> ReisLijst
        {
            get { return new List<Reis>(reisLijst); }
        }

        // ALLE LANDEN
        public static List<Land> AlleLanden()
        {
            List<Land> ret = new List<Land>();
            // Database: select * from land
            // en roep elke keer constructoer van Land aan.
            return ret;
        }

        // TOSTRING
        public override string ToString()
        {
            return " Boekingsnummer: " + BoekingsNummer + " Datum retour: " + DatumRetour + " Datum vertrek: " + DatumVertrek + " Organisatie: " + Organisatie + " Paspoort of ID: " + PaspoortID + " Soort vakantie: " + SoortVakantie + " Totaalprijs: " + TotaalPrijs + " Visum nodig: " + Visum + " Voertuig: " + Voertuig;
        }
    }
}
