using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _83504_opdracht1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string voornaam = TextBox4.Text;
            string achternaam = TextBox3.Text;
            string woonplaats = TextBox2.Text;
            string klas = TextBox1.Text;

            string groet = "Hallo " + voornaam + " " + achternaam + "." + " Je woont in " + woonplaats + ". " + "Je zit in klas " + klas + ".";
            TextBox5.Text = groet;
        }
    }
}