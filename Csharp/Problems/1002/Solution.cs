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
                int[] posA = [a[0], a[1]];
                int[] posB = [a[3], a[4]];
                int[] disR = [a[2], a[5]];

                int testCaseResult = DefineTestCase(posA, posB, disR);
                answer.Add(testCaseResult);
                Console.WriteLine($"두 좌표 거리: {GetLength(posA[0], posA[1], posB[0], posB[1])}, r_1 + r2 = {disR[0] + disR[1]}");
            }

            for (int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        private int DefineTestCase(int[] positionA, int[] positionB, int[] distanceR)
        {
            int distAB = ReturnNormalNumber(GetLength(positionA[0], positionA[1], positionB[0], positionB[1]));

            if ((distAB == 0) && (distanceR[0] != distanceR[1])) { return 0; }

            int lenR1R2 = ReturnNormalNumber(distanceR[0] + distanceR[1]);
            if (distAB < lenR1R2) { return 2; }
            else if (distAB == lenR1R2) { return 1; }
            else if (distAB > lenR1R2) { return -1; }
            else
            {
                Console.WriteLine("error. 없는 경우의 수");
                return -100;
            }
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