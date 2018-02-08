using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Print
    {
        string lowerCase;
        string rowset;
        string dateTime;
        Modification mod = new Modification();
        public void Todo(string line)
        {
            lowerCase = mod.ToLowerCase(line);
            Console.WriteLine($"To lower case: {lowerCase}");
            rowset = mod.Rowset(line);
            Console.WriteLine($"Rowset:\n {rowset}");
            dateTime = mod.TimeStamp(line);
            Console.WriteLine($"Text with date and time:\n {dateTime}");
        }
    }
}
