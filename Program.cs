using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Practice
{
    class Person
    {
        private string fullName = "John Doe"; //field
        public string Name //property
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person man1 = new Person();
            man1.Name = "Nicholas Cage";
            Console.WriteLine(man1.Name);         
        }
    }
}