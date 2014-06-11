using DatabaseKoppeling;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Land
    {
        #region ENUM
        public enum Staatsvorm
        {
            Democratie,
            Dictatuur,
            Koningkrijk,
            Republiek
        }
        #endregion

        // DATA
        private double aantalInwoners;
        private string cultuur;
        private string hoofdstad;
        private string landcode;
        private int landnummer;
        private string ligging;
        private string naam;
        private double oppervlakte;
        private Staatsvorm staatsvorm;
        private bool tijdsverschil;
        private string valuta;
        private string voertaal;
        private List<Boeking> boekingLijst;
        private List<Plaats> plaatsLijst;

        // CONSTRUCTOR
        public Land(double aantalInwoners, string cultuur, string hoofdstad, string landcode, int landnummer, string ligging, string naam, double oppervlakte, Staatsvorm staatsvorm, bool tijdsverschil, string valuta, string voertaal)
        {
            this.aantalInwoners = aantalInwoners;
            this.cultuur = cultuur;
            this.hoofdstad = hoofdstad;
            this.landcode = landcode;
            this.landnummer = landnummer;
            this.ligging = ligging;
            this.naam = naam;
            this.oppervlakte = oppervlakte;
            this.staatsvorm = staatsvorm;
            this.tijdsverschil = tijdsverschil;
            this.valuta = valuta;
            this.voertaal = voertaal;
            boekingLijst = new List<Boeking>();
            plaatsLijst = new List<Plaats>();
        }

        //public Land(string landCode)
        //{
        //    using (OracleConnection conn = new OracleConnection(new DataKoppeling().connectie))
        //    {
        //        OracleCommand cmd = new OracleCommand("select * from land where landCode=:landCode", conn);
        //        cmd.Parameters.Add("landCode", landCode);

        //        OracleDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            this.cultuur = rdr["cultuur"].ToString();
        //            this.aantalInwoners = Convert.ToInt32(rdr["aantalinwoners"]);
        //        }
        //    }
        //    //BoekingLijst = Boeking.LeesBoekingenVanLand(landCode);
        //    // TODO Zelfde als LeesAlleLanden in de datakoppeling
        //}
            
        // PROPERTIES
        public double AantalInwoners
        {
            get { return aantalInwoners; }
        }

        public string Cultuur
        {
            get { return cultuur; }
        }

        public string Hoofdstad
        {
            get { return hoofdstad; }
        }

        public string Landcode
        {
            get { return landcode; }
        }

        public int Landnummer
        {
            get { return landnummer; }
        }

        public string Ligging
        {
            get { return ligging; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public double Oppervlakte
        {
            get { return oppervlakte; }
        }

        public Staatsvorm Staadsvorm
        {
            get { return staatsvorm; }
        }

        public bool Tijdsverschil
        {
            get { return tijdsverschil; }
        }

        public string Valuta
        {
            get { return valuta; }
        }

        public string Voertaal
        {
            get { return voertaal; }
        }

        public List<Boeking> BoekingLijst
        {
            get { return new List<Boeking>(boekingLijst);}
        }

        public List<Plaats> PlaatsLijst
        {
            get { return new List<Plaats>(plaatsLijst); }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Aantal inwoners: " + AantalInwoners + " Cultuur: " + Cultuur + " Hoofdstad: " + hoofdstad + " Landcode: " + Landcode + " Landnummer: " + Landnummer + " Ligging: " + Ligging + " Naam: " + Naam + " Oppervlakte: " + Oppervlakte + " Staadsvorm: " + Staadsvorm + " Tijdsverschil: " + Tijdsverschil + " Valuta: " + Valuta + " Voertaal: " + Voertaal;
        }
    }
}
