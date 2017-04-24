using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a problem.");
            String problem = Console.ReadLine();
            int length = problem.Length;
            int ii = 1;
            List<int> list = new List<int>();
            while(ii < length)
            {
                char iichar = problem[ii];
                if(char.IsDigit(iichar) == true)
                {
                    ii++;
                }
                else
                {
                    list.Add(ii);
                    ii++;
                }

            }
            Console.WriteLine(list.Count);
            Console.ReadLine();

        }
    }
}
