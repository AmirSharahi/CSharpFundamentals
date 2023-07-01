using System;

namespace ConsoleApp1
{
    public class person
    {
        public string Fname;
        public string Lname;

        public void introduce()
        {
            Console.WriteLine("my name is " + Fname + " " + Lname);
        }
    }
}