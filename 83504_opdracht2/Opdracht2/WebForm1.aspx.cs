using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        double antwoord;
        string antwoordtekst;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void min_Click(object sender, EventArgs e)
        {
            string cijfer1tekst = Getal1.Text;
            string cijfer2tekst = Getal2.Text;
            double cijfer1 = Double.Parse(cijfer1tekst);
            double cijfer2 = Double.Parse(cijfer2tekst);

            antwoord = cijfer2 - cijfer1;
            Antwoordbox.Text = antwoord.ToString();
        }

        protected void plus_Click(object sender, EventArgs e)
        {
            string cijfer1tekst = Getal1.Text;
            string cijfer2tekst = Getal2.Text;
            double cijfer1 = Double.Parse(cijfer1tekst);
            double cijfer2 = Double.Parse(cijfer2tekst);

            antwoord = cijfer2 + cijfer1;
            Antwoordbox.Text = antwoord.ToString();
        }

        protected void keer_Click(object sender, EventArgs e)
        {
            string cijfer1tekst = Getal1.Text;
            string cijfer2tekst = Getal2.Text;
            double cijfer1 = Double.Parse(cijfer1tekst);
            double cijfer2 = Double.Parse(cijfer2tekst);

            antwoord = cijfer2 * cijfer1;
            Antwoordbox.Text = antwoord.ToString();
        }

        protected void deel_Click(object sender, EventArgs e)
        {
            string cijfer1tekst = Getal1.Text;
            string cijfer2tekst = Getal2.Text;
            double cijfer1 = Double.Parse(cijfer1tekst);
            double cijfer2 = Double.Parse(cijfer2tekst);

            antwoord = cijfer2 / cijfer1;
            Antwoordbox.Text = antwoord.ToString();
        }
    }
}