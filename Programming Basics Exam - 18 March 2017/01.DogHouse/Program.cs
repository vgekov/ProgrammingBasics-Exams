using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GreenPaint 
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double twoSides = a * (a / 2) * 2;
            double square = (a / 2) * (a / 2);
            double triange = (a / 2 * (b - a / 2)) / 2;
            double backWall = square + triange;
            double entry = (a / 5) * (a / 5);
            double fronWall = backWall - entry;
            double wallArea = twoSides + backWall + fronWall;
            double greenPaint = wallArea / 3;
            Console.WriteLine("{0:f2}", greenPaint);


            #endregion



            #region RedPaint
            double roof = a * (a / 2) * 2;
            double redPaint = roof / 5;
            Console.WriteLine("{0:f2}", redPaint);


            #endregion

        }
    }
}
