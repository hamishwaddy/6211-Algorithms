using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace ExtensionExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=50");

            //Console.WriteLine(json);

            List<Person> data = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            List<Person> dataCopy = new List<Person>(json.Length);
            List<Person> femaleData = new List<Person>();
            List<Person> maleData = new List<Person>();

            dataCopy = data;

            foreach (Person x in dataCopy)
            {
                if(x.gender=="female")
                {
                    femaleData.Add(x);
                }
                else if (x.gender=="male")
                {
                    maleData.Add(x);
                }
            }

            Console.WriteLine("FEMALE LIST");
            foreach (Person x in femaleData)
            {
                Console.WriteLine("Name: {0}, {1}", x.surname, x.name);
            }
            Console.Write("\nNumber of females in list: {0}", femaleData.Count);

            Console.WriteLine("\n\nMALE LIST");
            foreach (Person x in maleData)
            {
                Console.WriteLine("Name: {0}, {1}", x.surname,x.name);
            }
            Console.Write("\nNumber of males in list: {0}", maleData.Count);

            Console.WriteLine("\n\nThere are {0} females and {1} males in the list.",femaleData.Count,maleData.Count);

            
            Console.ReadLine();
        }

        
    }

    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string region { get; set; }
        public int age { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public Birthday birthday { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public CreditCard credit_card { get; set; }
        public string photo { get; set; }
    }

    public class Birthday
    {
        public string dmy { get; set; }
        public string mdy { get; set; }
        public int raw { get; set; }
    }

    public class CreditCard
    {
        public string expiration { get; set; }
        public string number { get; set; }
        public int pin { get; set; }
        public int security { get; set; }
    }
}
