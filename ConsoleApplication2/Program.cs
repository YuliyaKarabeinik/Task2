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

           string inputLine = "";
            int input;
            string line;
            string filename = "1.txt";
      
            do
            {
                Console.WriteLine("Please enter 1 to write line or enter 2 to read from file");
                inputLine = Console.ReadLine();
            }
            while (!int.TryParse(inputLine, out input));
            Print print = new Print();
            switch (input)
            {
                case 1:
                    Console.WriteLine("Please enter line");
                    line = Console.ReadLine();
                    print.Todo(line);
                  
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Reading from file..");
                    ReadFile readFile = new ReadFile();
                    line = readFile.ReadFromFile(filename);
                    Console.WriteLine($"File contents: {line}");
                    print.Todo(line);
                    Console.ReadKey();
                    break;

            }

        }
      
    }
}
