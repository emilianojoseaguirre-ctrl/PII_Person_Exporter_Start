using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Globalization;

namespace Ucu.Poo.PersonExporter
{
    public class CsvExporter : IExporter
    {
        public void Export(IList<Person> people, string outputPath)
        {


            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            using (StreamWriter writer = new StreamWriter(outputPath, false, Encoding.UTF8))
            {
                using (CsvWriter csv = new CsvWriter(writer, config))
                {
                    csv.WriteHeader<Person>();
                    csv.NextRecord();
                    csv.WriteRecords(people);
                }
            }
        }
    }
}