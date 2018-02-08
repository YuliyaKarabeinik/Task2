using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] array=new array[256];
Console.WriteLine("Please enter strings. Enter 'stop' to finish input");
			int i=0;
			
			while (array[i]!="stop")
            do {
                array[i]=Console.ReadLine();
               i++;
            };
            

            switch (input)
            {
                case 1:
                    Console.WriteLine("Please enter line");
                    line = Console.ReadLine();
					mod = new Modification();
					lowerCase=mod.ToLowerCase(line);
                    break;
                case 2:
                    Console.WriteLine("Reading from file..");
                    ReadFile readFile = new ReadFile();
                   line=readFile.ReadFromFile(filename);
                    break;
            }

            //    public int inputNumber()
            //{
            //    string s;

            //    int numb = 0;
            //    s = Console.ReadLine();

            //    try
            //    {
            //        numb = Convert.ToInt32(s);

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Error!Bad Format");

            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Error!Overflow");
            //    }

            //    return numb;
            //}
            Console.ReadLine();
        }
    }
}
