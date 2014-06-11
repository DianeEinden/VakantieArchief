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

        protected void BtEuropa_Click(object sender, EventArgs e)
        {
            LbReizen.Items.Clear();

            List<Land> landen = new List<Land>(beheerder.EuropeseReizen());
            try
            {
                foreach (Land landjes in landen)
                {
                    LbReizen.Items.Add(landjes.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}