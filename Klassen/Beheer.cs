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
        private List<Boeking> boekingLijst;
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


       // METHODEN

       #region AANMELDEN
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
       #endregion

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

        #region ACTIVITEITEN
        public List<Activiteit> activiteitenOverzicht(int areacode)
        {
            List<Activiteit> activiteit = (List<Activiteit>)k.activiteitenLijst(areacode);
            return activiteit;
        }
        #endregion

        // NOG CONTROLEREN ALS DATABASE IS GEVULD
        #region KUNSTMATIGE-BEZIENSWAARDIGHEID
        public List<KunstmatigeBZW> KMbezienswaardigheden(int areacode)
        {
            List<KunstmatigeBZW> KMbezienswaardigheden = (List<KunstmatigeBZW>)k.kunstmatigeBzwLijst(areacode);
            return KMbezienswaardigheden;
        }
        #endregion

        // NOG CONTROLEREN ALS DATABASE IS GEVULD
        #region NATUURLIJKE-BEZIENSWAARDIGHEID
        public List<NatuurlijkeBZW> NMbezienswaardigheden(int areacode)
        {
            List<NatuurlijkeBZW> NMbezienswaardigheden = (List<NatuurlijkeBZW>)k.natuurlijkeBzwLijst(areacode);
            return NMbezienswaardigheden;
        }
        #endregion

        // PROBLEMEN MET WEGSCHRIJVEN VAN ENUMWAARDE
        #region LAND TOEVOEGEN
        public void LandToevoegen(double aantalInwoners, string cultuur, string hoofdstad, string landcode, int landnummer, string ligging, string naam, double oppervlakte, Land.Staatsvorm staatsvorm, char tijdsverschil, string valuta, string voertaal)
        {
            try
            {
                k.LandToevoegen(aantalInwoners, cultuur, hoofdstad, landcode, landnummer, ligging, naam, oppervlakte, staatsvorm, tijdsverschil, valuta, voertaal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        // PROBLEMEN MET WEGSCHRIJVEN VAN ENUMWAARDE
        #region BOEKING TOEVOEGEN
        public void boekingToevoegen(string boekinsNummer, DateTime datumRetour, DateTime datumVertrek, string organisatie, string paspoortID, Boeking.VakSoort soortVakantie, double totaalPrijs, char visum, string voertuig, string landcode)
        {
            try
            {
                k.boekingToevoegen(boekinsNummer, datumRetour, datumVertrek, organisatie, paspoortID, soortVakantie, totaalPrijs, visum, voertuig, landcode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region REIS TOEVOEGEN
        public void reisToevoegen(string reistijd, string vertrekpunt, string aankomstpunt, string vertrektijd, string reiscode)
        {
            try
            {
                k.reisToevoegen(reistijd, vertrekpunt, aankomstpunt, vertrektijd, reiscode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        // PROBLEMEN MET WEGSCHRIJVEN VAN ENUMWAARDE
        #region ACCOMODATIE TOEVOEGEN
        public void accomodatieToevoegen(string adres, string categorie, string naam, string postcode, string plaats, Accomodatie.AcSoort soort, string telefoonnummer, Accomodatie.Verzorging verzorging, string website)
        {
            try
            {
                k.accomodatieToevoegen(adres, categorie, naam, postcode, plaats, soort, telefoonnummer, verzorging, website);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region PLAATS TOEVOEGEN
        public void plaatsToevoegen(double aantalInwoners, int areacode, string plaatsnaam, string stadOfDorp, string Landcode)
        {
            try
            {
                k.plaatsToevoegen(aantalInwoners, areacode, plaatsnaam, stadOfDorp, Landcode);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
      
    }
}
