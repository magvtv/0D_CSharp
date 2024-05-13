using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Practice;

namespace Practice
{
    class SmartDevice
    {
        public void deviceType()
        {
            Console.WriteLine("Smart device can ewpresent anything");
        }
    }

    class SmartPhone : SmartDevice
    {
        public void deviceType()
        {
            Console.WriteLine("This is a Samsung S24 Ultra");
        }
    }

    class SmartTV : SmartDevice
    {
        public void deviceType()
        {
            Console.WriteLine("This is a Hisense 48 inch screen");
            
        }
    }

    class SmartWatch : SmartDevice
    {
        public void deviceType()
        {
            Console.WriteLine("This is an Apple Watch Series 6");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        SmartDevice device1 = new SmartDevice();
        SmartPhone device2 = new SmartPhone();
        SmartTV device3 = new SmartTV();
        SmartWatch device4 = new SmartWatch();

        device1.deviceType();

        }
    }
}