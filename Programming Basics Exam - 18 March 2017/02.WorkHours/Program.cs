using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double workHours = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());
            double workDays = double.Parse(Console.ReadLine());

            double works = (workers * workDays * 8) - workHours;


            if (works > 0)
            {
                Console.WriteLine("{0} hours left", works);
            }
            else
            {

                double penalties = works * workDays;
                Console.WriteLine("{0} overtime", Math.Abs(works));
                Console.WriteLine("Penalties: {0}", Math.Abs(penalties));

            }

        }
    }
}
