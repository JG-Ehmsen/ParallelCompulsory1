using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class App
    {
        Stopwatch sw;
        PrimeChecker pc;
        public App()
        {
            pc = new PrimeChecker();
        }

        // Find primes in the indicated range, sequentially.
        public List<long> GetPrimesSequential(long first, long last)
        {
            var primes = new List<long>();

            for (long i = first; i < last; i++)
            {
                if (pc.NumberIsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        // Find primes in the indicated range, in parallel.
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
