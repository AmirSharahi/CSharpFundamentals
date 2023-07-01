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
            var number = new List<int>() { 1, 2, 3, 4 };
            number.Add(1);
            number.AddRange(new int[3] { 5, 6, 7 });
            foreach (var VARIABLE in number)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.WriteLine();
            Console.WriteLine("Firs Index Of 1: " + number.IndexOf(1));
            Console.WriteLine("Last Index Of 1: "  + number.LastIndexOf(1));
            Console.WriteLine();
            Console.WriteLine("count method: " + number.Count);

            //removing things from list
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == 1)
                {
                    number.Remove(number[i]);
                }                
            }
            Console.WriteLine();
            Console.WriteLine("Remove Method: ");
            foreach (var VARIABLE in number)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine();
            number.Clear();
            Console.WriteLine("Clear Method:(Using Count) " + number.Count);

        }
    }
}
