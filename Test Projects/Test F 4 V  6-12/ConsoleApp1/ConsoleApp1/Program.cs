using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        //folder 4 video 10
        public enum shippingMethod
        {
            RegularAirMail = 1,
            RegistredAirMail = 25,
            Express = 3
        }
        static void Main(string[] args)
        {
            //folder 4 video 6
            /*var numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            var flags = new bool[4];
            flags[0] = true;
            flags[1] = false;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.WriteLine(flags[3]);
        
            var names = new string[3] {"ali" , "amir" , "hosein"};*/

            //folder 4 video 8
            /*var firsName = "amir";
            var lastName = "sharahi";
            var fullName = firsName + " " + lastName;
            var myFullName = string.Format("My Name is {0} {1}", firsName, lastName);

            var Names = new string[3] { "ali", "amir", "jiri" };
            var names = string.Join(",", Names);

            string text = @"inanm az text ba / va \ va enter
            cscs";
            Console.WriteLine(text);*/

            //folder 4 video 10
            /*var method = shippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 25;
            Console.WriteLine((shippingMethod)methodID);

            var methodName = "Express";
            var OneMethod = (shippingMethod)Enum.Parse(typeof(shippingMethod), methodName);
            Console.WriteLine((int)OneMethod);*/

            //folder 4 video 12
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0} b: {1}" , a , b));
            var array = new int[3] { 1, 2, 3 };
            var array1 = array;
            array1[0] = 0;
            Console.WriteLine(string.Format("array[0]: {0} array1[0]: {1}" , array[0] , array1[0]));
        }
    }
}
