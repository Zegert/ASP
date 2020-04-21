using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _83504_opdracht5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        double totaalprijs;
        string totaalprijsString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            totaalprijs += 3;
            if (CheckBox1.Checked == true)
            {
                totaalprijs += 1;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox2.Checked == true)
            {
                totaalprijs += 2;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox3.Checked == true)
            {
                totaalprijs += 2;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox4.Checked == true)
            {
                totaalprijs += 2;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox5.Checked == true)
            {
                totaalprijs += 2.5;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox6.Checked == true)
            {
                totaalprijs += 2;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox7.Checked == true)
            {
                totaalprijs += 1;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            if (CheckBox8.Checked == true)
            {
                totaalprijs += 2;
            }
            totaalprijsString = totaalprijs.ToString();
            Label1.Text = totaalprijsString;
            
        }
    }
}