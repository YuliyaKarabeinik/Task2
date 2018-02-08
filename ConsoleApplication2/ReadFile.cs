using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ReadFile
    {
        
        
        public string ReadFromFile(string filename)
        {
            string fileStr = "";
            using (StreamReader sr = new StreamReader(filename))
                fileStr = sr.ReadLine();
            return fileStr;
        }
    }
}
