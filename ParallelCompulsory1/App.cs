using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCompulsory1
{
    public class App
    {
        Stopwatch sw;
        PrimeChecker pc;
        public App()
        {
            sw = new Stopwatch();
            pc = new PrimeChecker();
            Console.WriteLine("Welcome to the prime checker thingy.");

            MainApp();
        }

        public void SingleNumber()
        {
            while (true)
            {
                long number = Convert.ToInt64(Console.ReadLine());

                var isPrime = pc.NumberIsPrime(number);

                Console.WriteLine("Is {0} prime: {1}", number, isPrime);
            }
        }

        public void MainApp()
        {
            while (true)
            {
                Console.WriteLine("Enter start of range to check.");
                long first = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter end of range to check:");
                long last = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Will find primes from {0} to {1}.", first, last);

                sw.Restart();
                var primes = GetPrimesSequential(first, last);
                sw.Stop();

                Console.WriteLine("Found {0} primes.", primes.Count);
                Console.WriteLine("Sequential execution time: {0:F5}", sw.ElapsedMilliseconds / 1000.0);
                //Console.WriteLine(string.Join(" ", primes.ToArray()));

                sw.Restart();
                primes = GetPrimesParallel(first, last);
                sw.Stop();

                Console.WriteLine("Found {0} primes.", primes.Count);
                Console.WriteLine("Parallel execution time: {0:F5}", sw.ElapsedMilliseconds / 1000.0);

                Console.ReadLine();
                Console.Clear();

            }
        }



        public List<long> GetPrimesSequential(long first, long last)
        {
            var primes = new List<long>();

            for (long i = first; i < last; i++)
            {
                if (pc.NumberIsPrime(i))
                {
                    primes.Add(i);
                    //Console.WriteLine("{0} is a prime.", i);
                }
            }

            return primes;
        }

        // Find primes in the 
        public List<long> GetPrimesParallel(long first, long last)
        {
            List<long> numbers = new List<long>();
            Parallel.ForEach
                (
                Partitioner.Create(first, last), (range) =>
                {
                    var numbersTemp = GetPrimesSequential(range.Item1, range.Item2);

                    lock (this)
                    {
                        numbers.AddRange(numbersTemp);
                    }

                }
                );
            return numbers;
        }
    }
}
