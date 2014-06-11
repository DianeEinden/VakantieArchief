using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string  constring;

        public DataKoppeling()
        {
            //constring = Settings.Default.ConnectieString;
            // Connection = new OracleConnection(constring);
            connection = new OracleConnection("User Id=" + "SE22_VAKANTIEARCHIEF" + " ;Password=" + "handyroosje" + ";Data Source=" + " //localhost:1521/xe" + ";");
        }

        #region LOGIN
        public Gebruiker Login(string username, string wachtwoord)
        {
            using (OracleConnection conn = new OracleConnection(constring))
            {
                OracleCommand cmd = new OracleCommand("select * from gebruiker where gebruikersnaam=:naam and wachtwoord=:wachtwoord", conn);
                cmd.Parameters.Add("naam", username);
                cmd.Parameters.Add("wachtwoord", wachtwoord);
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Gebruiker g = new Gebruiker(rdr["naam"].ToString(), rdr["wachtwoord"].ToString());
                    return g;
                }
                return null;
            }

        }
        #endregion

        #region AANMELDEN
        public void Login(Gebruiker gebruiker)
        {
            using (OracleConnection conn = new OracleConnection(constring))
            {
                OracleCommand cmd = new OracleCommand("INSERT INTO GEBRUIKER VALUES (':naam',':wachtwoord'); ", conn);
                cmd.Parameters.Add("naam", gebruiker.Naam);
                cmd.Parameters.Add("wachtwoord", gebruiker.Wachtwoord);
                
                cmd.ExecuteNonQuery();
            }
        }
        #endregion 

        #region ALLE EUROPA REIZEN
        public Land EuropeseReizen()
        {
            using (OracleConnection conn = new OracleConnection(constring))
            {
                OracleCommand cmd = new OracleCommand("select * from land where ligging = europa", conn);
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Land l = new Land(rdr["ligging"].ToString());
                    return l;
                }
                return null;
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
        //    using (OracleConnection conn = new OracleConnection(constring))
        //    {
        //        OracleCommand cmd = new OracleCommand("select * from land where gebruikersnaam=:naam", conn);
        //        OracleDataReader rdr = cmd.ExecuteReader();
        //        List<Land> ret=new List<Land>();
        //        if (rdr.Read())
        //        {
        //            ret = new Land(Convert.ToDouble(rdr["aanta;lInwoners"]), rdr["cultuur"].ToString(), rdr["hoodstad"].ToString(), rdr["landcode"].ToString(), Convert.ToInt32(rdr["landnummer"]), rdr["ligging"].ToString(), rdr["naam"].ToString(), Convert.ToDouble(rdr["oppervlakte"]), (Land.Staatsvorm)Enum.Parse(typeof(Land.Staatsvorm), Convert.ToString(rdr["staatsvorm"])), Convert.ToBoolean(rdr["tijdsverschil"]), rdr["valuta"].ToString(), rdr["voertaal"].ToString());    
        //            return ret;
        //        }
        //        return null;
        //    }

        //}


    }
}
