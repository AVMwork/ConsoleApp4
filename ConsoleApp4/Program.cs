using System;
using System.IO;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student[] stud = new Student[9];
            stud = Student.CreateGroup();

            var massiv1 = new double[,] { { 2.5, 5.5, 6.6, 1.5, 1.7, 1.8, 4.2, 6.0 },{ 5.2, 5.5, 6.6, 5.1, 7.1, 8.1, 2.4, 0.6 } };
            var massiv2 = new int[,] { { 25, 55, 66, 15 }, { 17, 18, 42, 60 }, {71, 81, 24, 6 }, { 52, 15, 16, 51 } };

            int temp = 0;
            if (!File.Exists(@"D:\Temp\Day17.txt"))
            {                                           //File.Create(@"D:\Temp\Day17.txt");

                foreach (var x in stud)
                {
                    if (x.Name.Length > temp) temp = x.Name.Length;
                    File.AppendAllText(@"D:\Temp\Day17.txt", x.Name + "\t");
                    File.AppendAllText(@"D:\Temp\Day17.txt", x.Group.ToString() + "\t");
                    File.AppendAllText(@"D:\Temp\Day17.txt", x.Age.ToString() + "\t");
                }
                File.AppendAllText(@"D:\Temp\Day17.txt", Environment.NewLine);
                File.AppendAllText(@"D:\Temp\Day17.txt", (massiv1.GetUpperBound(0)+1).ToString() + "\t");
                File.AppendAllText(@"D:\Temp\Day17.txt", (massiv1.Length / (massiv1.GetUpperBound(0)+1)).ToString() + "\t");
                File.AppendAllText(@"D:\Temp\Day17.txt", Environment.NewLine);

                temp = 0;
                var colum = massiv1.Length / (massiv1.GetUpperBound(0)+1);

                foreach (var x in massiv1)
                {
                    File.AppendAllText(@"D:\Temp\Day17.txt", x.ToString("G", System.Globalization.CultureInfo.InvariantCulture) + "\t");
                    if (temp == colum-1) 
                    { 
                        File.AppendAllText(@"D:\Temp\Day17.txt", Environment.NewLine); 
                        temp = 0; 
                    }
                    temp++;
                }
                File.AppendAllText(@"D:\Temp\Day17.txt", Environment.NewLine);
                File.AppendAllText(@"D:\Temp\Day17.txt", (massiv2.GetUpperBound(0) + 1).ToString() + "\t");
                File.AppendAllText(@"D:\Temp\Day17.txt", (massiv2.Length / (massiv2.GetUpperBound(0) + 1)).ToString() + "\t");
                File.AppendAllText(@"D:\Temp\Day17.txt", Environment.NewLine);

                foreach (var x in massiv2)
                {
                    File.AppendAllText(@"D:\Temp\Day17.txt", x.ToString() + "\t");                    
                }

                File.AppendAllText(@"D:\Temp\Day17.txt", Environment.NewLine);
                File.AppendAllText(@"D:\Temp\Day17.txt", (DateTime.Now).ToString());
            }
            else Console.WriteLine("Такой файл уже существует");

            string[] data = new string[7];

            if (File.Exists(@"D:\Temp\Day17.txt"))
                data = File.ReadAllLines(@"D:\Temp\Day17.txt");
                //File.ReadAllText(@"D:\Temp\Day17.txt");
            else Console.WriteLine("Искомого файла не существует");

            //Console.WriteLine(data);

            var stud1 = new Student();
                        
            var strArr = data[0].Split('\t');
            var step = 0;

            for (int i=0;i<strArr.Count()-1;i++)
            {
                stud[step].Name = strArr[i];
                stud[step].Group = int.Parse(strArr[++i]);
                stud[step].Age = int.Parse(strArr[++i]);
                step++;              
            }

            //var v = stud.Max();
            //var v = stud1.Name.Length;

            //var quer = from n in stud
            //           where n.Name.Count()>25
            //           orderby n.Name.Count()
            //           select stud1; // new Student();

            //int v = stud.Count();
            //stud.Where(n =>n.Name.Length);

           // var datafile = new BinaryReader(File.OpenRead(@"C:\Temp\Day17.txt"));
            

           

            

            //data.Count();
            

        }
    }
    //https://github.com/Maxim23438/Lab_Task/blob/main/Task
    //https://www.nuget.org/
}
