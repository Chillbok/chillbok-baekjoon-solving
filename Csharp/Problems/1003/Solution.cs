using System;

namespace Csharp.Problems
{
    public class Problem1003
    {
        public void Solve()
        {
        }

        private int fibonacci(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
    }
}
