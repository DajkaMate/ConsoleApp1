using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            int szam = 0;
   
            for (int i = 0; i < 50; i++)
            {
                szam = r.Next(1,101);
                Console.WriteLine("{0} ",szam);
            }

            Console.ReadKey();
        }
    }
}
