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
            //Video 3
            /*var path = @"c:\somefile.jpg";
            File.Copy(path , @"d:\temp\myfile.jpg" , true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //Do Something
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(content);
            fileInfo.CopyTo(@"c:\somefile.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //Do Something Else
            }*/

            //Video 4
            /*Directory.CreateDirectory(@"c\new folder");
            
            var files = Directory.GetFiles(@"E:\جلسات", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directorys= Directory.GetDirectories(@"E:\جلسات", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directorys)
                Console.WriteLine(directory);

            Directory.Exists("path");


            var directoryInfo = new DirectoryInfo("path");
            directoryInfo.GetDirectories();
            directoryInfo.GetFiles();*/

            //Video 5
            /*var path = @"C:\somefile.jpg";
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));*/
        }
    }
}
