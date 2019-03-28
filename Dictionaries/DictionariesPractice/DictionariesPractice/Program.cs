using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** DICTIONARIES ********");

            Dictionary<int, string> dict = new Dictionary<int, string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a word into the dictionary: ");
                dict.Add(i, Console.ReadLine());
            }

            foreach (KeyValuePair<int,string> x in dict)
            {
                Console.WriteLine("Key: {0}\tValue: {1}", x.Key,x.Value);
            }

            Console.WriteLine();
            //Search if a user input name is contained in dictionary

            Console.WriteLine("Does the dictionary contain the number 2? " + dict.ContainsKey(2));
            Console.WriteLine("Does the dictionary contain the value orange? " + dict.ContainsValue("orange"));

            Console.WriteLine();
            //Extract names from dictionary, copy to an array and display that back to user

            Console.WriteLine("Dictionary copied to array");
            string[] arr = new string[dict.Count];
            dict.Values.CopyTo(arr,0);

            foreach (string x in arr)
            {
                Console.WriteLine(x);
            }


            Console.ReadLine();
        }
    }
}
