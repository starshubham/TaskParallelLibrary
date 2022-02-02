using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibraryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TaskParallelLibrary.");

            // Implementing ParallelForLoop 
            ParallelForLoop();

            // Implementing ParallelForEachLoop
            ParallelForEachLoop();
        }

        public static void ParallelForLoop()
        {
            int number = 10;
            for (int count = 0; count < number; count++)
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"value of count = {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                //Sleep the loop for 10 miliseconds
                Thread.Sleep(10);
            });
            Console.ReadLine();
        }

        public static void ParallelForEachLoop()
        {
            List<int> numbers = new List<int>
            {
               1,2,3,4,5,6,7,8,9,10,11,12
            };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
                Thread.Sleep(10);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("Parallel ForEach Loop");

            Parallel.ForEach(numbers, num =>
            {
                Console.WriteLine(num);
                Thread.Sleep(10);

            });
        }

    }
}
