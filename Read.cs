using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    class Read
    {
        static void Main(string[] args)
        {
            string filePath = "largefile.csv";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int lineCount = 0;
                    int recordsProcessed = 0;

                    while (!reader.EndOfStream)
                    {
                        for (int i = 0; i < 100 && !reader.EndOfStream; i++)
                        {
                            string line = reader.ReadLine();
                            lineCount++;

                            recordsProcessed++;
                        }

                        Console.WriteLine($"Processed {recordsProcessed} records");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
