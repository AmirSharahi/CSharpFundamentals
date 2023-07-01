using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var Number = 1;
            Increament(Number);
            Console.WriteLine(Number);

            var person = new Person() {age = 20};
            MakeOld(person);
            Console.WriteLine(person.age);
        }
        public static void Increament(int Number)
        {
            Number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.age += 10;
        }

    }
}
