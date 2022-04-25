using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter();
            ConsoleKeyInfo k;
            do
            {
                k = Console.ReadKey();
                c.Action(k);


            } while (k.Key != ConsoleKey.Enter);
        }
    }
}
