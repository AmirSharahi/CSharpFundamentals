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

            // password migire tedade charackterasho mishmore ke beine ye renje khas bashan
            while (true)
            {
                Console.WriteLine("enter a password(contai between 9 to 18 charackters): ");
                Console.WriteLine();
                var password = Console.ReadLine();
                var numberOfChars = password.Length;
                if (numberOfChars < 9)
                {
                    Console.WriteLine("password is too short");
                    Console.WriteLine();
                }
                else if (numberOfChars > 18)
                {
                    Console.WriteLine("password is too long");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("great job");
                    break;
                }
            }
        }
    }
}
