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
        private string aankomstpunt;
        private string duur;
        private string heenTerug;
        private string vertrekpunt;
        private DateTime vertrektijd;
        private List<Boeking> boekingsLijst;

        // CONSTRUCTOR
        public Reis(string aankomstpunt, string duur, string heenTerug, string vertrekpunt, DateTime vertrektijd)
        {
            this.aankomstpunt = aankomstpunt;
            this.duur = duur;
            this.heenTerug = heenTerug;
            this.vertrekpunt = vertrekpunt;
            this.vertrektijd = vertrektijd;
            boekingsLijst = new List<Boeking>();
        }

        // PROPERTIES
        public string Aankomstpunt
        {
            get { return aankomstpunt; }
        }

        public string Duur
        {
            get { return duur; }
        }

        public string HeenTerug
        {
            get { return heenTerug; }
        }

        public string Vertrekpunt
        {
            get { return Vertrekpunt; }
        }

        public DateTime Vertrektijd
        {
            get { return vertrektijd; }
        }

        public List<Boeking> BoekingsLijst
        {
            get { return new List<Boeking>(boekingsLijst); }
        }

        // TOSTRING
        public override string ToString()
        {
            return " Aankomstpunt: " + Aankomstpunt + " Duur: " + Duur + " Heen of Terugreis: " + HeenTerug + " Vertrekpunt: " + Vertrekpunt + " Vertrektijd: " + Vertrektijd;
        }
    }

}
