using System;
using System.Windows.Forms;
using System.Net.Http;

namespace WeatherAPIClient
{
    static class Program
    {

        //This Program Needs an .NET API Host:  https://github.com/4Com/WeatherTest
        
        static HttpClient client = new HttpClient();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

       
    }
}
