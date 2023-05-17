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
            switch (Console.ReadLine())
            {
                case "1":
                    CreateFile();
                    break;
                case "2":
                    CreateFile2();
                    break;
                case "3":
                    CreateFile3();
                    break;
                default:
                    break;
            }
        }
        public static void CreateFile()
        {
            string path = "C:\\Users\\" + Environment.UserName + "\\Desktop\\file.txt";
            File.Create(path);
            Process.Start("notepad.exe", path);
        }
        public static void CreateFile2()
        {
            string path = "C:\\Users\\" + Environment.UserName + "\\Desktop\\file.txt";
            string text = Console.ReadLine();
            File.WriteAllText(path, text);
            Process.Start("notepad.exe", path);
        }
        public static void CreateFile3()
        {
            string directory = "C:\\Users\\" + Environment.UserName + "\\Desktop\\folder1\\folder2";
            Directory.CreateDirectory(directory);
            string path = directory + "\\text.txt";
            File.Create(path);
            Process.Start("notepad.exe", path);
        }
    }
}
