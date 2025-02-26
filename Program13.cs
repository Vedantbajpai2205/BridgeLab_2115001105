using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;

namespace JSON
{
    class Program13
    {
        static void Main()
        {
            string csvFilePath = "path_to_your_csv_file.csv";

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<dynamic>();
                var json = JsonConvert.SerializeObject(records, Formatting.Indented);

                Console.WriteLine(json);
            }
        }
    }

}
