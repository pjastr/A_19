using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Największa liczba: {0}", Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Najmniejsza liczba: {0}", Math.Min(a, Math.Min(b, c)));

            Console.ReadKey();
        }
    }
}
