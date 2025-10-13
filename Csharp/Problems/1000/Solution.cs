using System;

namespace Csharp.Problems
{
    public class Problem1000
    {
        public void Solve()
        {
            string[] inputs = Console.ReadLine()!.Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            Console.WriteLine(a + b);
        }
    }
}