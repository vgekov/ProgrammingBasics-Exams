using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            #region Budget 100

            if (budget <= 100)
            {
                if (season == "Summer")
                {
                    budget = budget * 0.35;
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Cabrio - {0:f2}", budget);
                }
                else if (season == "Winter")
                {
                    budget = budget * 0.65;
                    Console.WriteLine("Economy class");
                    Console.WriteLine("Jeep - {0:f2}", budget);
                }
            }

            #endregion

            #region budget 100 500

            else if (budget > 100 && budget <= 500)
            {
                if (season == "Summer")
                {
                    budget = budget * 0.45;
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Cabrio - {0:f2}", budget);
                }
                else if (season == "Winter")
                {
                    budget = budget * 0.80;
                    Console.WriteLine("Compact class");
                    Console.WriteLine("Jeep - {0:f2}", budget);
                }

            }

            #endregion

            #region  over 500

            else if (budget > 500)
            {
                if (season == "Summer")
                {
                    budget = budget * 0.90;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:f2}", budget);
                }
                else if (season == "Winter")
                {
                    budget = budget * 0.90;
                    Console.WriteLine("Luxury class");
                    Console.WriteLine("Jeep - {0:f2}", budget);
                }

            }


            #endregion


        }
    }
}

