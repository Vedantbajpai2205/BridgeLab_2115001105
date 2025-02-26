using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Json.Schema;
using Newtonsoft.Json.Schema;

namespace JSON
{
    class Program10
    {
        static void Main()
        {
            string schemaJson = @"
        {
            ""type"": ""object"",
            ""properties"": {
                ""email"": {
                    ""type"": ""string"",
                    ""format"": ""email""
                }
            },
            ""required"": [""email""]
        }";

            string jsonToValidate = @"
        {
            ""email"": ""example@domain.com""
        }";

            JObject jsonObject = JObject.Parse(jsonToValidate);
            JsonSchema schema = JsonSchema.Parse(schemaJson);
            bool isValid = schema.Validate(jsonObject).IsValid;

            Console.WriteLine(isValid);
        }
    }

}
