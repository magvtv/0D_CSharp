using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Data/Nairobi-Events-1.jsonl";
            List <string> lines = File.ReadAllLines(filePath).ToList();
            foreach(string line in lines)
            {
                dynamic eventData = JsonConvert.DeserializeObject<dynamic>(line);
                string title = eventData.title;
                DateTime start = DateTime.Parse((string)eventData.start);
                DateTime end = DateTime.Parse((string)eventData.end);
                string category = eventData.category;
                string location = eventData.location.ToString();
                string description = eventData.description;

                
                DisplayEvent(title, category, start, end, location, description);
            }
        }

        static void DisplayEvent(string title, string category, DateTime start, DateTime end, string location, string description)
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Start Date: {start}");
            Console.WriteLine($"End Date: {end}");
            Console.WriteLine($"Location: {location}");
            Console.WriteLine($"Details: {description}");
            
        }
    }
}