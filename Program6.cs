using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace Reflection
{
    class Configuration
    {
        private static string API_KEY = "InitialAPIKey";
    }

    class Program7
    {
        static void Main()
        {
            Type configType = typeof(Configuration);
            FieldInfo field = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            if (field != null)
            {
                field.SetValue(null, "NewAPIKey");
                Console.WriteLine($"Updated API_KEY: {field.GetValue(null)}");
            }
            else
            {
                Console.WriteLine("API_KEY field not found.");
            }
        }
    }

}
