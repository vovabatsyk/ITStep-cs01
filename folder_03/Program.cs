using System;
using System.Runtime.InteropServices;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program requirements common to all variants
            int nrow, ncol, start, end;


            nrow = ncol = 100;
            Console.WriteLine($"Rows - {nrow}, cols - {ncol}");

            // one-dimensional array
            Person[] persons1 = new Person[nrow * ncol];
            for (int i = 0; i < persons1.Length; ++i)
            {
                persons1[i] = new Person();
            }
            // two-dimensional rectangular array
            Person[,] persons2 = new Person[nrow, ncol];
            for (int i = 0; i < persons2.GetLength(0); ++i)
            {
                for (int j = 0; j < persons2.GetLength(1); ++j)
                {
                    persons2[i, j] = new Person();
                }
            }
            // two-dimensional stepped array
            Person[][] persons3 = new Person[nrow][];
            for (int i = 0; i < persons3.Length; ++i)
            {
                persons3[i] = new Person[ncol];
                for (int j = 0; j < persons3[i].Length; ++j)
                {
                    persons3[i][j] = new Person();
                }
            }
            // Enviroment.TickCount []        
            decimal avgAge = 0;
            start = Environment.TickCount;
            foreach (Person item in persons1)
            {
                avgAge += item.Age;
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [] = {end - start}");
            // Enviroment.TickCount [,]        
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Person item in persons2)
            {
                avgAge += item.Age;
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [,] = {end - start}");
            // Enviroment.TickCount [][]     
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Person[] item in persons3)
            {
                foreach (Person subitem in item)
                {
                    avgAge += subitem.Age;
                }
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [][] = {end - start}");
            Console.WriteLine();
            // Variant 1
            Console.WriteLine("\tStudent");
            Exam exam1 = new Exam("C#", new DateTime(2020, 09, 20), 10);
            Exam exam2 = new Exam("C#", new DateTime(2020, 10, 11), 10);
            Exam exam3 = new Exam("C++", new DateTime(2021, 11, 22), 10);

            // Array[]
            Student[] students1 = new Student[nrow * ncol];
            for (int i = 0; i < students1.Length; i++)
            {
                students1[i] = new Student();
            }
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Student item in students1)
            {
                avgAge += item.StudentData.Age;
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [] = {end - start}");

            // Array[,]
            Student[,] students2 = new Student[nrow, ncol];
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    students2[i, j] = new Student();
                }
            }
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Student item in students2)
            {
                avgAge += item.StudentData.Age;
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [,] = {end - start}");

            // Array[][]
            Student[][] students3= new Student[nrow][];
            for (int i = 0; i < students3.Length; ++i)
            {
                students3[i] = new Student[ncol];
                for (int j = 0; j < students3[i].Length; ++j)
                {
                    students3[i][j] = new Student();
                }
            }
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Student[] item in students3)
            {
                foreach (Student subitem in item)
                {
                    avgAge += subitem.StudentData.Age;
                }
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [][] = {end - start}");
            Console.WriteLine();

            Student student = new Student(new Person("Vova", "Batsyk", new DateTime(1987, 07, 27), Gender.Male), Education.Master, 2, exam1, exam2, exam3);

            student.AddExams(new Exam("Asp .NET Core", DateTime.Today, 8));

            Console.WriteLine(student.ToString());
            Console.WriteLine(student.toShortString());
            Console.WriteLine($"Bachelor? {student[Education.Bachelor]}");
            Console.WriteLine();

            // Variant 2
            Console.WriteLine("\tMagazine 2");
            Console.WriteLine();
            Article article1 = new Article();

            Magazine magazine = new Magazine("The best", Frequency.Monthly, new DateTime(2020, 10, 02), 1002);

            magazine.AddArticles(new Article(persons1[0], "New", 7.5));
            magazine.AddArticles(article1);

            Console.WriteLine("ToString");
            Console.WriteLine(magazine.ToString());
            Console.WriteLine("toShortString");
            Console.WriteLine(magazine.toShortString());
            Console.WriteLine();

            // Array[]
            Article[] articles1 = new Article[nrow * ncol];
            for (int i = 0; i < articles1.Length; i++)
            {
                articles1[i] = new Article();
            }
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Article  item in articles1)
            {
                avgAge += item.Author.Age;
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [] = {end - start}");

            // Array[,]
            Article[,] articles2= new Article[nrow, ncol];
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    articles2[i, j] = new Article();
                }
            }
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Article item in articles2)
            {
                avgAge += item.Author.Age;
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [,] = {end - start}");

            // Array[][]
            Article[][] articles3= new Article[nrow][];
            for (int i = 0; i < articles3.Length; ++i)
            {
                articles3[i] = new Article[ncol];
                for (int j = 0; j < articles3[i].Length; ++j)
                {
                    articles3[i][j] = new Article();
                }
            }
            avgAge = 0;
            start = Environment.TickCount;
            foreach (Article[] item in articles3)
            {
                foreach (Article subitem in item)
                {
                    avgAge += subitem.Author.Age;
                }
            }
            end = Environment.TickCount;
            Console.WriteLine($"Time [][] = {end - start}");
            Console.WriteLine();


        }

    }
}