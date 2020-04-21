using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            DateTime sinterklaas = DateTime.Parse("5/12/2020");
            TimeSpan verschil = sinterklaas.Subtract(vandaag);
            int aantalDagen = verschil.Days;
            puikantwoord.Text = aantalDagen.ToString() + " dagen tot sinterklaas.";
        }
    }
}