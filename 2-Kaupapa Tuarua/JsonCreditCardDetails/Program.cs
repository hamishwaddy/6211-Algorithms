using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;

namespace JsonCreditCardDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("--- USING A WEB API ---");
            Console.WriteLine("-------- task 3 -------");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=10");

            List<Person> data = new JavaScriptSerializer().Deserialize<List<Person>>(json);

            stopwatch.Stop();

            foreach (Person x in data)
            {
                Console.WriteLine("\nName: {0} {1}\nRegion: {2}",x.name,x.surname,x.region);
                Console.WriteLine("***** Credit Card Details *****");
                Console.WriteLine("Number: {0}\nPIN: {1}\nSecurity Code: {2}\nExpiration: {3}\nBirthdate: {4}", x.credit_card.number, x.credit_card.pin, x.credit_card.security, x.credit_card.expiration, x.birthday.dmy);
            }

            Console.WriteLine("\n\nTime to populate the list: {0}ms", stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }

    class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string region { get; set; }
        public CreditCard credit_card { get; set; }
        public Birthday birthday { get; set; }

    }

    class CreditCard
    {
        public string number { get; set; }
        public int pin { get; set; }
        public int security { get; set; }
        public string expiration { get; set; }
    }
    
    class Birthday
    {
        public string dmy { get; set; }
    }
    

}
