using System;
using System.Threading;

namespace MULTITHREADING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";


            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

    
            Console.WriteLine($"{mainThread.Name} is complete!");


            // Start();
            Console.ReadKey();
        }
        public static void Start()
        {
            // This method is invoked to start a thread.

            Sleep(1000);
            Suspend(1);
            Resume(10);
            Abort();
        }
        
        public static void Sleep(int millisecondsTimeout)
        {
            // This method is used to sleep the current thread
            // for the defined millisecond period.

            Console.WriteLine("Hello, World");
            Thread.Sleep(1000);
            Console.WriteLine("Hello, World");
        }

        public static void Suspend(int number) 
            // Repeats 24087 times: and it is different
        {
            // Suspends the thread.

            Suspend(1);
            Console.WriteLine("Hello");
        }

        public static void Resume(int number)
        {
            // Resumes the suspended thread.

            Console.WriteLine("Bye... ");
        }

        public static void Abort()
        {
            // Terminated the calling thread.

            Console.WriteLine("Say hello");
        }

        public static void CountDown(String name)
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1 : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Timer #2 : {i} seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}