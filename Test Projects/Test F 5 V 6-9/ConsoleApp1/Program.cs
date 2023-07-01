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
            //folder 5 video 6
            /*for (int i = 1; i <= 10; i++)
            {
                if ( i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            //folder 5 video 7
            /*var Name = "amir ali";
            for (int i = 0; i < Name.Length; i++)
            {
                Console.WriteLine(Name[i]);
            }

            foreach (var Char in Name)
            {
                Console.WriteLine(Char);
            }

            var haji = new int[3] {1 , 2 , 3};
            foreach (var Number in haji)
            {
                Console.WriteLine(Number);
            }*/

            //folder 5 video 8
            /*while (true)
            {
                Console.Write("what is your name? ");
                var Name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(Name))
                    break;
                Console.WriteLine("your name is: " + Name);
            }

            //code bala be do joor neveshteh mishe
            while (true)
            {
                Console.Write("what is your name? ");
                var Name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine("your name is: " + Name);
                    continue;
                }

                break;
            }*/


            //folder 5 video 9
            /*var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97 , 122));
                //dovomin model
                Console.Write((char)('a' + random.Next(0, 26)));
            }
            Console.WriteLine();

            //code behtar
            const int passwordLenth = 10;
            char[] buffer = new char[passwordLenth];
            for (int i = 0; i < passwordLenth; i++)
            {
                buffer[i] = (char)random.Next(97, 122);
            }
            var password = new string(buffer);
            Console.WriteLine(password);*/
        }
    }
}
