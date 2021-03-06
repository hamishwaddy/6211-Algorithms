﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question1
{
    public class ProgramQ1
    {
        static Stack<char> userWordStack = new Stack<char>();


        public static void Main(string[] args)
        {
            Console.WriteLine("*** Question1: Palindrome ***\n\n");
            Console.WriteLine("Enter the word that you think is a palindrome.");
            string input = Console.ReadLine().ToLower();

            BuildWordStack(input);
            PalindromeCheck(input, ReverseWord());
            Console.ReadLine();

        }

        //This method receives the word entered by the user as a parameter and has the job of pushing the characters of that word onto a stack.
        public static void BuildWordStack(string input)
        {

            char[] chArr = input.ToCharArray();

            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] != ' ')
                {
                    userWordStack.Push(chArr[i]);
                }
                
            }
        }

        //This method receives no parameters but has the job of returning a string; the word (the characters from the stack) in reverse.
        public static string ReverseWord()
        {
            Stack<char> userWordStackCopy = userWordStack;

            string reversedWord = "";
            int wordNum = userWordStack.Count;
            for(int i = 0 ; i < wordNum; i++)
            {
                reversedWord += userWordStackCopy.Pop();
            }
            return reversedWord;
        }

        //This method receives two parameters (the word entered, and the word in reverse) and has the job of comparing them, and displaying an appropriate message, stating if the word is a palindrome or not.
        public static void PalindromeCheck(string input, string reversedWord) //How do I pass the ReverseWord method to this method?
        {

            if (input == reversedWord)
            {
                Console.WriteLine($"The word '{ input }' is a palindrome. '{ input }' in reverse is '{ reversedWord }'.");
            }
            else
            {
                Console.WriteLine($"The word '{ input }' is not a palindrome.  '{ input }' in reverse is '{ reversedWord }'.");
            }
        }

    }
}
