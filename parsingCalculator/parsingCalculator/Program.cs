using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            int listlength = list.Count;
            var stripped = Regex.Replace(problem, "[^0-9]", "");
            int strippedInt = Int32.Parse(stripped); //converts the stripped variable to an integer value


            int numCount;
            int operCount;


        }
    }
}
