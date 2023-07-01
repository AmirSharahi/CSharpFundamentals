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
            Calculator(out var addadeNahaiee, out var inputMain, out var input2);
        }

        private static void Calculator(out List<int> addadeNahaiee, out int inputMain, out string input2)
        {
            addadeNahaiee = new List<int>();
            Console.WriteLine("meghdar ra vared konid");
            inputMain = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("che balaiee saresh biaram?");
                input2 = Console.ReadLine();
                if (input2 == "*")
                {
                    Console.WriteLine("meghdar ra vared konid");
                    var input = Convert.ToInt32(Console.ReadLine());
                    inputMain *= input;
                }
                else if (input2 == "+")
                {
                    Console.WriteLine("meghdar ra vared konid");
                    var input = Convert.ToInt32(Console.ReadLine());
                    inputMain += input;
                }
                else if (input2 == "/")
                {
                    Console.WriteLine("meghdar ra vared konid");
                    var input = Convert.ToInt32(Console.ReadLine());
                    inputMain /= input;
                }
                else if (input2 == "-")
                {
                    Console.WriteLine("meghdar ra vared konid");
                    var input = Convert.ToInt32(Console.ReadLine());
                    inputMain -= input;
                }
                else if (input2 == "=")
                {
                    Console.WriteLine(inputMain);
                    break;
                }
                else
                {
                    Console.WriteLine("yechi dorost vared kon bache");
                }
            }
        }
    }
}
