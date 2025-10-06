using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practical
{
    internal class Task4
    {
        public static double CircleArea(double radius)
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid option from below \n 1. Calculate area of a circle \n 0. exit application");
                int option = 0;
                try
                {
                    Console.WriteLine("enter choice");
                    option = Int32.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if(option != 0)
                {
                    return System.Math.PI * Math.Pow(radius, 2);
                }
                if (option == 0)
                {
                    Environment.Exit(0);
                }
                double area = 0;
                return area;

            }
        }
    }
}
