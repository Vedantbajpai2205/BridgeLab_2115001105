using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
namespace Annotation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class JsonFieldAttribute : Attribute
    {
        public string Name { get; }

        public JsonFieldAttribute(string name)
        {
            Name = name;
        }
    }

    public class User
    {
        [JsonField("user_name")]
        public string Username { get; set; }

        [JsonField("user_age")]
        public int Age { get; set; }

        [JsonField("user_email")]
        public string Email { get; set; }

        public string Address { get; set; }
    }

    public class JsonSerializer
    {
        public static string ConvertToJson(object obj)
        {
            var dict = new Dictionary<string, object>();
            var type = obj.GetType();

            foreach (var property in type.GetProperties())
            {
                var jsonFieldAttribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(property, typeof(JsonFieldAttribute));

                if (jsonFieldAttribute != null)
                {
                    dict[jsonFieldAttribute.Name] = property.GetValue(obj);
                }
                else
                {
                    dict[property.Name] = property.GetValue(obj);
                }
            }

            return JsonConvert.SerializeObject(dict);
        }
    }

    class Program11
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Username = "Yash",
                Age = 21,
                Email = "Yash123@gmail.com",
                Address = "GLA Mathura"
            };

            string json = JsonSerializer.ConvertToJson(user);
            Console.WriteLine(json);
        }
    }
}
