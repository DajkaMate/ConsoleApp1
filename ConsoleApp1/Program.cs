using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random r = new Random;
        static void Main(string[] args)
        {
            Console.WriteLine("kérek egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            
            

            for (int i = 0; i < ; i++)
            {
                szam = r.Next(1,101);
                Console.WriteLine("{0} ",szam);
            }

            Console.ReadKey();
        }
    }
}
