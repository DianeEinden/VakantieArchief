using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klassen;

namespace SE22_VakantieArchief
{
    public partial class BeginScherm : System.Web.UI.Page
    {
        private Klassen.Beheer beheerder;
        private Klassen.Land.Staatsvorm staatsvormpje;
        private Klassen.Boeking.VakSoort vakSoortje;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Klassen.Beheer();
            this.DdlStaatsvorm.DataSource = Enum.GetValues(typeof(Land.Staatsvorm));
            this.DdlVaksoort.DataSource = Enum.GetValues(typeof(Boeking.VakSoort));
        }

        #region EUROPA
        protected void BtEuropa_Click(object sender, EventArgs e)
        {
            LbReizen.Items.Clear();

            List<Land> landen = new List<Land>(beheerder.EuropeseReizen());
            try
            {
                foreach (Land landjes in landen)
                {
                    ListItem item = new ListItem(landjes.ToString(), landjes.Landcode);
                    LbReizen.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region AFRIKA
        protected void BtAfrika_Click(object sender, EventArgs e)
        {
            LbReizen.Items.Clear();

            List<Land> landen = new List<Land>(beheerder.AfraanseReizen());
            try
            {
                foreach (Land landjes in landen)
                {
                    ListItem item = new ListItem(landjes.ToString(), landjes.Landcode);
                    LbReizen.Items.Add(landjes.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region AZIE
        protected void BtAzie_Click(object sender, EventArgs e)
        {
            LbReizen.Items.Clear();

            List<Land> landen = new List<Land>(beheerder.AzieReizen());
            try
            {
                foreach (Land landjes in landen)
                {
                    ListItem item = new ListItem(landjes.ToString(), landjes.Landcode);
                    LbReizen.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region REIS OPVRAGEN
                protected void BtReisInzien_Click(object sender, EventArgs e)
                {
                    int selecteditem = Convert.ToInt32(this.LbBoeking.SelectedItem.Value);
                    LbBoeking.Items.Clear();

                    List<Reis> reizen = new List<Reis>(beheerder.reisOpvragen(selecteditem));
                    try
                    {
                        foreach (Reis reisjes in reizen)
                        {

                            LbReis.Items.Add(reisjes.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
        #endregion

        #region BOEKING OPVRAGEN
        protected void BtBoekingOpvragen_Click(object sender, EventArgs e)
        {
            string selecteditem = this.LbReizen.SelectedItem.Value;
            LbReizen.Items.Clear();          

            List<Boeking> boeking = new List<Boeking>(beheerder.boekingOpvragen(selecteditem));
            try
            {
                foreach (Boeking boekingkje in boeking)
                {
                    ListItem item = new ListItem(boekingkje.ToString(), boekingkje.BoekingsNummer);
                    LbBoeking.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        
        }
#endregion

        #region ACCOMODATIE BEKIJKEN
        protected void BtAccomodatieBekijken_Click(object sender, EventArgs e)
        {
            int selecteditem = Convert.ToInt32(this.LbBoeking.SelectedItem.Value); 
            LbBoeking.Items.Clear();

            List<Accomodatie> accomodatie = new List<Accomodatie>(beheerder.accomodatieBekijken(selecteditem));
            try
            {
                foreach (Accomodatie accootjes in accomodatie)
                {
                    LbAccomodatie.Items.Add(accootjes.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region PLAATSEN
        protected void BtPlaatsen_Click(object sender, EventArgs e)
        {
            string selecteditem = this.LbReizen.SelectedItem.Value;
            LbPlaatsen.Items.Clear();
           
            List<Plaats> plaats = new List<Plaats>(beheerder.plaatsenBekijken(selecteditem));
            try
            {
                foreach (Plaats plaatsjes in plaats)
                {
                    ListItem item = new ListItem(plaatsjes.ToString(), plaatsjes.Areacode.ToString());
                    LbPlaatsen.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ACTIVITEIT
        protected void BtActiviteit_Click(object sender, EventArgs e)
        {
            int selecteditem = Convert.ToInt32(this.LbPlaatsen.SelectedItem.Value);
            LbPlaatsen.Items.Clear();

            List<Activiteit> activiteit = new List<Activiteit>(beheerder.activiteitenOverzicht(selecteditem));
            try
            {
                foreach (Activiteit activiteitje in activiteit)
                {
                    LbActiviteit.Items.Add(activiteitje.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region BEZIENSWAARDIGHEDEN
        protected void BtBezienswaardigheid_Click(object sender, EventArgs e)
        {
            int selecteditem = Convert.ToInt32(this.LbPlaatsen.SelectedItem.Value);
            LbPlaatsen.Items.Clear();

            List<KunstmatigeBZW> Kbzw = new List<KunstmatigeBZW>(beheerder.KMbezienswaardigheden(selecteditem));
            List<NatuurlijkeBZW> Nbzw = new List<NatuurlijkeBZW>(beheerder.NMbezienswaardigheden(selecteditem));

            try
            {
                foreach (KunstmatigeBZW kunstje in Kbzw)
                {
                    LbKbzw.Items.Add(kunstje.ToString());
                }

                foreach (NatuurlijkeBZW natuurtje in Nbzw)
                {
                    LbNbzw.Items.Add(natuurtje.ToString());
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region LAND TOEVOEGEN
        protected void BtVoegToe_Click(object sender, EventArgs e)
        {
            // TIJDSVERSCHIL
            char tijdsverschil;
            if (this.RbN.Checked)
            {
                tijdsverschil = 'N';
            }
            else if(this.RbY.Checked)
            {
                tijdsverschil = 'Y';
            }
            else
            {
                throw new Exception("Maak een keuze");
            }

            // STAADSVORM
            if (this.DdlStaatsvorm.SelectedIndex == 0)
            {
                this.staatsvormpje = Land.Staatsvorm.Democratie;
            }
            else if (this.DdlStaatsvorm.SelectedIndex == 1)
            {
                this.staatsvormpje = Land.Staatsvorm.Dictatuur;
            }
            else if (this.DdlStaatsvorm.SelectedIndex == 2)
            {
                this.staatsvormpje = Land.Staatsvorm.Koningkrijk;
            }
            else if (this.DdlStaatsvorm.SelectedIndex == 3)
            {
                this.staatsvormpje = Land.Staatsvorm.Republiek;
            }


            try
            {
                beheerder.LandToevoegen(Convert.ToDouble(TbAantalInwoners.Text), TbCultuur.Text, TbHoofdsdtad.Text, TbLandcode.Text, Convert.ToInt32(TbLandnummer.Text), DdlLigging.SelectedValue, TbNaam.Text, Convert.ToDouble(TbOppervlakte.Text), staatsvormpje, tijdsverschil, TbValuta.Text, TbVoertaal.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region BOEKING TOEVOEGEN
        protected void BtBoekingToevoegen_Click(object sender, EventArgs e)
        {
            // PASSPOORT OF ID-KAART
            string PasId;
            if (this.RbPaspoort.Checked)
            {
                PasId = "Paspoort";
            }
            else if (this.RbID.Checked)
            {
                PasId = "ID-Kaart";
            }
            else
            {
                throw new Exception("Maak een keuze");
            }

            // VISUM NODIG
            string visum;
            if(this.RbVN.Checked)
            {
                visum = "Y";
            }
            else if(this.RbVY.Checked)
            {
                visum = "N";
            }
            else
            {
                throw new Exception("Maak een keuze");
            }


            // VAKSOORT
            if (this.DdlVaksoort.SelectedIndex == 0)
            {
                this.vakSoortje = Boeking.VakSoort.ActieveVakantie;
            }
            else if (this.DdlVaksoort.SelectedIndex == 1)
            {
                this.vakSoortje = Boeking.VakSoort.Alleengaandenreis;
            }
            else if (this.DdlVaksoort.SelectedIndex == 2)
            {
                this.vakSoortje = Boeking.VakSoort.AutoVakantie;
            }
            else if (this.DdlVaksoort.SelectedIndex == 3)
            {
                this.vakSoortje = Boeking.VakSoort.Busreis;
            }
            else if (this.DdlVaksoort.SelectedIndex == 4)
            {
                this.vakSoortje = Boeking.VakSoort.Cruise;
            }
            else if (this.DdlVaksoort.SelectedIndex == 5)
            {
                this.vakSoortje = Boeking.VakSoort.FlyDrive;
            }
            else if (this.DdlVaksoort.SelectedIndex == 6)
            {
                this.vakSoortje = Boeking.VakSoort.Rondreis;
            }
            else if (this.DdlVaksoort.SelectedIndex == 7)
            {
                this.vakSoortje = Boeking.VakSoort.SingleReis;
            }
            else if (this.DdlVaksoort.SelectedIndex == 8)
            {
                this.vakSoortje = Boeking.VakSoort.Stedentrip;
            }
            else if (this.DdlVaksoort.SelectedIndex == 9)
            {
                this.vakSoortje = Boeking.VakSoort.ZonVakantie;
            }


            try
            {
                beheerder.boekingToevoegen(TbBoekingsnummer.Text, Convert.ToDateTime(TbDatumRetour.Text), Convert.ToDateTime(TbDatumvertrek.Text), TbOrganisatie.Text, PasId, vakSoortje, Convert.ToDouble(TbTotaal.Text), Convert.ToChar(visum), TbVoertuig.Text, TbVoertuig0.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion


    }
}