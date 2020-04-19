using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga_01_CSharp
{
    class Program
    {
        private static double x;
        static void Main(string[] args)
        {
            x = Convert.ToDouble(Console.ReadLine());
            int summ = ((int)(x * 10) % 10) * ((int)(x * 100) % 10);
            Console.WriteLine(summ);
            Console.ReadKey();
        }
    }
}
