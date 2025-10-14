using System;
using System.Runtime.InteropServices;

namespace Csharp.Problems
{
    public class Problem1002
    {
        int testCaseAmount; //테스트 횟수
        public void Solve()
        {
            string[] firstInput = Console.ReadLine()!.Split();
            //테스트 횟수
            testCaseAmount = int.Parse(firstInput[0]);

            List<int> answer = new List<int>();

            for (int i = 0; i < testCaseAmount; i++)
            {
                string[] numberInputs = Console.ReadLine()!.Split();

                answer.Add(Test(numberInputs));
            }

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        //테스트 실행
        private int Test(string[] stringInput)
        {
            int x1, y1, r1, x2, y2, r2;
            List<int> inputs = ReturnIntList(stringInput);
            x1 = inputs[0]; y1 = inputs[1];
            r1 = inputs[2];
            x2 = inputs[3]; y2 = inputs[4];
            r2 = inputs[5];

            double distAB = ReturnDistance(x1, y1, x2, y2);

            if ((distAB == 0) && (r1 != r2)) { return 0; }
            else if ((distAB == 0) && (r1 == r2)) { return 1; }

            double sumR1R2 = r1 + r2;

            if (distAB < sumR1R2) { return 2; }
            else if (distAB == sumR1R2) { return 1; }
            else { return -1; }
        }

        private double ReturnDistance(int x1, int y1, int x2, int y2)
        {
            double result = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);
            result = Math.Round(result, 3);
            return result;
        }

        //받은 string 배열을 int 리스트로 반환
        private List<int> ReturnIntList(string[] inputs)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                result.Add(int.Parse(inputs[i]));
            }
            return result;
        }
    }
}
