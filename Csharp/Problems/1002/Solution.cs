using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Csharp.Problems
{
    public class Problem1002
    {
        public void Solve()
        {
            int testCaseAmount = InputSingleNumber();

            List<int> answer = new List<int>();

            for (int i = 0; i < testCaseAmount; i++)
            {
                List<int> a = new List<int>();
                a = InputMultipleNumber();

                int distanceR1R2 = a[2] + a[5];
                double distanceAB = GetLength(a[0], a[1], a[3], a[4]);

                int testCaseResult = DefineTestCase(distanceR1R2, distanceAB);
                answer.Add(testCaseResult);
                Console.WriteLine($"두 좌표 거리: {distanceAB}, r_1 + r2 = {distanceR1R2}");
            }

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        private int DefineTestCase(int r1R2Length, double lengthAB)
        {
            int ABNormalize = ReturnNormalNumber(lengthAB);
            int r1r2Normalize = ReturnNormalNumber(r1R2Length);

            if (ABNormalize < r1r2Normalize) { return 2; }
            else if (ABNormalize == r1r2Normalize) { return 1; }
            else { return -1; }
        }

        //숫자에 1000 곱한 뒤, int로 변환해서 반환
        private int ReturnNormalNumber(double number)
        {
            double value = number * 1000;
            return (int)value;
        }

        private int ReturnNormalNumber(int number)
        {
            number = number * 1000;
            return number;
        }

        private int InputSingleNumber()
        {
            string[] inputs = Console.ReadLine()!.Split();
            return int.Parse(inputs[0]);
        }

        private List<int> InputMultipleNumber()
        {
            string[] inputs = Console.ReadLine()!.Split();
            List<int> answerList = new List<int>();

            for (int i = 0; i < inputs.Length; i++)
            {
                answerList.Add(int.Parse(inputs[i]));
            }
            return answerList;
        }

        //길이 구하는 함수
        private double GetLength(int a, int b, int c, int d)
        {
            double xValue = Math.Pow(b - a, 2);
            double yValue = Math.Pow(c - d, 2);
            double result = Math.Pow(xValue + yValue, 1.0 / 2.0);
            return result;
        }
    }
}