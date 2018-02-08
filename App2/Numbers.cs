using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Numbers
    {
        public List<int> IntElem = new List<int>();
        public List<double> DigitalElem = new List<double>();
        public List<string> StringElem = new List<string>();
        int a;
        double b;


        public void DefineType(string text)
        {

            if (int.TryParse(text, out a))
            {
                IntElem.Add(a);
            }
            if (double.TryParse(text, out b))
            {
                DigitalElem.Add(b);
            }
            else
            {
                StringElem.Add(text);
            }
        }
        public int AmountInt()
        {
            return IntElem.Count;
        }
        public int AmountDigital()
        {
            return DigitalElem.Count;
        }


        private static void Print(string s)
        {
            Console.WriteLine(s.PadLeft(80));
        }

        public void IntAvr()
        {
            double avr;
            string elem;
            if (IntElem.Count > 1)
            {
                avr = IntElem.Average();
            }
            else avr = 0;
            List<string> output = new List<string>();
            foreach (int i in IntElem)
            {
                elem = i.ToString();
                output.Add(elem);
            }
            output.Add(avr.ToString());

            output.ForEach(Print);
        }


        private static void PrintDigital(double d)
        {
            Console.WriteLine(string.Format("{0:0.00}", d).PadLeft(80));
        }

        public void DigitalAvr()
        {
            double avr;

            if (DigitalElem.Count > 1)
            {
                avr = DigitalElem.Average();
            }
            else avr = 0;

            DigitalElem.Add(avr);

            DigitalElem.ForEach(PrintDigital);
        }
        public string StringElemIncrease()
        {

            string output = string.Join("\n", StringElem.OrderBy(xX => xX.Length).ThenBy(xX => xX));
            return output;
        }

    }

}


