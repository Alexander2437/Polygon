using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Aleksandr";
            byte Age = 36;
            bool Pet = false;
            double ShoeSize = 41.5;

            /*Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My age is {Age}.");
            Console.WriteLine($"Do I have a pet? {Pet}.");
            Console.WriteLine($"My shoe size is {ShoeSize}.");*/

            Console.WriteLine($"My name is " + Name);
            Console.WriteLine($"My age is " + Age);
            Console.WriteLine($"Do I have a pet? " + Pet);
            Console.WriteLine($"My shoe size is " + ShoeSize);

            Console.ReadKey();
        }
    }
}