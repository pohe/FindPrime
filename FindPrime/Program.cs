using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeCalc pc = new PrimeCalc();
            Console.WriteLine("Find prime - sekventielt");
            pc.FindPrimes(1000000);


            Console.WriteLine("Find prime - Task1");
            pc.FindPrimesTask(1000000);
            Console.WriteLine("Find prime - Task2");
            pc.FindPrimesTask(1000000);
            Console.WriteLine("Find prime - Task3");
            pc.FindPrimesTask(1000000);
            Console.WriteLine("Find prime - Task4");
            pc.FindPrimesTask(1000000);


            Console.WriteLine("Find prime - Task1 -Lock");
            pc.FindPrimesTaskLock(1000000);
            Console.WriteLine("Find prime - Task2 -Lock");
            pc.FindPrimesTaskLock(1000000);
            Console.WriteLine("Find prime - Task3 -Lock");
            pc.FindPrimesTaskLock(1000000);


            PrimeCalcConcurrentBag PCCB = new PrimeCalcConcurrentBag();
            Console.WriteLine("Find prime - ConcurrentBag");
            PCCB.FindPrimesTask(1000000);

            Console.WriteLine("Find prime - ConcurrentBag Parallel.For");
            PCCB.FindPrimesPar(1000000);
            Console.ReadKey();
        }
    }
}
