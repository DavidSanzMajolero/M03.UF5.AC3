using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;

namespace Ac3
{
    public class XMLHelper
    {

        public static void CreateXMLFileWithLINQ(List<ConsumAigua> list)
        {
            XDocument xmlDoc = new XDocument(
                new XElement("data",
                    from item in list
                    select new XElement("row",
                        new XElement("Any", item.Any),
                        new XElement("Codi_comarca", item.Codi_comarca),
                        new XElement("Comarca", item.Comarca),
                        new XElement("Població", item.Poblacio),
                        new XElement("Domèstic_xarxa", item.Domestic_xarxa),
                        new XElement("Activitats_econòmiques_i_fonts_pròpies", item.Activitats_economiques_i_fonts_propies),
                        new XElement("Total", item.Total),
                        new XElement("Consum_domèstic_per_càpita", item.Consum_domestic_per_capital)
                    )
                )
            );

            string xmlFilePath = "AguasXML.xml";
            xmlDoc.Save(xmlFilePath);
        }

        public static void ReadXMLFile()
        {
            XDocument xmlDoc = XDocument.Load("AguasXML.xml");
            var query = from item in xmlDoc.Descendants("row")
                        select new
                        {
                            Any = item.Element("Any").Value,
                            Codi_comarca = item.Element("Codi_comarca").Value,
                            Comarca = item.Element("Comarca").Value,
                            Població = item.Element("Població").Value,
                            Domèstic_xarxa = item.Element("Domèstic_xarxa").Value,
                            Activitats_econòmiques_i_fonts_pròpies = item.Element("Activitats_econòmiques_i_fonts_pròpies").Value,
                            Total = item.Element("Total").Value,
                            Consum_domèstic_per_càpita = item.Element("Consum_domèstic_per_càpita").Value
                        };

            foreach (var item in query)
            {
                Console.WriteLine("Any: " + item.Any);
                Console.WriteLine("Codi_comarca: " + item.Codi_comarca);
                Console.WriteLine("Comarca: " + item.Comarca);
                Console.WriteLine("Població: " + item.Població);
                Console.WriteLine("Domèstic_xarxa: " + item.Domèstic_xarxa);
                Console.WriteLine("Activitats_econòmiques_i_fonts_pròpies: " + item.Activitats_econòmiques_i_fonts_pròpies);
                Console.WriteLine("Total: " + item.Total);
                Console.WriteLine("Consum_domèstic_per_càpita: " + item.Consum_domèstic_per_càpita);
                Console.WriteLine();
            }
        }



        public static DataTable LeerCSV(string rutaArchivo)
        {
            DataTable dataTable = new DataTable();
            string[] encabezados;
            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                if (!parser.EndOfData)
                {
                    encabezados = parser.ReadFields();
                }
                else
                {
                    return null; // Si el archivo está vacío, retorna null
                }
            }

            foreach (string encabezado in encabezados)
            {
                dataTable.Columns.Add(encabezado);
            }

            using (TextFieldParser parser = new TextFieldParser(rutaArchivo))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[] campos = parser.ReadFields();

                    dataTable.Rows.Add(campos);
                }
            }

            return dataTable;
        }

    }
}