using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Папка";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги:");
                string[] directory = Directory.GetDirectories(path);
                foreach (string d in directory)
                {
                    Console.WriteLine(d);
                    Console.WriteLine();
                    Console.WriteLine("Файлы подкаталога {0}:", d);
                    string[] files = Directory.GetFiles(d);
                    foreach (string f in files)
                    {
                        Console.WriteLine(f);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files1 = Directory.GetFiles(path);
                foreach (string f in files1)
                {
                    Console.WriteLine(f);
                }
                Console.ReadKey();

            }
        }
    }
}
