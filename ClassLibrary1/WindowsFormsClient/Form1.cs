using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string str1 = txtStr1.Text.ToString();

            // WebServiceSample.SampleServiceSoapClient svc = new WebServiceSample.SampleServiceSoapClient();
            SampleSvc.SampleServiceSoapClient svc = new SampleSvc.SampleServiceSoapClient();
            txtStr2.Text = svc.ReverseString(str1);




        }
    }
}
