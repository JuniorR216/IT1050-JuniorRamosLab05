using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosJuniorLab05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 2
            //int speedlimit = 35;
            //int speed = 42;
            //    if (speed > speedlimit)
            //{
            //    Console.WriteLine("SLOW NOW");
            //}

            //Question 3
            //int istrue = 10;
            //if (istrue <= 50)
            //{
            //    Console.WriteLine("It is True");
            //}
            //else 
            //{
            //    Console.WriteLine("It is False");
            //}

            //Question 4
            //{
            //    Console.WriteLine("Input temperature in Fahrenheit: ");
            //}
            //double fahrenheit = Convert.ToDouble(Console.ReadLine());
            //{
            //    Console.WriteLine();
            //}
            //double Celsius = (fahrenheit - 32d) * 5d / 9d;
            //{
            //    Console.WriteLine("Temperature in Celsius is {0}: ", Celsius);
            //}
            //{
            //    Console.ReadLine();
            //}
            //if (fahrenheit >= 90)
            //{
            //    Console.WriteLine("It is hot");
            //}
            //if (fahrenheit <= 40)
            //{
            //    Console.WriteLine("It is cold");
            //}

            //Question 5
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine("Value:");
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Question 6
            int a = 60;
            while (a >= 20)
            {
                Console.Write("Value: ");
                Console.WriteLine(a);
                a--;
            }
        }
    }
}
