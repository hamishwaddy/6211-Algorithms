using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Question2
{
    public class ProgramQ2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Question2: Acronym Builder ***\n\n");
            Console.WriteLine("Type a sentence or phrase to turn into an acronym.");
            string sentence = Console.ReadLine();
            string[] words = new string[] { sentence }; //HAS THIS POPULATED THE WORDS ARRAY? HOW CAN I TEST?
            

            Console.ReadLine();

        }
    }

    public class Acronym
    {
        //PROPERTIES
        public string FullSentence { get; set; }
        public string[] Words { get; set; }
        public Dictionary<char, string> AcronymDictionary { get; set; }



        //CONSTRUCTOR
        public Acronym(string sentence) //The parameterised constructor should receive the sentences as a parameter and then populate the words array???
        {
            FullSentence = sentence;
            string[] words = new string[]{sentence}; //HAS THIS POPULATED THE WORDS ARRAY? HOW CAN I TEST?
            Words = words;
        }

        //METHODS
        public static void BuildAcronym()
        {
           Dictionary<char, string> dict = new Dictionary<char, string>();
            

        }

        public static void DisplayAcronym()
        {

        }


    }
}
