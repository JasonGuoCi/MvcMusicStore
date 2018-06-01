using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsClient.SampleSvc;

namespace WindowsFormsClient
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            GetWeatherRequest req = new GetWeatherRequest();
            if (rabCelsius.Checked)
            {
                req.TemperatureType = TemperatureType.Celsius;
            }
            else
            {
                req.TemperatureType = TemperatureType.Fahrenheit;
            }

            req.City = txtCity.Text;

            SampleSvc.SampleServiceSoapClient svc = new SampleSvc.SampleServiceSoapClient();
            GetWeatherResponse resp = svc.GetWeature(req);
            txtTemperature.Text = resp.Temperature.ToString();
            txtWeaCondition.Text = resp.Condition.ToString();

        }
    }
}
