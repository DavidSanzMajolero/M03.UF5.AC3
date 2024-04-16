using System.Globalization;
using Ac3;
using CsvHelper;

namespace M03.UF5.AC3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }        
    }
}