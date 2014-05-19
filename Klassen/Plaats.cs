using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Plaats
    {
        // DATA
        private double aantalInwoners;
        private int areacode;
        private string plaatsnaam;
        private string stadOfDorp;
        private List<Bezienswaardigheid> bezienswaardigheidLijst;
        private List<Activiteit> activiteitLijst;

        // CONSTRUCTOR
        public Plaats(double aantalInwoners, int areacode, string plaatsnaam, string stadOfDorp)
        {
            this.aantalInwoners = aantalInwoners;
            this.areacode = areacode;
            this.plaatsnaam = plaatsnaam;
            this.stadOfDorp = stadOfDorp;
            bezienswaardigheidLijst = new List<Bezienswaardigheid>();
            activiteitLijst = new List<Activiteit>();
        }

        // PROPERTIES
        public double AantalInwoners
        {
            get { return aantalInwoners; }
        }

        public int Areacode
        {
            get { return areacode; }
        }

        public string Plaatsnaam
        {
            get { return plaatsnaam; }
        }

        public string StadOfDorp
        {
            get { return stadOfDorp; }
        }

        public List<Bezienswaardigheid> BezienswaardigheidLijst
        {
            get { return new List<Bezienswaardigheid>(bezienswaardigheidLijst); }
        }

        public List<Activiteit> ActiviteitLijst
        {
            get { return new List<Activiteit>(activiteitLijst); }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Aantal inwoners: " + AantalInwoners + " Areacode: " + Areacode + " Plaatsnaam: " + Plaatsnaam + " Stad of Dorp: " + StadOfDorp;
        }
    }
}
