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

        public DataKoppeling()
        {
            //constring = Settings.Default.ConnectieString;
            // Connection = new OracleConnection(constring);
            connection = new OracleConnection("User Id=" + "SE22_VAKANTIEARCHIEF" + " ;Password=" + "handyroosje" + ";Data Source=" + " //localhost:1521/xe" + ";");
        }

        #region LOGIN
        public Gebruiker Login(string username, string wachtwoord)
        {
            try
            {
                // using (OracleConnection conn = new OracleConnection(constring))
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
        public void Aanmelden(string naam, string wachtwoord)
        {
            // using (OracleConnection conn = new OracleConnection(constring))
            using (OracleConnection conn = connection)
            {
                //OracleCommand controle = new OracleCommand("select * from gebruiker where gebruikersnaam=:naam", conn);
                //controle.Parameters.Add("naam", naam);

                //OracleCommand cmd = new OracleCommand("INSERT INTO GEBRUIKER VALUES (:naam, :wachtwoord)", conn);
                //cmd.Parameters.Add("GEBRUIKERSNAAM", naam);
                //cmd.Parameters.Add("WACHTWOORD", wachtwoord);

                //connection.Open();
                //OracleDataReader rdr = controle.ExecuteReader();
                //if (rdr.Read())
                //{
                //    cmd.ExecuteNonQuery();
                //    connection.Close();
                //}
                //else
                //{
                //    Console.WriteLine("Gebruikersnaam bestaat al");
                //}               
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
                    if (rdr.Read())
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
                        return europeseLanden;
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
                    if (rdr.Read())
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
                        return afrikaanseReizenLijst;
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
                    if (rdr.Read())
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
                        return azieReizenLijst;
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
                    if (rdr.Read())
                    {
                        List<Boeking> boekingOpvragen = new List<Boeking>();

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
                        return boekingOpvragen;
                    }
                    return null;

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
                    if (rdr.Read())
                    {
                        List<Reis> reisOpvragen = new List<Reis>();
                        string reistijd = Convert.ToString(rdr["REISTIJD"]);
                        string vertrekpunt = Convert.ToString(rdr["VERTREKPUNT"]);
                        string aankomstpunt = Convert.ToString(rdr["AANKOMSTPUNT"]);
                        string vertrektijd = Convert.ToString(rdr["VERTREKTIJD"]);
                        string reiscode = Convert.ToString(rdr["REISCODE"]);
                        reisOpvragen.Add(new Reis(reistijd, vertrekpunt, aankomstpunt, vertrektijd, reiscode));
                        return reisOpvragen;
                    }
                    return null;

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
                    if (rdr.Read())
                    {
                        List<Accomodatie> accomodatieBekijken = new List<Accomodatie>();
                        string adres = Convert.ToString(rdr["ADRES"]);
                        string categorie = Convert.ToString(rdr["CATEGORIE"]);
                        string naam = Convert.ToString(rdr["NAAM"]);
                        string postcode = Convert.ToString(rdr["POSTCODE"]);
                        string plaats = Convert.ToString(rdr["PLAATS"]);
                        Accomodatie.AcSoort soort = (Accomodatie.AcSoort)Enum.Parse(typeof(Accomodatie.AcSoort), Convert.ToString(rdr["SOORT"]));
                        string telefoonnummer = Convert.ToString(rdr["TELEFOONNUMMER"]);
                        //Accomodatie.AcType type = (Accomodatie.AcType)Enum.Parse(typeof(Accomodatie.AcType), Convert.ToString(rdr["SOORTVAKANTIE"]));
                        Accomodatie.Verzorging verzorging = (Accomodatie.Verzorging)Enum.Parse(typeof(Accomodatie.Verzorging), Convert.ToString(rdr["VERZORGING"]));
                        string website = Convert.ToString(rdr["WEBSITE"]);
                        accomodatieBekijken.Add(new Accomodatie(adres, categorie, naam, postcode, plaats, soort, telefoonnummer, /*type,*/ verzorging, website));
                        return accomodatieBekijken;
                    }
                    return null;

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
                    if (rdr.Read())
                    {
                        List<Plaats> plaatsenLijst = new List<Plaats>();

                        double aantalInwoners = Convert.ToDouble(rdr["AANTALINWONERS"]);
                        int areacode = Convert.ToInt32(rdr["AREACODE"]);
                        string plaatsnaam = Convert.ToString(rdr["PLAATSNAAM"]);
                        string stadOfDorp = Convert.ToString(rdr["STADOFDORP"]);

                        plaatsenLijst.Add(new Plaats(aantalInwoners, areacode, plaatsnaam, stadOfDorp));
                        return plaatsenLijst;
                    }
                    return null;

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
                    if (rdr.Read())
                    {
                        List<Activiteit> activiteitenLijst = new List<Activiteit>();

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
                        return activiteitenLijst;
                    }
                    return null;

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

        // NOG CONTROLEREN
        #region KUNSTMATIGE-BEZIENSWAARDIGHEID
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
                    if (rdr.Read())
                    {
                        List<KunstmatigeBZW> KMbezienswaardigheden = new List<KunstmatigeBZW>();
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

                        return KMbezienswaardigheden;
                    }
                    return null;

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

        // NOG CONTROLEREN
        #region NATUURLIJKE-BEZIENSWAARDIGHEID
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
                    if (rdr.Read())
                    {
                        List<NatuurlijkeBZW> NMbezienswaardigheden = new List<NatuurlijkeBZW>();
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

                        return NMbezienswaardigheden;
                    }
                    return null;

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



    }
}
        




        //ReisOpzoeken()
//ReisToevoegen()
//ReisVerwijderen()
//Sorteren()
//ToString()
//Uitloggen()

        //public List<Land> AlleLanden()
        //{
        //    using (OracleConnection conn = connection)
        //    {
        //        OracleCommand cmd = new OracleCommand("select * from land where gebruikersnaam=:naam", conn);
        //        OracleDataReader rdr = cmd.ExecuteReader();
        //        List<Land> ret = new List<Land>();
        //        if (rdr.Read())
        //        {
        //            ret = new Land(Convert.ToDouble(rdr["aantalInwoners"]), rdr["cultuur"].ToString(), rdr["hoodstad"].ToString(), rdr["landcode"].ToString(), Convert.ToInt32(rdr["landnummer"]), rdr["ligging"].ToString(), rdr["naam"].ToString(), Convert.ToDouble(rdr["oppervlakte"]), (Land.Staatsvorm)Convert.ToInt32(rdr["staatsvorm"]), Convert.ToBoolean(rdr["tijdsverschil"]), rdr["valuta"].ToString(), rdr["voertaal"].ToString());
        //            return ret;
        //        }

        //        return null;
        //    }

        //}


    

