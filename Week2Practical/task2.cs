using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practical
{
    internal class task2
    {
        public static void CountString()
        {
            Boolean upperCase = false;
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            str = str.Trim();
            string[] strWords = str.Split(' ');
            for (int i = 0; i < strWords.Length; i++)
            {

                if (Char.IsUpper(strWords[i][0]) == true)
                {
                    upperCase = true;
                }
            }
            if (upperCase == true)
            {

                Console.WriteLine("The sentence you inputted is: " + str);
                Console.WriteLine("Number of words = " + strWords.Length);
            }
            else
            {
                Console.WriteLine("enter sentence with every letter starting uppercase");
            }

        }
    }
}
