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
            var now = DateTime.Now;

            now.AddDays(1); //tomrrow
            now.AddDays(-1); //yesterday

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yy-mm-dd"));

            //video dovom

            //time span to hatman bebin
        }
    }
}
