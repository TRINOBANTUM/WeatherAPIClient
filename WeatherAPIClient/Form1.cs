using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using WeatherTest.SampleApi.Bbc.Models;
using WeatherTest.SampleApi.Accu.Models;

namespace WeatherAPIClient
{
    public partial class Form1 : Form
    {
        //This Program Needs an .NET API Host:  https://github.com/4Com/WeatherTest

        //Dev Note: Rework Dependancy Injection and Dynamic for more API's
        static HttpClient bbcweatherclient = new HttpClient();
        static HttpClient accweatherclient = new HttpClient();
        
        public Form1()
        {
            InitializeComponent();

            radCelsius.Checked = true;
            radMph.Checked     = true; 

            bbcweatherclient.BaseAddress = new Uri("http://localhost:60350/");
            bbcweatherclient.DefaultRequestHeaders.Accept.Clear();
            bbcweatherclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            accweatherclient.BaseAddress = new Uri("http://localhost:60368/");
            accweatherclient.DefaultRequestHeaders.Accept.Clear();
            accweatherclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //Dev Note: Rework Move Methods out to new unit.
        private void button1_Click(object sender, EventArgs e)
        {
            RunAsync();
        }

        public static double ConvertCelsiusToFahrenheit(double c)
        {
            return ((9.0 / 5.0) * c) + 32;
        }

        public static double ConvertMilesToKilometers(double miles)
        {
           return miles * 1.609344;
        }

        public static double ConvertFahrenheitToCelsius(double f)
        {
           return (5.0 / 9.0) * (f - 32);
        }

        public static double ConvertKilometersToMiles(double kilometers)
        {
           return kilometers * 0.621371192;
        }

        //Dev Note: Rework Dependancy Injection and Dynamic for more API's
        private async Task<BbcWeatherResult> GetBbcWeatherResultAsync()
        {
            BbcWeatherResult bbcWeatherResult = null;

            HttpResponseMessage response = await bbcweatherclient.GetAsync("weather/london");
            if (response.IsSuccessStatusCode)
            {
                bbcWeatherResult = await response.Content.ReadAsAsync<BbcWeatherResult>();
            }
            return bbcWeatherResult;
        }

        //Dev Note: Rework Dependancy Injection and Dynamic for more API's
        private async Task<AccWeatherResult> GetAccWeatherResultAsync()
        {
            AccWeatherResult accWeatherResult = null;

            HttpResponseMessage response = await accweatherclient.GetAsync("london");
            if (response.IsSuccessStatusCode)
            {
                accWeatherResult = await response.Content.ReadAsAsync<AccWeatherResult>();
            }
            return accWeatherResult;
        }

        private async void RunAsync()
        {
            double TotalCelsius = 0.0;
            double TotalKph     = 0.0;

            try
            {
                //Dev Note: Rework Dependancy Injection and Dynamic for more API's
                var bbcWeatherResult = await GetBbcWeatherResultAsync();

                TotalCelsius = TotalCelsius + bbcWeatherResult.TemperatureCelsius;
                TotalKph = TotalKph + bbcWeatherResult.WindSpeedKph;

                //Dev Note: Rework Dependancy Injection and Dynamic for more API's
                var accWeatherResult = await GetAccWeatherResultAsync();

                TotalCelsius = TotalCelsius + ConvertFahrenheitToCelsius(accWeatherResult.TemperatureFahrenheit);
                TotalKph = TotalKph + ConvertMilesToKilometers(accWeatherResult.WindSpeedMph);

                try
                {
                    //Dev Note: Rework Dependancy Injection and Dynamic for more API's
                     TotalCelsius = (TotalCelsius / 2);
                }
                catch
                {
                    //Do Nothing;
                }

                try
                {
                    //Dev Note: Rework Dependancy Injection and Dynamic for more API's
                     TotalKph = (TotalKph / 2);
                }
                catch
                {
                    //Do Nothing;
                }

                //Dev Note: Rework Make Dynamic for more Units of Measure.
                //Seperate out for Unit Testing moq.
                if (radCelsius.Checked)
                {
                    lblTemp.Text = "Temperature " + Math.Round(TotalCelsius, 1).ToString() + " Celsius";
                }
                else
                {
                    var TotalFahrenheit = ConvertCelsiusToFahrenheit(TotalCelsius);
                    lblTemp.Text = "Temperature " + Math.Round(TotalFahrenheit, 1).ToString() + " Fahrenheit";
                };

                if (radKph.Checked)
                {
                    lblWindSpeed.Text = "Wind Speed " + Math.Round(TotalKph, 1).ToString() + " Mph";
                }
                else
                {
                    var TotalMph = ConvertMilesToKilometers(TotalKph);
                    lblWindSpeed.Text = "Wind Speed " + Math.Round(TotalMph, 1).ToString() + " Kph";
                }

            }
            catch (Exception e)
            {
              //Dev Note: Add more advanced error handling. nested API Failure and Time Out Etc.
              MessageBox.Show(e.Message);
            }
                               
         }
         
     }
}
