using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Convert(1234, 20);
            Console.WriteLine(result);
        }
         static string Convert (int value, int systemNumber)
        {
            int remainder;
            string line;
            char symbol = 'A';
            if(value==0)
            {
                line = "0";
            }
            else
            {
                line = string.Empty;
            }
            while(value>0)
            {
                remainder = value % systemNumber;
                if (remainder >= 10)
                {
                    symbol = (char)(remainder % 10 + 'A');
                    line = symbol + line;
                    value = value / systemNumber;
                    continue;
                }
                line = remainder + line;
                value = value / systemNumber;
            }
            return line;
        }
    }
}
