using System;
using System.Net;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Extension_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stpwtch = new Stopwatch();
            stpwtch.Start();

            string json = new WebClient().DownloadString("http://uinames.com/api/amount=2");

            Console.WriteLine(json);

            Console.ReadLine();


        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string  Region { get; set; }
    }
}
