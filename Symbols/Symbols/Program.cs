using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "12331233";
            int maxNumberOfAle = 0;
            char? symbol = null;
            int count=0;

            foreach ( var item in line)
            {
                
                if ( symbol == item )
                {
                    count = 1;
                }
                 else
                 {
                    count++;
                 }
                if ( count > maxNumberOfAle)
                {
                    maxNumberOfAle = count;
                }
                symbol = item;
            }
            Console.WriteLine( maxNumberOfAle);
        }
    }
}
