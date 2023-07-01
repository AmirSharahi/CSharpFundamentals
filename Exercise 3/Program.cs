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
            /*var list = new List<string>();
            string input = "";
            while (true)
            {
                list.Add(input);
                input = Console.ReadLine();

                if (input == "")
                {
                    list.Remove("");
                    break;
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Nobody Likes You");
            }
            else if (list.Count == 1)
            {
                Console.WriteLine("{0} likes your post", list[0]);
            }
            else if (list.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post" , list[0] , list[1]);
            }
            else
            {
                var others = list.Count - 2;
                Console.WriteLine("{0} and {1} and {2} others like your post" , list[0] , list[1] ,others);
            }*/

            //Exercise 2
            /*Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
            //balaia javabe moshe

            var name = Console.ReadLine();
            var nameLenth = name.Length;
            var chhar = new Char[name.Length];
            for (int i = 0; i < name.Length && nameLenth > 0;i++)
            {
                nameLenth--;
                chhar[nameLenth] = name[i];
            }
            var reversed = new string(chhar);
            Console.WriteLine(reversed);*/

            //Exercise 3
            /*var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("hajiiiiiiiiiii");
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            Console.WriteLine();
            Console.Write("Sorted: ");
            foreach (var VARIABLE in numbers)
            {
                Console.Write(VARIABLE + ",");
            }*/

            //Exercise 4
            /*var numbers = new List<int>();
                Console.WriteLine("enter a number or Quit: ");
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            var forshow = new List<int>();
            foreach (var VARIABLE in numbers)
            {
                if (!forshow.Contains(VARIABLE))
                {
                    forshow.Add(VARIABLE);
                }
            }
            Console.WriteLine("uniq numbers: ");
            foreach (var VARIABLeE in forshow)
            {
                Console.Write(VARIABLeE + "-");
            }
            Console.WriteLine();*/

            //Exercise 5
            /*Console.WriteLine("enter comma seperated numbers: ");
            while (true)
            {
                var arrray = Console.ReadLine().Split(',');
                if (arrray.Length < 5)
                {
                    Console.WriteLine("ridi golam");
                    continue;
                }
                else
                {
                    var array = new int[arrray.Length];
                    for (int i = 0; i < arrray.Length; i++)
                    {
                        array[i] = Convert.ToInt32(arrray[i]);
                    }
                    Array.Sort(array);
                    var aray = new int[3];
                    Array.Copy(array , aray , 3);
                    foreach (var VARIABLE in aray)
                    {
                        Console.Write(VARIABLE + "-");
                    }
                    break;
                }
            }*/
        }
    }
}
