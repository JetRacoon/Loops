using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                Console.Write(num % 10);
                num /= 10;

            }
            Console.WriteLine();
        }
    }
}
