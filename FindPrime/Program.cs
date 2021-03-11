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
            FindPrimeSeq pc = new FindPrimeSeq();
            Console.WriteLine("Find prime - sekventielt");
            pc.FindPrimes(1000000);


            FindPrimeTask tc = new FindPrimeTask();
            Console.WriteLine("Find prime - Task1");
            tc.FindPrimesTask(1000000);
            Console.WriteLine("Find prime - Task2");
            tc.FindPrimesTask(1000000);
            Console.WriteLine("Find prime - Task3");
            tc.FindPrimesTask(1000000);
            Console.WriteLine("Find prime - Task4");
            tc.FindPrimesTask(1000000);

            FindPrimeTaskLock lc = new FindPrimeTaskLock();
            Console.WriteLine("Find prime - Task1 -Lock");
            lc.FindPrimesTaskLock(1000000);
            Console.WriteLine("Find prime - Task2 -Lock");
            lc.FindPrimesTaskLock(1000000);
            Console.WriteLine("Find prime - Task3 -Lock");
            lc.FindPrimesTaskLock(1000000);


            PrimeCalcConcurrentBag PCCB = new PrimeCalcConcurrentBag();
            Console.WriteLine("Find prime - ConcurrentBag");
            PCCB.FindPrimesTask(1000000);

            Console.WriteLine("Find prime - ConcurrentBag Parallel.For");
            PCCB.FindPrimesPar(1000000);
            Console.ReadKey();
        }
    }
}
