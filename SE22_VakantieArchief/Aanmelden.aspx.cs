﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klassen;

namespace SE22_VakantieArchief
{
    public partial class Aanmelden : System.Web.UI.Page
    {
        private Klassen.Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Klassen.Beheer();
        }

        protected void BtAanmelden_Click(object sender, EventArgs e)
        {
            try
            {
                beheerder.Aanmelden(TbGebruikersnaam.Text, TbWachtwoord.Text);
                Response.Redirect("~/Default.aspx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}