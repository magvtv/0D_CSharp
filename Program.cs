using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Learning
{
    class Timepiece
    {
        public string model, type, price;

        // Learning constructors
        public Timepiece(string modelName, string typeName, string priceTag)
        {
            model = modelName;
            type = typeName;
            price = priceTag;
        }

        // public void watchSummary()
        // {
        //     Console.WriteLine("Watch Summary:");
        //     Console.WriteLine($"{model}, {type}, {price}");
        // }

        static void Main(string[] args)
        {
            Timepiece TAGHeuer = new Timepiece("Carrera", "Chronograph", "USD $4,500");
            Timepiece Seiko = new Timepiece("SARB033", "Quartz", "USD $43,090");
            Timepiece Citizen = new Timepiece("Eco-Drive Promaster Diver", "Solar-Powered Quartz", "USD $1,825");
            Timepiece AppleWatch = new Timepiece("Series 6", "Digital", "USD $10,220");
            Timepiece Hamilton = new Timepiece("Khaki", "Field", "USD $673");

            Console.WriteLine(AppleWatch.model);

            // Patek.watchSummary();
        }
    }
}