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
                    cmd.Parameters.Add("gebruikersnaam", username);
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
                OracleCommand cmd = new OracleCommand("INSERT INTO GEBRUIKER VALUES (':naam',':wachtwoord'); ", conn);
                cmd.Parameters.Add("naam", naam);
                cmd.Parameters.Add("wachtwoord", wachtwoord);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        #endregion 

        #region EUROPESE REIZEN
        public List<Land> EuropeseReizenLijst()
        {
            try
            {
                using (OracleConnection conn = connection)
                {
                    OracleCommand cmd = new OracleCommand("select * from land where ligging = Europa", conn);
                    connection.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    List<Land> europeseLanden = new List<Land>();
                    if (rdr.Read())
                    {
                        europeseLanden.Add(new Land(Convert.ToDouble(rdr["aantalInwoners"]), rdr["cultuur"].ToString(), rdr["hoodstad"].ToString(), rdr["landcode"].ToString(), Convert.ToInt32(rdr["landnummer"]), rdr["ligging"].ToString(), rdr["naam"].ToString(), Convert.ToDouble(rdr["oppervlakte"]), (Land.Staatsvorm)Convert.ToInt32(rdr["staatsvorm"]), Convert.ToBoolean(rdr["tijdsverschil"]), rdr["valuta"].ToString(), rdr["voertaal"].ToString()));
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


    }
}
