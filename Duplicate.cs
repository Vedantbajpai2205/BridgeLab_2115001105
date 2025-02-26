using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class Duplicate
    {
        static void Main(string[] args)
        {
            string filePath = "data.csv";
            Dictionary<string, List<string>> idRecords = new Dictionary<string, List<string>>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] columns = line.Split(',');

                        if (columns.Length > 0)
                        {
                            string id = columns[0];

                            if (!idRecords.ContainsKey(id))
                            {
                                idRecords[id] = new List<string>();
                            }

                            idRecords[id].Add(line);
                        }
                    }
                }

                foreach (var record in idRecords)
                {
                    if (record.Value.Count > 1)
                    {
                        Console.WriteLine("Duplicate Records for ID: " + record.Key);
                        foreach (var duplicate in record.Value)
                        {
                            Console.WriteLine(duplicate);
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

