using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSample
{
    class Program
    {
        static void Function(string text)
        {
                Console.WriteLine("ID " + text + " потік: {0}", Thread.CurrentThread.ManagedThreadId);
                Console.ForegroundColor = ConsoleColor.Yellow;

                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(20);
                    Console.Write(".");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(text + " потік завершився.");
            
        }

        static async Task Main() // Метод Main - виконується у первинному потоці.
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            Task thread1 = new Task(()=>Function("Первинний"));
            thread1.Start();
            await thread1;
            Task thread2 = new Task(() => Function("Вторинний"));
            thread2.Start();
            await thread2;
            Task thread3 = new Task(() => Function("Третинний"));
            thread3.Start();
            await thread3;

            // Очікування первинного потоку, завершення роботи вторинного потоку.
            //thread.Join(); //TODO Зняти чи встановити коментар.


            // Delay
            Console.ReadKey();
        }
    }
}
