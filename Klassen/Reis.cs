using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Reis
    {
        // DATA
        private string reistijd;
        private string vertrekpunt;
        private string aankomstpunt;
        private string vertrektijd;
        private string reiscode;
        private List<Boeking> boekingsLijst;

        // CONSTRUCTOR
        public Reis(string reistijd, string vertrekpunt, string aankomstpunt, string vertrektijd, string reiscode)
        {
            this.reistijd = reistijd;
            this.vertrekpunt = vertrekpunt;
            this.aankomstpunt = aankomstpunt;
            this.vertrektijd = vertrektijd;
            this.reiscode = reiscode;
            boekingsLijst = new List<Boeking>();
        }

        // PROPERTIES
        public string Reistijd
        {
            get { return reistijd; }
        }

        public string Vertrekpunt
        {
            get { return vertrekpunt; }
        }

        public string Aankomst
        {
            get { return aankomstpunt; }
        }

        public string Vertrektijd
        {
            get { return vertrektijd; }
        }

        public string Reiscode
        {
            get { return reiscode; }
        }
        public List<Boeking> BoekingsLijst
        {
            get { return new List<Boeking>(boekingsLijst); }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Reistijd: " + reiscode + " Vertrekpunt: " + vertrekpunt + " Aankomst: " + aankomstpunt + " Vertrektijd: " + vertrekpunt + " Reiscode: " + reiscode;
        }
    }

}
