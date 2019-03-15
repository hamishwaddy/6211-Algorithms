using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web.Script.Serialization;

namespace ListsAndObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=5");

            //Console.WriteLine(json);

            List<Person> data = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            stopwatch.Stop();

            foreach (Person x in data)
            {
                Console.WriteLine("\nName: {0} {1}\nGender: {2}\nRegion: {3}", x.name, x.surname, x.gender, x.region);
                Console.WriteLine("Credit card details\nExpiration: {0}\nNumber: {1}\nPIN: {2}\nSecurity: {3}",x.credit_card.expiration, x.credit_card.number, x.credit_card.pin,x.credit_card.security);
            }

            Console.WriteLine("\n\nTime to populate the list: {0}ms", stopwatch.ElapsedMilliseconds);



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
