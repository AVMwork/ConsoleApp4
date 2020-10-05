using System;
using System.IO;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!File.Exists(@"C:\Temp\Day17.txt"))
                File.Create(@"C:\Temp\Day17.txt");
            else Console.WriteLine("Такой файл уже существует");

            var datafile = new BinaryReader(File.OpenRead(@"C:\Temp\Day17.txt"));
            string data = "";

            if (File.Exists(@"C:\Temp\Day17.txt"))
                data = File.ReadAllText(@"C:\Temp\Day17.txt");
            else Console.WriteLine("Искомого файла не существует");

            Console.WriteLine(data);

            data.Count();

            var quer = from n in data 
                       where n!='0'
                       select n;
        }
    }
    //https://github.com/Maxim23438/Lab_Task/blob/main/Task
    //https://www.nuget.org/
}
