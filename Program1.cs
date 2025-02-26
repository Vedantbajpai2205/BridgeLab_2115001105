using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON
{
    public class Car
    {
        public string Name { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }

        public Car(string name, int model, string color)
        {
            Name = name;
            Model = model;
            Color = color;
        }
    }

    class Program1
    {
        static void Main()
        {
            var car = new Car("Scorpio", 2020, "Black");
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }

}
