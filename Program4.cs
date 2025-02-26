using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSON
{
    class Program4
    {
        static void Main()
        {
            string jsonSchema = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'age': { 'type': 'integer' },
                'email': { 'type': 'string' }
            },
            'required': ['name', 'email']
        }";

            JSchema schema = JSchema.Parse(jsonSchema);

            string json = @"{
            'name': 'John Doe',
            'age': 30,
            'email': 'john.doe@example.com'
        }";

            JObject jsonObject = JObject.Parse(json);

            bool isValid = jsonObject.IsValid(schema, out IList<string> validationErrors);

            if (isValid)
            {
                Console.WriteLine("The JSON is valid.");
            }
            else
            {
                Console.WriteLine("The JSON is invalid. Errors:");
                foreach (var error in validationErrors)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}
