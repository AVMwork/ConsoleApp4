using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Student
    {
        public string Name { set; get; }
        public int Group { set; get; }
        public int Age { set; get; }

        public Student() { Name = ""; Group = 0; Age = 0; }
        public Student(string N, int G, int A) { Name = N; Group = G; Age = A; }

        public static Student[] CreateGroup() 
        {
            var masiv = new Student[9];
            masiv[0] = new Student("Виктория Гозда", 1, 25);
            masiv[1] = new Student("Валентина Сакаль", 2, 35);
            masiv[2] = new Student("Александр Мамай", 1, 45);
            masiv[3] = new Student("Роман Пожо", 3, 15);
            masiv[4] = new Student("Даниель Молнар", 3, 25);
            masiv[5] = new Student("Андрей Зозулич", 4, 35);
            masiv[6] = new Student("Инна Конар", 4, 45);
            masiv[7] = new Student("Михаил Цолиган", 2, 15);
            masiv[8] = new Student("Максим Миленевский", 4, 25);
            //masiv[9] = new Student("", "", 5);
            return masiv;
        }

    }

}