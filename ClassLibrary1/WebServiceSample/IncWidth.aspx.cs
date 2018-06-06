using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceSample
{
    public partial class IncWidth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblTest.Text = "0";
            }
           
        }

        protected void btnIncrease_Click(object sender, EventArgs e)
        {
            string num = lblTest.Text;
            lblTest.Text = (Int32.Parse(lblTest.Text) + 1).ToString();
        }
    }
}