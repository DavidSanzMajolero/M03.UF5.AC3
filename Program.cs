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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            List<ConsumAigua> consumAiguas = new List<ConsumAigua>();
            consumAiguas = ReadCsv();
            XMLHelper.CreateXMLFileWithLINQ(consumAiguas);

        }
        private static List<ConsumAigua> ReadCsv()
        {
            using var reader = new StreamReader("Consum_d_aigua_a_Catalunya_per_comarques_20240402.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<ConsumAigua>();
            return records.ToList();
        }
    }
}