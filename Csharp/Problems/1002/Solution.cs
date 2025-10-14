using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Csharp.Problems
{
    public class Problem1002
    {
        public void Solve()
        {
            string[] firstInput = Console.ReadLine()!.Split();
            //테스트 횟수
            int testCaseAmount = int.Parse(firstInput[0]);

            List<int> answer = new List<int>();

            string[] numberInputs;

            for (int i = 0; i < testCaseAmount; i++)
            {
                numberInputs = Console.ReadLine()!.Split();

                int x1, y1, r1, x2, y2, r2;

                x1 = int.Parse(numberInputs[0]);
                y1 = int.Parse(numberInputs[1]);
                r1 = int.Parse(numberInputs[2]);
                x2 = int.Parse(numberInputs[3]);
                y2 = int.Parse(numberInputs[4]);
                r2 = int.Parse(numberInputs[5]);

                answer.Add(Test(x1, y1, r1, x2, y2, r2));
            }


            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        //테스트 실행
        private static int Test(int x1, int y1, int r1, int x2, int y2, int r2)
        {
            double distAB = ReturnDistance(x1, y1, x2, y2);

            if ((distAB == 0) && (r1 != r2)) { return 0; }
            else if ((distAB == 0) && (r1 == r2)) { return 1; }

            double sumR1R2 = Math.Pow(r1 + r2, 2);

            if (distAB < sumR1R2) { return 2; }
            else if (distAB == sumR1R2) { return 1; }
            else { return -1; }
        }

        private double ReturnDistance(int x1, int y1, int x2, int y2)
        {
            double result = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            result = Math.Round(result, 3);
            return result;
        }
    }
}
