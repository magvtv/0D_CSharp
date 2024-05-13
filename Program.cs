using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;

namespace Learning
{
    // class Smartphone
    // {
    //     public string Brand { get; set; }
    //     public string Model { get; set; }
    //     public decimal Price { get; set; }

    //     // constructor to init the field properties
    //     public Smartphone(string brand, string model, decimal price)
    //     {
    //             Brand = brand;
    //             Model = model;
    //             Price = price;
    //     }

    //     public void phoneSummary()
    //     {
    //         return $"Phone: {brand}\nModel: {model}\nPrice in KES: {price}";
    //     }
    // }

    // class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Console.Write("Enter brand: ");
    //         string brand = Console.ReadLine();

    //         Console.Write("Enter model: ");
    //         string model = Console.ReadLine();

    //         Console.Write("Enter price (KES): ");
    //         decimal price;
    //         while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
    //         {
    //             Console.WriteLine("Price should not be less than zero!");
    //             Console.Write("Enter price (KES): ");
    //         }



    //         Smartphone smartphone = new Smartphone(brand, model, price);
    //         string filePath = "Data/phones.txt";

    //         using (StreamWriter writer = File.AppendText(filePath))
    //         {
    //             writer.WriteLine(smartphone.ToString());
    //         }

    //         smartphone.phoneSummary();
    //         Console.WriteLine("Device saved to data folder!");
    //     }
    // }

    class Dog
    {
        public void dogSummary(string dogName, string breed, int age)
        {
            Console.WriteLine($"Dog Details\nName: {dogName} \nBreed: {breed}\nAge: {age}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            List<string> employees = new List<string> () {
                "Dwayne",
                "Tasha",
                "Yogira",
                "Laorea",
            };
        
            Console.WriteLine(employees);

            // string readText = File.ReadAllText("spotify.txt");
            // Console.WriteLine(readText);
            // File.Delete("spotify.txt");
            // int[] numList = { 32, 43, 5, 3, 93, 85, 12 };
            // int maxNum, minNum; 
            // maxNum = numList[0];
            // minNum = numList[0];
            // for (int x = 0; x < numList.Length; x++)
            // {
            //     if (numList[x] > maxNum)
            //     {
            //         maxNum = numList[x];
            //     }
            //     else if (numList[x] < minNum)
            //     {
            //         minNum = numList[x];
            //     }
            // }
            // Console.WriteLine($"Largest number is {maxNum} the smallest being {minNum}");
            // int[][] weirdArray = new int[2][];
            // weirdArray[0] = new int[] { 1, 3, 5 };
            // weirdArray[1] = new int[] { 2, 4, 6 };
            // Console.WriteLine(weirdArray[1][1]);
        }
    }
    
}