using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 12;
            if (hour > 0 && hour <12)
            {
                Console.WriteLine("it's Morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("it's Afternoon.");
            }
            else
            {
                Console.WriteLine("it's Evening.");
            }

            bool isGoldCostumer = true;
            var Price = (isGoldCostumer) ? 19.25f : 29.25f;
            Console.WriteLine(Price);

            var season = Season.Winter;
            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("it's a truble season");
                    break;
                case Season.Winter:
                    Console.WriteLine("it's the season that i love");
                    break;
            }
        }
    }
}
