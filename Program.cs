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



            Console.Write("Enter marks in Pre: ");
            int preMarks = Convert.ToInt32(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.Write("Enter marks in Final: ");
                int finalMarks = Convert.ToInt32(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }

            Console.ReadLine();
        }
    }
}
