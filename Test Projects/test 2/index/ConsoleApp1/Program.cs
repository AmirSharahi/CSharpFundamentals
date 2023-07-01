using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            person ali = new person();
            ali.Fname = "ali";
            ali.Lname = "hasani";
            ali.introduce();
            calculator add = new calculator();
            var result= add.Ezaf(12 , 8);
            Console.WriteLine(result);
        }
    }
}
