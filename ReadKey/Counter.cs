using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReadKey
{
    class Counter
    {
        int cnt = 0;
        int push = 0;
        public void Action(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.OemPlus)
            {
                Console.Clear();
                cnt++;
                push++;
                Console.WriteLine($"{cnt}");
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                Console.Clear();
                cnt--;
                push++;
                Console.WriteLine($"{cnt}");
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                Console.WriteLine($"Счетчик - {cnt}\nКол-во нажатий - {push}\n");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (key.Key == ConsoleKey.Enter)
                Console.WriteLine("\n---ВЫХОД---\n");
        }
    }
}