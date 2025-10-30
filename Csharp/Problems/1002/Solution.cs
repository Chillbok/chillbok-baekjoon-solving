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
            //테스트 횟수 정하기
            int testCaseAmount = firstInput[0]; //테스트 횟수

            int[] testCases = GetInput(); //테스트 값들 (x1, y1, r1, x2, y2, r2)

            List<int> answer = new List<int>(); //답 저장하기 위한 리스트

            for (int i = 0; i < testCaseAmount; i++)
            {
                answer.Add(Test(testCases));
            }

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
        
        private static int[] GetInput()
        {
            string [] firstInput = Console.ReadLine()!.Split();
            int firstInputLength = firstInput.Length;
            int[] result = new int[firstInputLength];
            for (int i = 0; i < firstInputLength; i++)
            {
                int[i] = int.Parse(firstInput[i]);
            }
            return result;
        }

        //테스트 실행
        private static int Test(int[] arr)
        //private static int Test(int x1, int y1, int r1, int x2, int y2, int r2)
        {
            //긴급 종료
            if (arr.Length != 6) {return -100;}
            //두 원의 중심 사이 거리
            long distAB = ReturnDistance(x1, y1, x2, y2);

            if ((distAB == 0) && (r1 == r2)) { return -1; }

            long sumR1R2 = (long)Math.Pow(r1 + r2, 2);
            long minusR1R2 = (long)Math.Pow(r1 - r2, 2);

            if (distAB > sumR1R2 || distAB < minusR1R2) { return 0; }
            else if (distAB == sumR1R2 || distAB == minusR1R2 ) { return 1; }
            else { return 2; }
        }

        private static long ReturnDistance(int x1, int y1, int x2, int y2)
        {
            double result = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            result = Math.Round(result, 3);
            return (long)result;
        }
    }
}
