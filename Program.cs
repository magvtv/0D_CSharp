using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Practice
{
    class Matatu
    {
        private string matatuSacco = "WALOKANA"; //field
        public string MatatuSacco //property
        {
            get { return matatuSacco; }
            set { matatuSacco = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matatu mat1 = new Matatu();
            mat1.matatSacco = "LANKANA";
            Console.WriteLine(mat1.MatatuSacco);         
        }
    }
}