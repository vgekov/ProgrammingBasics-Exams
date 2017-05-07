using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < (4 * n -2) ; i++)
            {
                Console.Write(new string('.', 5 * n));
                Console.Write("#");
                Console.Write(new string('.', 5 * n));
                Console.WriteLine();
            }
        }
    }
}
