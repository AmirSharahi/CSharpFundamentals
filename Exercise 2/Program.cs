using System;
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
            //Exercise 1
            /*var aadadeBakhshPazir = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    aadadeBakhshPazir++;
                }
            }
            Console.WriteLine(aadadeBakhshPazir);*/

            //Exercise 2
            /*var jam = 0;
            while (true)
            {
                var adadeJadid = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(adadeJadid))
                {
                    Console.WriteLine("Jame Adade Ghabli: ");
                    Console.WriteLine(jam);
                    break;
                }
                jam += Convert.ToInt32(adadeJadid);
            }*/

            //Exercise 3
            /*var addad = Convert.ToInt32(Console.ReadLine());
            var main = 1;
            while (addad > 0)
            {
                main = main * addad;
                addad--;
            }
            Console.WriteLine(main);*/

            //Exercise 4
            /*var random = new Random();
            var adadeRandom = random.Next(1, 10);
            Console.WriteLine("guss the number: ");
            for (int i = 0; i < 4; i++)
            {
                var adadeEntekhabi =  Convert.ToInt32(Console.ReadLine());
                if (adadeRandom == adadeEntekhabi)
                {
                    Console.WriteLine("YOU WON!");
                    break;
                }
                else if (i < 3)
                {
                    Console.WriteLine("GUSS AGAIN!");
                }
                else
                {
                    Console.WriteLine("YOU LOST");
                }
            }*/

            //Exercise 5
            /*Console.WriteLine("Enter Your Numbers And Spreate Them With Space:");
            var input = Console.ReadLine();
            var aadad = input.Split(' ');
            var max = Convert.ToInt32(aadad[0]);
            foreach (var adad in aadad)
            {
                var addad = Convert.ToInt32(adad);
                if (addad > max)
                {
                    max = addad;
                }
            }
            Console.WriteLine("max number is: " + max);*/
        }
    }
}
