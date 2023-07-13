using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cornapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   int num1, num2;
            //    Console.WriteLine("Enter First Number");
            //    num1= int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number");
            //    num2= int.Parse(Console.ReadLine());
            //    var result = num1 > num2 ? "First Number is Greater" : "Second Number is Greater";
            //    Console.WriteLine(result);
            //    Console.ReadKey();



            // Console.Write("Enter marks in Pre: ");
            //int preMarks = Convert.ToInt32(Console.ReadLine());

            //if (preMarks > 60)
            //{
            //    Console.Write("Enter marks in Final: ");
            //    int finalMarks = Convert.ToInt32(Console.ReadLine());

            //    if (finalMarks > 55)
            //    {
            //        Console.WriteLine("Selected");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Fail in Final");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Fail in Pre");
            //}

            //Console.ReadLine();
            //
            //int[] marks = new int[5];
            //Console.WriteLine("Enter Marks");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine("Enter marks in Subject " + (i + 1));
            //    marks[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Marks List");
            //for (int i = 0; i < marks.Length; i++)
            //{
            //    Console.WriteLine($"Subject {i + 1} \t Marks: {marks[i]}");
            //}
            //Console.ReadKey();


            //Console.WriteLine("Enter Number of Students");
            //int nos = int.Parse(Console.ReadLine());
            //string[] students = new string[nos];
            //for (int i = 0; i < nos; i++)
            //{
            //    Console.WriteLine($"Enter Student{i + 1}\'s name");
            //    students[i] = Console.ReadLine();
            //}
            //Console.WriteLine("List of Students");
            //foreach (String Student in students)
            //{
            //    Console.WriteLine(Student);
            //}
            //Console.ReadKey();

            int[,] marks = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter Students {i + 1}\'s Roll Number");
                marks[i, 0] = int.Parse(Console.ReadLine());
                for (int j = 1; j < 3; j++)
                {

                    Console.WriteLine($"Enter marks of Students {i + 1}\'s in sem");
                    marks[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Marks List as follows");
            Console.WriteLine("RollNo\tSemOne\tSemTwo");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(marks[i, j] + "\t");
                }
             
            }
            Console.ReadKey();





        }
    }
}
