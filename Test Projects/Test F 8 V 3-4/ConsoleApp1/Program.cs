using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Video 3
            /*var FullName = "Amir Sharahi ";
            Console.WriteLine(FullName.Trim().ToUpper());
            
            var index = FullName.IndexOf(' ');
            var FirstName = FullName.Substring(0, index);
            var LastName = FullName.Substring(index + 1);
            
            var Name = FullName.Split(' ');
            FirstName = Name[0];
            LastName = Name[1];

            FullName.Replace("Sharahi", "Jiriaiee");

            if (string.IsNullOrWhiteSpace(FullName))
                Console.WriteLine("shifir shifir in forward");

            var perice = "85.12";
            Convert.ToByte(perice);

            var price = 12.85f;
            price.ToString("c");*/

            //Video 04
            string senetence = "this is gonna be a really really really really really long text";

            var summary = stringUtility.SummarizeText(senetence , 20);
            Console.WriteLine(summary);


            //tarfande doostemon ke fronte
            //const int maxLenth = 20;
            //var i = senetence.IndexOf(" " , maxLenth);
            //if (senetence.Substring(maxLenth) == " ")
            //{
            //    Console.WriteLine(senetence.Substring(0, maxLenth) + "...");
            //}
            //else
            //{
            //    Console.WriteLine(senetence.Substring(0, i) + "...");
            //}
        }
    }
}
