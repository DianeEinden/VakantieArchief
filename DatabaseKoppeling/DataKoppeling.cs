using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Configuration;
using DatabaseKoppeling.Properties;
using Klassen;


namespace DatabaseKoppeling
{
    public class DataKoppeling
    {
        private string constring;

        public DataKoppeling()
        {
            constring = Settings.Default.ConnectieString;
            // Connection = new OracleConnection(constring);
        }

        public Gebruiker Login(string username, string wachtwoord)
        { 
            using(OracleConnection conn = new OracleConnection(constring))
            {
                OracleCommand cmd = new OracleCommand("select * from gebruiker where gebruikersnaam=:naam and wachtwoord=:wachtwoord",conn);
                cmd.Parameters.Add("naam", username);
                cmd.Parameters.Add("wachtwoord", wachtwoord);
                OracleDataReader rdr = cmd.ExecuteReader();
                if(rdr.Read())
                {
                    Gebruiker g = new Gebruiker(rdr["naam"].ToString(), rdr["wachtwoord"].ToString());
                    return g;
                }
                return null;
            }
           
        }

    }
}
