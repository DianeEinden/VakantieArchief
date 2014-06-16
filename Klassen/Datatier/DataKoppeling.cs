using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Configuration;
using Klassen;
using Klassen.Properties;

namespace DatabaseKoppeling
{
    public class DataKoppeling
    {
        private static OracleConnection connection;

        //public string  constring;

        /// <summary>
        /// Koppeling voor het maken van een connectie met de database
        /// </summary>
        public DataKoppeling()
        {
            connection = new OracleConnection("User Id=" + "SE22_VAKANTIEARCHIEF" + " ;Password=" + "handyroosje" + ";Data Source=" + " //localhost:1521/xe" + ";");
        }

        #region LOGIN
        /// <summary>
        /// Inloggen
        /// </summary>
        /// <param name="username">De gebruikersnaam waarmee de persoon inlogt</param>
        /// <param name="wachtwoord">Het wachtwoord wat bij de gebruikersnaam hoord.</param>
        /// <returns></returns>
        public Gebruiker Login(string username, string wachtwoord)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from gebruiker where gebruikersnaam=:naam and wachtwoord=:wachtwoord", conn);
                    cmd.Parameters.Add("naam", username);
                    cmd.Parameters.Add("wachtwoord", wachtwoord);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Gebruiker g = new Gebruiker(rdr["GEBRUIKERSNAAM"].ToString(), rdr["WACHTWOORD"].ToString());
                        return g;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion

        #region AANMELDEN
        /// <summary>
        /// Aanmelden van een nieuwe gebruiker
        /// </summary>
        /// <param name="naam">De gebruikersnaam om mee in te loggen</param>
        /// <param name="wachtwoord">Het gewenst wachtwoord</param>
        public void Aanmelden(string naam, string wachtwoord)
        {
            using (OracleConnection conn = connection)
            {               
                OracleCommand cmd = new OracleCommand("INSERT INTO GEBRUIKER VALUES (:naam, :wachtwoord)", conn);
                cmd.Parameters.Add("GEBRUIKERSNAAM", naam);
                cmd.Parameters.Add("WACHTWOORD", wachtwoord);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region EUROPESE LANDEN
        /// <summary>
        /// Europese landen
        /// </summary>
        /// <returns>Een lijst van alle Europese landen in de database</returns>
        public List<Land> EuropeseReizenLijst()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from land where ligging = 'Europa'", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Land> europeseLanden = new List<Land>();
                    while (rdr.Read())
                    {
                        double aantalInwoners = Convert.ToDouble(rdr["aantalInwoners"]);
                        string cultuur = Convert.ToString(rdr["cultuur"]);
                        string hoofdstad = Convert.ToString(rdr["hoofdstad"]);
                        string landcode = Convert.ToString(rdr["landcode"]);
                        int landnummer = Convert.ToInt32(rdr["landnummer"]);
                        string ligging = Convert.ToString(rdr["ligging"]);
                        string naam = Convert.ToString(rdr["naam"]);
                        double oppervlakte = Convert.ToDouble(rdr["oppervlakte"]);
                        Land.Staatsvorm staadsvorm = (Land.Staatsvorm)Enum.Parse(typeof(Land.Staatsvorm), Convert.ToString(rdr["staatsvorm"]));
                        char tijdsverschil = Convert.ToChar(rdr["tijdsverschil"]);
                        string valuta = Convert.ToString(rdr["valuta"]);
                        string voertaal = Convert.ToString(rdr["voertaal"]);
                        europeseLanden.Add(new Land(aantalInwoners, cultuur, hoofdstad, landcode, landnummer, ligging, naam, oppervlakte, staadsvorm, tijdsverschil, valuta, voertaal));
                    }
                    return europeseLanden;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AFRIKAANSE LANDEN
        /// <summary>
        /// Afrikaanse landen
        /// </summary>
        /// <returns>Een lijst van alle Afrikaanse landen in de database</returns>
        public List<Land> AfrikaanseReizenLijst()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from land where ligging = 'Afrika'", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Land> afrikaanseReizenLijst = new List<Land>();
                    while (rdr.Read())
                    {
                        double aantalInwoners = Convert.ToDouble(rdr["aantalInwoners"]);
                        string cultuur = Convert.ToString(rdr["cultuur"]);
                        string hoofdstad = Convert.ToString(rdr["hoofdstad"]);
                        string landcode = Convert.ToString(rdr["landcode"]);
                        int landnummer = Convert.ToInt32(rdr["landnummer"]);
                        string ligging = Convert.ToString(rdr["ligging"]);
                        string naam = Convert.ToString(rdr["naam"]);
                        double oppervlakte = Convert.ToDouble(rdr["oppervlakte"]);
                        Land.Staatsvorm staadsvorm = (Land.Staatsvorm)Enum.Parse(typeof(Land.Staatsvorm), Convert.ToString(rdr["staatsvorm"]));
                        char tijdsverschil = Convert.ToChar(rdr["tijdsverschil"]);
                        string valuta = Convert.ToString(rdr["valuta"]);
                        string voertaal = Convert.ToString(rdr["voertaal"]);
                        afrikaanseReizenLijst.Add(new Land(aantalInwoners, cultuur, hoofdstad, landcode, landnummer, ligging, naam, oppervlakte, staadsvorm, tijdsverschil, valuta, voertaal));
                    }
                    return afrikaanseReizenLijst;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region AZIE LANDEN
        /// <summary>
        /// Azieatische landen
        /// </summary>
        /// <returns>Een overzicht van alle Aziatische landen</returns>
        public List<Land> AzieReizenLijst()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from land where ligging = 'Azie'", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Land> azieReizenLijst = new List<Land>();
                    while (rdr.Read())
                    {
                        double aantalInwoners = Convert.ToDouble(rdr["aantalInwoners"]);
                        string cultuur = Convert.ToString(rdr["cultuur"]);
                        string hoofdstad = Convert.ToString(rdr["hoofdstad"]);
                        string landcode = Convert.ToString(rdr["landcode"]);
                        int landnummer = Convert.ToInt32(rdr["landnummer"]);
                        string ligging = Convert.ToString(rdr["ligging"]);
                        string naam = Convert.ToString(rdr["naam"]);
                        double oppervlakte = Convert.ToDouble(rdr["oppervlakte"]);
                        Land.Staatsvorm staadsvorm = (Land.Staatsvorm)Enum.Parse(typeof(Land.Staatsvorm), Convert.ToString(rdr["staatsvorm"]));
                        char tijdsverschil = Convert.ToChar(rdr["tijdsverschil"]);
                        string valuta = Convert.ToString(rdr["valuta"]);
                        string voertaal = Convert.ToString(rdr["voertaal"]);
                        azieReizenLijst.Add(new Land(aantalInwoners, cultuur, hoofdstad, landcode, landnummer, ligging, naam, oppervlakte, staadsvorm, tijdsverschil, valuta, voertaal));
                    }
                    return azieReizenLijst;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region BOEKING OPVRAGEN
        /// <summary>
        /// Boeking opvragen
        /// </summary>
        /// <param name="landcode">De landcode van een land</param>
        /// <returns>Een lijst van boekingen die worden weergegeven op basis van een opgegeven landcode</returns>
        public List<Boeking> BoekingOpvragen(string landcode)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM BOEKING, LAND WHERE boeking.land_landcode = land.landcode AND land.landcode=:landcode", conn);
                    cmd.Parameters.Add("landcode", landcode);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Boeking> boekingOpvragen = new List<Boeking>();
                    while (rdr.Read())
                    {
                        string boekingsNummer = Convert.ToString(rdr["BOEKINGSNUMMER"]);
                        DateTime datumRetour = Convert.ToDateTime(rdr["DATUMRETOUR"]);
                        DateTime datumVertrek = Convert.ToDateTime(rdr["DATUMVERTREK"]);
                        string organisatie = Convert.ToString(rdr["ORGANISATIE"]);
                        string paspoortID = Convert.ToString(rdr["IDKAARTOFPASPOORT"]);
                        Boeking.VakSoort soortVakantie = (Boeking.VakSoort)Enum.Parse(typeof(Boeking.VakSoort), Convert.ToString(rdr["SOORTVAKANTIE"]));
                        double totaalPrijs = Convert.ToDouble(rdr["TOTAALPRIJS"]);
                        char visum = Convert.ToChar(rdr["VISUM"]);
                        string voertuig = Convert.ToString(rdr["VOERTUIG"]);
                        boekingOpvragen.Add(new Boeking(boekingsNummer, datumRetour, datumVertrek, organisatie, paspoortID, soortVakantie, totaalPrijs, visum, voertuig));                        
                    }
                    return boekingOpvragen;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }

        }
        #endregion

        #region REIS OPVRAGEN
        /// <summary>
        /// Reis opvragen
        /// </summary>
        /// <param name="boekingsNummer">Een boekingsnummer</param>
        /// <returns>Geeft overzicht van reizen met betrekkning tot een bepaald boekingsnummer</returns>
        public List<Reis> ReisOpvragen(int boekingsNummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM REIS, BOEKING WHERE boeking.boekingsnummer = boeking.boekingsnummer AND boeking.boekingsnummer=:boekingsNummer", conn);
                    cmd.Parameters.Add("boekingsNummer", boekingsNummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Reis> reisOpvragen = new List<Reis>();
                    while (rdr.Read())
                    {                       
                        string reistijd = Convert.ToString(rdr["REISTIJD"]);
                        string vertrekpunt = Convert.ToString(rdr["VERTREKPUNT"]);
                        string aankomstpunt = Convert.ToString(rdr["AANKOMSTPUNT"]);
                        string vertrektijd = Convert.ToString(rdr["VERTREKTIJD"]);
                        string reiscode = Convert.ToString(rdr["REISCODE"]);
                        reisOpvragen.Add(new Reis(reistijd, vertrekpunt, aankomstpunt, vertrektijd, reiscode));                    
                    }
                    return reisOpvragen;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }

        }
        #endregion

        #region ACCOMODATIE BEKIJKEN
        /// <summary>
        /// Accomodaties
        /// </summary>
        /// <param name="boekingsNummer">Boekingsnummer</param>
        /// <returns>Een overzicht van accomodaties van een bepaald boekingsnummer</returns>
        public List<Accomodatie> AccomodatieBekijken(int boekingsNummer)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM ACCOMODATIE, BOEKING WHERE boeking.boekingsnummer = accomodatie.boeking_boekingsnummer AND boeking.boekingsnummer=:boekingsNummer", conn);
                    cmd.Parameters.Add("boekingsNummer", boekingsNummer);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Accomodatie> accomodatieBekijken = new List<Accomodatie>();
                    while (rdr.Read())
                    {                      
                        string adres = Convert.ToString(rdr["ADRES"]);
                        string categorie = Convert.ToString(rdr["CATEGORIE"]);
                        string naam = Convert.ToString(rdr["NAAM"]);
                        string postcode = Convert.ToString(rdr["POSTCODE"]);
                        string plaats = Convert.ToString(rdr["PLAATS"]);
                        Accomodatie.AcSoort soort = (Accomodatie.AcSoort)Enum.Parse(typeof(Accomodatie.AcSoort), Convert.ToString(rdr["SOORT"]));
                        string telefoonnummer = Convert.ToString(rdr["TELEFOONNUMMER"]);
                        Accomodatie.Verzorging verzorging = (Accomodatie.Verzorging)Enum.Parse(typeof(Accomodatie.Verzorging), Convert.ToString(rdr["VERZORGING"]));
                        string website = Convert.ToString(rdr["WEBSITE"]);
                        accomodatieBekijken.Add(new Accomodatie(adres, categorie, naam, postcode, plaats, soort, telefoonnummer, verzorging, website));                      
                    }
                    return accomodatieBekijken;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region PLAATSEN OPVRAGEN
        /// <summary>
        /// Plaatsen
        /// </summary>
        /// <param name="landcode">Code van een land</param>
        /// <returns>Een lijst van plaatsen van een bepaald land.</returns>
        public List<Plaats> PlaatsenOpvragen(string landcode)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM PLAATS, LAND WHERE plaats.land_landcode = land.landcode AND land.landcode=:landcode", conn);
                    cmd.Parameters.Add("landcode", landcode);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Plaats> plaatsenLijst = new List<Plaats>();
                    while (rdr.Read())
                    {
                        double aantalInwoners = Convert.ToDouble(rdr["AANTALINWONERS"]);
                        int areacode = Convert.ToInt32(rdr["AREACODE"]);
                        string plaatsnaam = Convert.ToString(rdr["PLAATSNAAM"]);
                        string stadOfDorp = Convert.ToString(rdr["STADOFDORP"]);
                        plaatsenLijst.Add(new Plaats(aantalInwoners, areacode, plaatsnaam, stadOfDorp));                        
                    }
                    return plaatsenLijst;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region ACTIVITEITEN
        /// <summary>
        /// Activiteiten
        /// </summary>
        /// <param name="areacode">Code van een plaats</param>
        /// <returns>Een lijst van activiteiten op een bepaalde plaats</returns>
        public List<Activiteit> activiteitenLijst(int areacode)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM ACTIVITEIT, PLAATS WHERE plaats.areacode = activiteit.Plaats_areacode AND plaats.areacode=:areacode", conn);
                    cmd.Parameters.Add("areacode", areacode);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Activiteit> activiteitenLijst = new List<Activiteit>();
                    while (rdr.Read())
                    {
                        string adres = Convert.ToString(rdr["ADRES"]);
                        char arragement = Convert.ToChar(rdr["ARRAGEMENTMOGELIJK"]);
                        string naam = Convert.ToString(rdr["NAAM"]);
                        string omschrijving = Convert.ToString(rdr["OMSCHRIJVING"]);
                        string organisatie = Convert.ToString(rdr["ORGANISATIE"]);
                        string plaats = Convert.ToString(rdr["PLAATS"]);
                        string postcode = Convert.ToString(rdr["POSTCODE"]);
                        double prijs = Convert.ToDouble(rdr["PRIJS"]);
                        string telefoonnummer = Convert.ToString(rdr["TELEFOONNUMMER"]);
                        string type = Convert.ToString(rdr["SOORT"]);
                        activiteitenLijst.Add(new Activiteit(adres, arragement, naam, omschrijving, organisatie, plaats, postcode, prijs, telefoonnummer, type));
                    }
                    return activiteitenLijst;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region KUNSTMATIGE-BEZIENSWAARDIGHEID
        /// <summary>
        /// Kunstmatige bezienswaardigheden
        /// </summary>
        /// <param name="areacode">Code van een plaats</param>
        /// <returns>Een lijst van bezienswaardigheden in een bepaalde plaats</returns>
        public List<KunstmatigeBZW> kunstmatigeBzwLijst(int areacode)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM kunstmatigebzw, bezienswaardigheid, PLAATS WHERE bezienswaardigheid.bzwcode = kunstmatigebzw.bezienswaardigheid_bzwcode AND plaats.areacode = bezienswaardigheid.Plaats_areacode AND plaats.areacode=:areacode", conn);
                    cmd.Parameters.Add("areacode", areacode);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<KunstmatigeBZW> KMbezienswaardigheden = new List<KunstmatigeBZW>();
                    while (rdr.Read())
                    {
                        char afspraakNodig = Convert.ToChar(rdr["AFSPRAAKNODIG"]);
                        int bouwjaar = Convert.ToInt32(rdr["BOUWJAAR"]);
                        string functie = Convert.ToString(rdr["FUNCTIE"]);
                        string omschrijving = Convert.ToString(rdr["OMSCHRIJVING"]);
                        string oprichter = Convert.ToString(rdr["OPRICHTER"]);
                        char rondleiding = Convert.ToChar(rdr["RONDLEIDINGMOGELIJK"]);
                        string telefoonnummer = Convert.ToString(rdr["TELEFOONNUMMER"]);
                        string type = Convert.ToString(rdr["THEMA"]);
                        string adres = Convert.ToString(rdr["ADRES"]);
                        string naam = Convert.ToString(rdr["NAAM"]);
                        double entreeprijs = Convert.ToDouble(rdr["ENTREEPRIJS"]);
                        string plaats = Convert.ToString(rdr["PLAATS"]);
                        string postcode = Convert.ToString(rdr["POSTCODE"]);
                        KMbezienswaardigheden.Add(new KunstmatigeBZW(afspraakNodig, bouwjaar, functie, omschrijving, oprichter, rondleiding, telefoonnummer, type, adres, naam, entreeprijs, plaats, postcode));                      
                    }
                    return KMbezienswaardigheden;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region NATUURLIJKE-BEZIENSWAARDIGHEID
        /// <summary>
        /// Natuurlijke bezienswaardigheden
        /// </summary>
        /// <param name="areacode">Code van een plaats</param>
        /// <returns>Een lijst van natuurlijke bezienswaardigheden van een bepaalde plaats</returns>
        public List<NatuurlijkeBZW> natuurlijkeBzwLijst(int areacode)
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("SELECT * FROM natuurlijkebzw, bezienswaardigheid, PLAATS WHERE bezienswaardigheid.bzwcode = natuurlijkebzw.bezienswaardigheid_bzwcode AND plaats.areacode = bezienswaardigheid.Plaats_areacode AND plaats.areacode=:areacode", conn);
                    cmd.Parameters.Add("areacode", areacode);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<NatuurlijkeBZW> NMbezienswaardigheden = new List<NatuurlijkeBZW>();
                    while (rdr.Read())
                    {                       
                        string geschiedenis = Convert.ToString(rdr["GESCHIEDENIS"]);
                        string omschrijving = Convert.ToString(rdr["OMSCHRIJVING"]);
                        string ontstaan = Convert.ToString(rdr["ONTSTAAN"]);
                        double oppervlakte = Convert.ToDouble(rdr["OPPERVLAKTE"]);
                        string adres = Convert.ToString(rdr["ADRES"]);
                        double entreeprijs = Convert.ToDouble(rdr["ENTREEPRIJS"]);
                        string naam = Convert.ToString(rdr["NAAM"]);
                        string plaats = Convert.ToString(rdr["PLAATS"]);
                        string postcode = Convert.ToString(rdr["POSTCODE"]);
                        NMbezienswaardigheden.Add(new NatuurlijkeBZW(geschiedenis, omschrijving, ontstaan, oppervlakte, adres, entreeprijs, naam, plaats, postcode));                       
                    }
                    return NMbezienswaardigheden;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion

        #region LAND TOEVOEGEN
        /// <summary>
        /// Toevoegen van een land
        /// </summary>
        /// <param name="aantalInwoners">Het aantal inwoners</param>
        /// <param name="cultuur">Cultuur/Geloof</param>
        /// <param name="hoofdstad">De hoofdstad van het land</param>
        /// <param name="landcode">Twee letterige landcode</param>
        /// <param name="landnummer">Twee cijferig nummer</param>
        /// <param name="ligging">Welk continent het land ligt</param>
        /// <param name="naam">De naam van het land</param>
        /// <param name="oppervlakte">De oppervlakte van het land</param>
        /// <param name="staatsvorm">Staadsvorm</param>
        /// <param name="tijdsverschil">Is er tijdsverschil?</param>
        /// <param name="valuta">Wettelijk betaalmiddel</param>
        /// <param name="voertaal">De taal die men spreekt</param>
        public void LandToevoegen(double aantalInwoners, string cultuur, string hoofdstad, string landcode, int landnummer, string ligging, string naam, double oppervlakte, Land.Staatsvorm staatsvorm, char tijdsverschil, string valuta, string voertaal)
        {
            using (OracleConnection conn = connection)
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO LAND VALUES (:landcode, :naam, :landnummer, :hoofdstad, :voertaal, :valuta, :cultuur, :staatsvorm, :tijdsverschil, :ligging, :oppervlakte , :aantalInwoners, null)", conn);
                cmd.Parameters.Add("AANTALINWONERS", aantalInwoners);
                cmd.Parameters.Add("CULTUUR", cultuur);
                cmd.Parameters.Add("HOOFDSTAD", hoofdstad);
                cmd.Parameters.Add("LANDCODE", landcode);
                cmd.Parameters.Add("LANDNUMMER", landnummer);
                cmd.Parameters.Add("LIGGING", ligging);
                cmd.Parameters.Add("NAAM", naam);
                cmd.Parameters.Add("OPPERVLAKTE", oppervlakte);
                cmd.Parameters.Add("STAATSVORM", staatsvorm.ToString());
                cmd.Parameters.Add("TIJDSVERSCHIL", tijdsverschil);
                cmd.Parameters.Add("VALUTA", valuta);
                cmd.Parameters.Add("VOERTAAL", voertaal);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region BOEKING TOEVOEGEN
        /// <summary>
        /// Boeking toevoegen
        /// </summary>
        /// <param name="boekinsNummer">Het nummer van de boeking</param>
        /// <param name="datumRetour">Datum terugreis</param>
        /// <param name="datumVertrek">Datum vertrek</param>
        /// <param name="organisatie">Organisator van de reis</param>
        /// <param name="paspoortID">Paspoort of ID-kaart nodig?</param>
        /// <param name="soortVakantie">Wat voor soort vakantie</param>
        /// <param name="totaalPrijs">De totaalprijs</param>
        /// <param name="visum">Is er een visum nodig?</param>
        /// <param name="voertuig">Welk voertuig is er gebruikt?</param>
        /// <param name="landcode">Twee letterige code van het land</param>
        public void boekingToevoegen(string boekinsNummer, DateTime datumRetour, DateTime datumVertrek, string organisatie, string paspoortID, Boeking.VakSoort soortVakantie, double totaalPrijs, char visum, string voertuig, string landcode)
        {
            using (OracleConnection conn = connection)
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO BOEKING VALUES (:boekinsNummer, :datumRetour, :datumVertrek, :organisatie, :paspoortID, :soortVakantie, :totaalPrijs, :visum, :voertuig, :landcode)", conn);
                cmd.Parameters.Add("BOEKINGSNUMMER", boekinsNummer);
                cmd.Parameters.Add("DATUMRETOUR", datumRetour);
                cmd.Parameters.Add("DATUMVERTREK", datumVertrek);
                cmd.Parameters.Add("ORGANISATIE", organisatie);
                cmd.Parameters.Add("IDKAARTOFPASPOORT", paspoortID);
                cmd.Parameters.Add("SOORTVAKANTIE", soortVakantie.ToString());
                cmd.Parameters.Add("TOTAALPRIJS", totaalPrijs);
                cmd.Parameters.Add("VISUM", visum);
                cmd.Parameters.Add("VOERTUIG", voertuig);
                cmd.Parameters.Add("LAND_LANDCODE", landcode);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region REIS TOEVOEGEN
        /// <summary>
        /// Reis toevoegen
        /// </summary>
        /// <param name="reistijd">De duur van de reis</param>
        /// <param name="vertrekpunt">Plaats van vertrek</param>
        /// <param name="aankomstpunt">Plaats van aankosmt</param>
        /// <param name="vertrektijd">Vertrektijd</param>
        /// <param name="reiscode">Code van de reis</param>
        public void reisToevoegen(string reistijd, string vertrekpunt, string aankomstpunt, string vertrektijd, string reiscode)
        {
            using (OracleConnection conn = connection)
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO REIS VALUES (:reistijd, :vertrekpunt, :aankomstpunt, :vertrektijd, :reiscode, null, null)", conn);
                cmd.Parameters.Add("REISTIJD", reistijd);
                cmd.Parameters.Add("VERTREKPUNT", vertrekpunt);
                cmd.Parameters.Add("AANKOMSTPUNT", aankomstpunt);
                cmd.Parameters.Add("VERTREKTIJD", vertrektijd);
                cmd.Parameters.Add("REISCODE", reiscode);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region ACCOMODATIE TOEVOEGEN
        /// <summary>
        /// Accomodatie toevoegen
        /// </summary>
        /// <param name="adres">Adres</param>
        /// <param name="categorie">Aantal sterren</param>
        /// <param name="naam">Naam</param>
        /// <param name="postcode">Postcode</param>
        /// <param name="plaats">Plaats</param>
        /// <param name="soort">Soort</param>
        /// <param name="telefoonnummer">Telefoonnummer</param>
        /// <param name="verzorging">Verzorging</param>
        /// <param name="website">Website van de accomodatie</param>
        public void accomodatieToevoegen(string adres, string categorie, string naam, string postcode, string plaats, Accomodatie.AcSoort soort, string telefoonnummer, Accomodatie.Verzorging verzorging, string website)
        {
            using (OracleConnection conn = connection)
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO ACCOMODATIE VALUES (:adres, :categorie, :naam, :postcode, :plaats, :soort, :telefoonnummer, :verzorging, :website, null, null);)", conn);
                cmd.Parameters.Add("ADRES", adres);
                cmd.Parameters.Add("CATEGORIE", categorie);
                cmd.Parameters.Add("NAAM", naam);
                cmd.Parameters.Add("POSTCODE", postcode);
                cmd.Parameters.Add("PLAATS", plaats);
                cmd.Parameters.Add("SOORT", soort.ToString());
                cmd.Parameters.Add("TELEFOONNUMMER", telefoonnummer);
                cmd.Parameters.Add("VERZORGING", verzorging.ToString());
                cmd.Parameters.Add("WEBSITE", website);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region PLAATS TOEVOEGEN
        /// <summary>
        /// Plaats toevoegen
        /// </summary>
        /// <param name="aantalInwoners">Aantal inwoners van de plaats</param>
        /// <param name="areacode">Cijfercode van een plaats</param>
        /// <param name="plaatsnaam">Plaatsnaam</param>
        /// <param name="stadOfDorp">Is het een stad of een dorp?</param>
        /// <param name="Landcode">Twee letterige code van het land</param>
        public void plaatsToevoegen(double aantalInwoners, int areacode, string plaatsnaam, string stadOfDorp, string Landcode)
        {
            using (OracleConnection conn = connection)
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO PLAATS VALUES (:plaatsnaam, :aantalInwoners, :stadOfDorp, :areacode, :Landcode, null, null, null);)", conn);
                cmd.Parameters.Add("PLAATSNAAM", plaatsnaam);
                cmd.Parameters.Add("AANTALINWONERS", aantalInwoners);
                cmd.Parameters.Add("STADOFDORP", stadOfDorp);
                cmd.Parameters.Add("AREACODE", areacode);
                cmd.Parameters.Add("LAND_LANDCODE", Landcode);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion

        #region ACTIVITEIT TOEVOEGEN
        /// <summary>
        /// Activiteit toevoegen
        /// </summary>
        /// <param name="adres">Adres</param>
        /// <param name="arragement">Is er een arragement mogelijk?</param>
        /// <param name="naam">Naam</param>
        /// <param name="omschrijving">Omschrijving van de activiteit</param>
        /// <param name="organisatie">Organisatie die de activiteit organiseerd</param>
        /// <param name="plaats">Plaats</param>
        /// <param name="postcode">Postcode</param>
        /// <param name="prijs">Prijs van deelnamen</param>
        /// <param name="telefoonnummer">Telefoonnummer</param>
        /// <param name="type">Wat voor soort activiteit is het?</param>
        public void activiteitToevoegen(string adres, char arragement, string naam, string omschrijving, string organisatie, string plaats, string postcode, double prijs, string telefoonnummer, string type)
        {
            using (OracleConnection conn = connection)
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO ACTIVITEIT VALUES (:naam, :omschrijving, :organisatie, :adres, :postcode, :plaats, :telefoonnummer, null, :type, :arragement, :prijs, null, null, null)", conn);
                cmd.Parameters.Add("ADRES", adres);
                cmd.Parameters.Add("ARRAGEMENTMOGELIJK", arragement);
                cmd.Parameters.Add("NAAM", naam);
                cmd.Parameters.Add("OMSCHRIJVING", omschrijving);
                cmd.Parameters.Add("ORGANISATIE", organisatie);
                cmd.Parameters.Add("PLAATS", plaats);
                cmd.Parameters.Add("POSTCODE", postcode);
                cmd.Parameters.Add("PRIJS", prijs);
                cmd.Parameters.Add("TELEFOONNUMMER", telefoonnummer);
                cmd.Parameters.Add("SOORT", type);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion
    }
}
        




     

    

