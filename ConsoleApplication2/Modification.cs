using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Modification
    {

        public string ToLowerCase(string line)
        {

            return line.ToLower();
        }

        public string Rowset(string line)
        {
            string rowset;
            /* 
            разделяем на предложеня и удаляем пустые элем*/
            string[] separated=line.Split(new Char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            rowset= string.Join("\n", separated);
            return rowset;
        }

        public string TimeStamp(string line)
        {
            string textNow;
            string[] separated = line.Split(new Char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < separated.Length; i++)
            {
                string now = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss:fff");
                separated[i] = string.Format("{0} {1}", now, separated[i]);
            }
                 textNow = string.Join("\n", separated);
            return textNow;
        }
      

  
    }
}
