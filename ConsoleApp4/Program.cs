using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            if (input == "1")
            {
                CreateFile();
            }
            else if ( input == "2")
            {
                CreateFile2();
            }
            else if (input == "3")
            {
                CreateFile3();
            }
            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        CreateFile();
            //        break;
            //    case "2":
            //        CreateFile2();
            //        break;
            //    case "3":
            //        CreateFile3();
            //        break;
            //    default:
            //        break;
            //}
        }
        public static void CreateFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt";
            File.Create(path);
            Process.Start("notepad.exe", path);
        }
        public static void CreateFile2()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\file.txt";
            string text = Console.ReadLine();
            File.WriteAllText(path, text);
            Process.Start("notepad.exe", path);
        }
        public static void CreateFile3()
        {
            string path = "\\text.txt";
            string fullpath = Path.GetFullPath(path);
            if (File.Exists(fullpath))
            {
                if (File.ReadAllText(fullpath) == fullpath)
                {
                    Console.WriteLine("fail on");
                }
                else
                {
                    File.WriteAllText(fullpath, fullpath);
                }
            }
            else
            {
                File.Create(fullpath);
            }
            Process.Start("notepad.exe", path);
        }
    }
}
