using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testgit
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 2 * Math.Cos(x);
            Console.WriteLine(F);
            Console.ReadKey();

        }
    }
}
