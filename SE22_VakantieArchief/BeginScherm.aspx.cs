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
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Klassen.Beheer();
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

        protected void BtPlaatsen_Click(object sender, EventArgs e)
        {
            string selecteditem = this.LbReizen.SelectedItem.Value;
            LbReizen.Items.Clear();
           
            List<Plaats> plaats = new List<Plaats>(beheerder.plaatsenBekijken(selecteditem));
            try
            {
                foreach (Plaats plaatsjes in plaats)
                {
                    LbPlaatsen.Items.Add(plaatsjes.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}