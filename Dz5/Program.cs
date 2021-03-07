using System;
using System.Threading;

namespace Dz5
{
    class Program
    {
        private static readonly object __SyncRoot = new object();
        static void Main(string[] args)
        {

            Console.WriteLine("Вычисления факториала и сума чисел до этого чичла. ведите число и нажвите ентр чтобы расчтитать факториал");

           int UserNumber=int.Parse(Console.ReadLine());
         var Thread_Factorial= new Thread(() => Factorial(UserNumber));
            Thread_Factorial.Priority = ThreadPriority.Highest;
            Thread_Factorial.Name = "Factorial";

         var Thread_SumOfNumbers = new Thread(() => SumOfNumbers(UserNumber));
            Thread_SumOfNumbers.Priority = ThreadPriority.Highest;
            Thread_SumOfNumbers.Name = "SumOfNumbers";
            lock (__SyncRoot)
            {
                Thread_Factorial.Start();
            }
            lock (__SyncRoot)
            {
                Thread_SumOfNumbers.Start();
             }
            
        }

        static int SumOfNumbers(int x)
        {
            int sum=0;
            for (int i = 1; i < x; i++)
            {
                
                    Console.WriteLine("sum" + sum);
                    sum += i;
                
                
            }
            Console.WriteLine("sum" + sum);
            return sum;
        }

        static int Factorial(int x)
        {
            if (x == 0)
            {
                Console.WriteLine("Factorial"+x);
                return 1;
            }
            else
            {
                Console.WriteLine("Factorial" + x);
                return x * Factorial(x - 1);
            }
        }

    }

}
