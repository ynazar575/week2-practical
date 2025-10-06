using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Practical
{
    internal class task3
    {
        public static void Encrypt() 
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter rotation amount");
            int rotations = Int32.Parse(Console.ReadLine());
            rotations = rotations % 26;
            char[] inputs = input.ToCharArray();
            for (int i = 0; i < inputs.Length; i++) 
            {
                char scramble = inputs[i];

                if (char.IsLetter(scramble))
                {
                    char offset = char.IsUpper(scramble) ? 'A' : 'a';
                    inputs[i] = (char)(((scramble - offset + rotations) % 26)+ offset   );
                }

            }
            
            Console.WriteLine("the sentence you entered is " + input);
            Console.WriteLine("the encrypted sentence is " + new string(inputs));
        }
        public static void decrypt()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            Console.WriteLine("Enter rotation amount");
            int rotations = Int32.Parse(Console.ReadLine());
            rotations = rotations % 26;
            char[] inputs = input.ToCharArray();
            for (int i = 0; i < inputs.Length; i++)
            {
                char scramble = inputs[i];

                if (char.IsLetter(scramble))
                {
                    char offset = char.IsUpper(scramble) ? 'A' : 'a';
                    inputs[i] = (char)(((scramble - offset - rotations +26) % 26) + offset);
                }

            }

            Console.WriteLine("the sentence you entered is " + input);
            Console.WriteLine("the encrypted sentence is " + new string(inputs));
        }
    }
}
