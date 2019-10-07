using System;
using System.Linq;

namespace ParallelCompulsory1
{
    public class PrimeChecker
    {
        public bool NumberIsPrime(long number)
        {
            //long n, i, m = 0, flag = 0;
            //n = number;
            //m = n / 2;
            //for (i = 2; i <= m; i++)
            //{
            //    if (n % i == 0)
            //    {

            //        flag = 1;
            //    }
            //}
            //if (flag == 0)
            //    return true;
            //else
            //    return false;

            //return Enumerable.Range(2, (int)Math.Sqrt(number) - 1).All(divisor => number % divisor != 0);

            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;

        }
    }
}
