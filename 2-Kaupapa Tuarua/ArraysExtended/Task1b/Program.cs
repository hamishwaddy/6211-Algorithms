using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1a.Program.Main();
            foreach(double num in Task1a.Program.dubArr)
                Console.WriteLine(num + " ");
        }
    }
}
