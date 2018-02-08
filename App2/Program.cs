using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            string text;
            int amountInt, amountDigital;
            string listSting;
            Console.WriteLine("Please enter text and 'stop' to finish input");
            while ((text = Console.ReadLine() )!= "stop")
            {
                numbers.DefineType(text);
            }
            amountInt = numbers.AmountInt();
            Console.WriteLine($"Amount of integers= {amountInt}");
            amountDigital = numbers.AmountDigital();
            Console.WriteLine($"Amount of digital numbers= {amountDigital}");
            Console.WriteLine("List of integers with average value");
            numbers.IntAvr();
            Console.WriteLine("List of digital numbers with average value");
            numbers.DigitalAvr();

            listSting = numbers.StringElemIncrease();
            Console.WriteLine($"List of not numbers in ascending order\n { listSting}");
            Console.ReadKey();
        }
    }
}
