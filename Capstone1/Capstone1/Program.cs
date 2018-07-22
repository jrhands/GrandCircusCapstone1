using System;
using System.Linq;

namespace Capstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Translate(GetInput());
            } while (Continue());
            Console.Read();
        }

        static String GetInput()
        {
            Console.WriteLine("Input a word");
            return Console.ReadLine();
        }

        static void Translate(String input)
        {
            String vowels = "aeiouAEIOU";
            int characterPos = -1;
            foreach (char character in input)
            {
                characterPos += 1;
                if (vowels.Contains(character) || (characterPos >= 1 && (character == 'y' || character == 'Y')))
                {
                    break;
                }
            }
            if (characterPos == 0)
            {
                Console.WriteLine(input.ToLower() + "way");
            }
            else if (characterPos > 0)
            {
                Console.WriteLine((input.Substring(characterPos, input.Length - characterPos) + input.Substring(0, characterPos) + "ay").ToLower());
            }
        }

        static bool Continue()
        {
            while (true)
            {
                Console.Write("Continue? (y/n): ");
                String input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    return true;
                }
                else if (input == "n" || input == "no")
                {
                    return false;
                }
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
