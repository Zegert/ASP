using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double antwoord;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double aantal = double.Parse(TextBox1.Text);
            if(aantal < 10)
            {
                antwoord = aantal * 2.00;
            }
            else if (aantal >= 10 & aantal < 50)
            {
                antwoord = aantal * 1.50;
            }
            else if (aantal >= 50 & aantal < 100)
            {
                antwoord = aantal * 1.25;
            }
            else if (aantal >= 100)
            {
                antwoord = aantal * 1.1;
            }
            string antwoordText = antwoord.ToString();
            Label1.Text = antwoordText;
            
        }

    }
}