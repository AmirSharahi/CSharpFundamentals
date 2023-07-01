using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exersice 1
            /*Console.WriteLine("Enter Numbers: ");
            var adad = Console.ReadLine();
            var list = new List<int>();
            foreach (var VARIABLE in adad.Split(' '))
            {
                list.Add(Convert.ToInt32(VARIABLE));
            }
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i-1]+1)
                {
                    Console.WriteLine("ziad mishe");
                    break;
                }
                if (list[i] == list[i - 1] - 1)
                {
                    Console.WriteLine("kam mishe");
                    break;
                }
                if (list[i] != list[i - 1] + 1)
                {
                    Console.WriteLine("dobare test kon");
                    break;
                }
            }*/


            //Exersice 2
            /*Console.WriteLine("Enter Numbers: ");
            var list = new List<int>();
            while (true)
            {
                var adad = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(adad))
                {
                    foreach (var VARIABLE in list)
                    {
                        Console.WriteLine(VARIABLE);
                    }
                    break;
                }
                if (list.Contains(Convert.ToInt32(adad)))
                {
                    Console.WriteLine("Duplicate");
                    list.Remove(Convert.ToInt32(adad));
                }
                list.Add(Convert.ToInt32(adad));
            }*/

            //Exersice 3
            /*try
            {
                Console.WriteLine("Enter Time:");
                var time = Console.ReadLine().Split(':');
                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);
                if (hour>=0 && hour<=23 && minute<=59 && minute>=0)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("bazam ready");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ready");
            }*/

            //Exersice 4
            /*Console.WriteLine("Enter Variable Names: ");
            var Name = Console.ReadLine().Split(' ');
            var variable = new List<string>();
            foreach (var Word in Name)
            {
                Word.ToLower();
                var upper = Word[0].ToString().ToUpper();
                var wword = Word.Replace(Word[0].ToString() , upper);
                variable.Add(wword);
                Console.WriteLine(Word[0]);
            }
            Console.WriteLine(string.Join("", variable));*/

            //Exersice 5
            /*var NumberOfVowels = 0;
            var vowels = new[] {'a' , 'e' , 'o' , 'u' , 'i'};
            Console.WriteLine("Enter The Word:");
            var word = Console.ReadLine().ToCharArray();
            foreach (var Word in word)
            {
                if (vowels.Contains(Word))
                {
                    NumberOfVowels++;
                }
            }
            Console.WriteLine(NumberOfVowels);*/
        }
    }
}