using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practical
{
    internal class task1
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Please enter a valid option from below \n 1. Hello in French \n 2. Hello in Spanish \n 3. Hello in German \n 4. Hello in Italian \n 0. exit application");
          
        }
        public static int InputOption()
        {
            int option = 0;
            try { 
            Console.WriteLine("enter choice");
            option = Int32.Parse(Console.ReadLine());
            return option;
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
          
            return option;
            
        }
        public static void GetMessage()
        {
            switch (InputOption())
            {
                case 0: Console.WriteLine("Goodbye");
                    break;
                case 1:
                    Console.WriteLine("Bonjour");
                    break;
                case 2:
                    Console.WriteLine("Ola");
                    break;
                case 3:
                    Console.WriteLine("Hallo");
                    break;
                case 4:
                    Console.WriteLine("Ciao");
                    break;
                default: Console.WriteLine("enter valid menu option");
                    break;
            }
         
        }

    }
}
