using DatabaseKoppeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen.Properties;

namespace Klassen
{
    public class Beheer
    {
        // DATA
        private List<Reis> reisLijst;
        private List<Land> landenLijst;
        DataKoppeling k = new DataKoppeling();

        // CONSTRUCTOR
        public Beheer()
        {
            reisLijst = new List<Reis>();
        }

        // PROPERTIES
        public List<Reis> ReisLijst
        {
            get { return new List<Reis>(this.reisLijst); }
        }

        public List<Land> LandenLijst
        {
            get { return new List<Land>(this.landenLijst); }
        }


        // METHODEN
        
        public void Aanmelden(string naam, string ww)
        {
            try
            {
                k.Aanmelden(naam, ww);
            }
            catch
            {
                throw new Exception("Gegevens al komen");
            }
        }

        #region INLOGGEN
        public bool Inloggen(string naam, string ww)
        {
            Gebruiker g = k.Login(naam, ww);
            return g != null;
        }
        #endregion


        public List<Land> EuropeseReizen()
        {
            List<Land> land = k.EuropeseReizenLijst();
            return land;
        }

        //public void ReisAanpassen()
        //{
        //    // TODO
        //}

        //public void ReisBekijken()
        //{
        //    // TODO
        //}

        //public void ReisDelen()
        //{
        //    // TODO
        //}

        //public void ReisOpzoeken()
        //{
        //    // TODO
        //}

        //public void ReisToevoegen()
        //{
        //    // TODO
        //}

        //public void ReisVerwijderen()
        //{
        //    // TODO
        //}

        //public void Sorteren()
        //{
        //    // TODO
        //}

        //public void Uitloggen()
        //{
        //    // TODO
        //}

        //public void ToString()
        //{
        //    // TODO
        //}
    }
}
