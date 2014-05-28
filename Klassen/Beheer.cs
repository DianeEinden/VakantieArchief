using DatabaseKoppeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Beheer
    {
        // DATA
        public List<Reis> reisLijst;
        DataKoppeling k = new DataKoppeling();

        // CONSTRUCTOR
        public Beheer()
        {
            reisLijst = new List<Reis>();
        }

        // PROPERTIES
        public List<Reis> ReisLijst
        {
            get { return new List<Reis>(reisLijst); }
        }

        // METHODEN
        
        public void Aanmelden()
        {
            // TODO
        }

        #region INLOGGEN
        public bool Inloggen(string naam, string ww)
        {
            Gebruiker g = k.Login(naam, ww);
            return g != null;
        }
        #endregion

        public void ReisAanpassen()
        {
            // TODO
        }

        public void ReisBekijken()
        {
            // TODO
        }

        public void ReisDelen()
        {
            // TODO
        }

        public void ReisOpzoeken()
        {
            // TODO
        }

        public void ReisToevoegen()
        {
            // TODO
        }

        public void ReisVerwijderen()
        {
            // TODO
        }

        public void Sorteren()
        {
            // TODO
        }

        public void Uitloggen()
        {
            // TODO
        }

        public void ToString()
        {
            // TODO
        }
    }
}
