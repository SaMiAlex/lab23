using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static int n;

        static void Main(string[] args)
        {
            Console.WriteLine("Main начал работу");
            FactorialAsync();
            Console.WriteLine("Main прекратил работу");
            Console.ReadKey();
        }

        static void Factorial()
        {
            int r = 1;
            for (int i = 0; i < n; i++)
            {
                r = r * (i + 1);
            }
            Console.WriteLine($"{n}!= {r}");
        }

        static async Task FactorialAsync()
        {
            Console.WriteLine("FactorialAsync начал работу");
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            await Task.Run(() => Factorial());
            Console.WriteLine("FactorialAsync прекратил работу");
        }
    }
}
