﻿using DatabaseKoppeling;
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
        private List<Boeking> boekingLijst;
        private List<Land> landenLijst;
        DataKoppeling k = new DataKoppeling();

        // CONSTRUCTOR
        public Beheer()
        {
            reisLijst = new List<Reis>();
            boekingLijst = new List<Boeking>();
        }

        // PROPERTIES
        public List<Reis> ReisLijst
        {
            get { return new List<Reis>(this.reisLijst); }
        }
       public List<Boeking> BoekingLijst
        {
            get { return new List<Boeking>(this.BoekingLijst); }
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
                throw new Exception("Gegevens komen al voor");
            }
        }

        #region INLOGGEN
        public bool Inloggen(string naam, string ww)
        {
            Gebruiker g = k.Login(naam, ww);
            return g != null;
        }
        #endregion

        #region LANDEN

        // Europesereizen
        public List<Land> EuropeseReizen()
        {
            List<Land> land = k.EuropeseReizenLijst();
            return land;
        }

        // Afrikaansreizen
        public List<Land> AfraanseReizen()
        {
            List<Land> land = k.AfrikaanseReizenLijst();
            return land;
        }

        // Afrikaansreizen
        public List<Land> AzieReizen()
        {
            List<Land> land = k.AzieReizenLijst();
            return land;
        }
        #endregion

        #region REIS OPVRAGEN
        public List<Reis> reisOpvragen(int Boekingsnummer)
        {
            List<Reis> reis = (List<Reis>)k.ReisOpvragen(Boekingsnummer);
            return reis;
        }      
        #endregion

        #region BOEKING OPVRAGEN
        public List<Boeking> boekingOpvragen(string Landcode)
        {
            List<Boeking> boeking = (List<Boeking>)k.BoekingOpvragen(Landcode);
            return boeking;
        }
        #endregion

        #region ACCOMODATIE BEKIJKEN
        public List<Accomodatie> accomodatieBekijken(int Boekingsnummer)
        {
            List<Accomodatie> accomodatie = (List<Accomodatie>)k.AccomodatieBekijken(Boekingsnummer);
            return accomodatie;
        }
        #endregion

        #region PLAATSEN INZIEN
        public List<Plaats> plaatsenBekijken(string Landcode)
        {
            List<Plaats> plaats = (List<Plaats>)k.PlaatsenOpvragen(Landcode);
            return plaats;
        }
        #endregion

      
    }
}
