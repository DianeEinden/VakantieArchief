using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klassen;

namespace SE22_VakantieArchief
{
    public partial class Test : System.Web.UI.Page
    {
        private Klassen.Beheer beheerder;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.beheerder = new Klassen.Beheer();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = TextBox1.Text + TextBox2.Text;
        }
    }
}