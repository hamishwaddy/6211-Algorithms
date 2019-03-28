using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace GetAllUiNamesString
{
    class ProgramGetStringFormat
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=1");

            Console.WriteLine(json);

            stopwatch.Stop();

            Console.WriteLine("\n\nTime to populate list: {0}ms",stopwatch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
