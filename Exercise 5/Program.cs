using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exersice 1
            /*var path = @"C:\Users\A.Sharahi\Desktop\Text.txt";
            var text = File.ReadAllText(path).Split(' ');
            Console.WriteLine(text.Length);*/

            //Exersice 2
            /*var path = @"C:\Users\A.Sharahi\Desktop\Text.txt";
            var text = File.ReadAllText(path).Split(' ');
            var longestWord = text[0];
            foreach (var Word in text)
            {
                if (longestWord.Length < Word.Length)
                {
                    longestWord = Word;
                }
            }
            Console.WriteLine(longestWord);*/
        }
    }
}
