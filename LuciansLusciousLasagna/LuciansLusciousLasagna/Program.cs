using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciansLusciousLasagna
{
    class Program
    {
        static void Main(string[] args)
        {
            Lasagna lasagna = new Lasagna();

            Console.WriteLine(lasagna.ExpectedMinutesInOven());
            
            Console.WriteLine(lasagna.RemainingMinutesInOven(25));

            Console.WriteLine(lasagna.PreparationTimeInMinutes(1));
            Console.WriteLine(lasagna.PreparationTimeInMinutes(4));

            Console.WriteLine(lasagna.ElapsedTimeInMinutes(1, 30));
            Console.WriteLine(lasagna.ElapsedTimeInMinutes(4, 8));
            Console.ReadKey();
        }
    }
}
