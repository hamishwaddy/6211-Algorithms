using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1Palindrome
{
    public class ProgramQ1
    {
        public static string globalstring = "";

        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question1: Palindrome ***\n\n");
            Console.WriteLine("Enter the word that you think is a palindrome.");
            string string1 = Console.ReadLine().ToLower();

            glob
            BuildWordStack(string1);
            
            Console.ReadLine();

        }

        public static Stack<char> BuildWordStack(string string1)
        {
            //This method receives the word entered by the user as a parameter and has the job of pushing the characters of that word onto a stack.
            //CONVERT STRING INTO ARRAY OF CHARS
            //LOOP THRU CHARACTERS AND ADD TO STACK AT EACH ITERATION
            Stack<char> userWordStack = new Stack<char>();
            char[] chArr = new char[string1.Length];
            //string1.ToCharArray();
            string1.CopyTo(0, chArr, 0, string1.Length);
            for (int i = 0; i < chArr.Length; i++)
            {
                //Console.Write(chArr[i] + " ");
                userWordStack.Push(chArr[i]);
                Console.Write(userWordStack.Peek());
            }

            return userWordStack;  //DOES THIS NEED TO BE RETRUNED OR SHOULD THE METHOD BE VOID
            
        }

        public static string ReverseWord()
        {


            //This method receives no parameters but has the job of returning a string; the word (the characters from the stack) in reverse.
            //HOW CAN I REVERSE ARRAY IF NO PARAMS ARE PASSED?

            char[] chArr = new char[string1.Length];
            string stringRev = Array.Reverse(chArr);
            return stringRev;
        }

        //static void PalindromeCheck(string string1, string stringRev)
        //{
        //    //This method receives two parameters (the word entered, and the word in reverse) and has the job of comparing them, and displaying an appropriate message, stating if the word is a palindrome or not. (if statement???)
        //}

    }
}
