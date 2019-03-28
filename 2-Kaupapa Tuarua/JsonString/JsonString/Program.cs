using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace JsonString
{
    public class ProgramTask1and2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("--- USING A WEB API ---");
            Console.WriteLine("-----------------------");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=50");

            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            stopwatch.Stop();

            foreach (CustomObject x in data)
            {
                Console.WriteLine("\nTitle: {4}\nName: {0} {1}\nGender: {2}\nAge: {5}\nRegion: {3}",x.name,x.surname,x.gender,x.region,x.title,x.age);
            }
            Console.WriteLine("\n\nTime to populate list: {0}ms\n", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }

    class CustomObject
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
        public string title { get; set; }
        public int age { get; set; }
    }

    
}
