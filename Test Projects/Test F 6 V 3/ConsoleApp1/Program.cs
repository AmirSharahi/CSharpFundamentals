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
            //Array
            Console.WriteLine("enter array of numbers: ");
            var arrray = Console.ReadLine();
            var array = arrray.Split(' ');
            int[] finalArray = new int[array.Length];
            for (var index = 0; index < array.Length; index++)
            {
                finalArray[index] = Convert.ToInt32(array[index]);
            }

            //lenth
            Console.WriteLine("lenth is: " + finalArray.Length);

            //indexOf
            var indexx = Array.IndexOf(finalArray, 35);
            Console.WriteLine("number of index is: " + indexx);

            //clear
            Array.Clear(finalArray, 0, 2);
            Console.WriteLine("clear method: ");
            foreach (var VARIABLE in finalArray)
            {
                Console.Write(VARIABLE);
            }
            Console.WriteLine();

            //coppy
            var another = new int[3];
            Array.Copy(finalArray , another , 3);
            Console.WriteLine("coppy method: ");
            foreach (var VARIaABLE in another)
            {
                Console.Write(VARIaABLE);
            }
            Console.WriteLine();

            //sort
            Array.Sort(finalArray);
            Console.WriteLine("sort method: ");
            foreach (var VARIaaABLE in finalArray)
            {
                Console.Write(VARIaaABLE);
            }
            Console.WriteLine();

            //reverse
            Array.Reverse(finalArray);
            Console.WriteLine("reverse method: ");
            foreach (var VARIaaaABLE in finalArray)
            {
                Console.Write(VARIaaaABLE);
            }
            Console.WriteLine();
        }
    }
}
