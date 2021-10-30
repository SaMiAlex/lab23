 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab23
{
    class Program//конспект лекции
    {
        static void Method1()
        {
            Console.WriteLine("Метод1 начал работу");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Метод1 выводит счетчик = {i}");
                Thread.Sleep(100);
            }
            Console.WriteLine("Метод1 кончил работу");
        }
        static void Method2(int n)
        {
            Console.WriteLine("Метод2 начал работу");
            for (int i = n; i < n+10; i++)
            {
                Console.WriteLine($"Метод2 выводит счетчик = {i}");
                Thread.Sleep(200);
            }
            Console.WriteLine("Метод2 кончил работу");
        }
        static int Method3()
        {
            Console.WriteLine("Метод3 начал работу");
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Метод3 кончил работу");
            return (S);
        }
        static void Main(string[] args)
        {
            //Action action = new Action(Method1);//способ создания холодной задачи №1
            //Task task1 = new Task(action);
            //task1.Start();
            //Task task2 = new Task(Method1);//способ создания холодной задачи №2
            //Task task3 = new Task(delegate () { Method1(); });//способ создания холодной задачи №3
            //Task task4 = new Task(() => Method1());//способ создания холодной задачи №4
            //Task task5 = Task.Factory.StartNew(action);//способ создания горячей задачи №1
            // Task task6 = Task.Run(() => Method1());//способ создания горячей задачи №2 - используется чаще всего на практике
            //task6.Wait();


            int r=Method1Async().Result;
            Method2(100);
            

            Console.WriteLine("Main окончил работу");
            Console.WriteLine(r);

            Console.ReadKey();
        }


        static async Task<int> Method1Async()
        {
            Console.WriteLine("Method1Async начал работу");
            //await Task.Run(() => Method1());
            int result = await Task.Run(() => Method3()); 
            Console.WriteLine("Method1Async окончил работу");
            return result;
        }
    }
}
