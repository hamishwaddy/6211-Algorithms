using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1Palindrome
{
    public class ProgramQ1
    {
        static Stack<char> userWordStack = new Stack<char>();
        static Stack<char> userWordStackCopy = new Stack<char>();



        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question1: Palindrome ***\n\n");
            Console.WriteLine("Enter the word that you think is a palindrome.");
            string string1 = Console.ReadLine().ToLower();

            BuildWordStack(string1);
            //string rw = ReverseWord();
            //PalindromeCheck(string1, rw);

            Console.ReadLine();

        }

        public static void BuildWordStack(string string1)
        {
            //This method receives the word entered by the user as a parameter and has the job of pushing the characters of that word onto a stack.
            string1.Split()

            for (int i = 0; i < noSpaces.Length; i++)
            {
                Console.WriteLine(i);
            }

            //char[] chArr = string1.ToArray();

            //for (int x = 0; x < chArr.Length; x++)
            //{
            //    if (chArr[x] != ' ')
            //    {
            //        userWordStack.Push(chArr[x]);
            //    }

            //}


        }

        public static string ReverseWord()
        {
            //This method receives no parameters but has the job of returning a string; the word (the characters from the stack) in reverse.
            string reversedWord = "";
            int wordnum = userWordStack.Count;
            for (int i = 0; i < wordnum; i++)
            {
                reversedWord += userWordStack.Pop();
            }

            return reversedWord;
        }

        static void PalindromeCheck(string string1, string rw)
        {
            //This method receives two parameters (the word entered, and the word in reverse) and has the job of comparing them, and displaying an appropriate message, stating if the word is a palindrome or not. (if statement???)
            if (string1 == rw)
            {
                Console.WriteLine($"The word '{ string1 }' is a palindrome. '{ string1 }' in reverse is '{ rw }'.");
            }
            else
            {
                Console.WriteLine($"The word '{ string1 }' is not a palindrome.  '{ string1 }' in reverse is '{ rw }'.");
            }
        }

    }
}
