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
            int testCaseSize = GetInput(1)[0]; //테스트 횟수

            //테스트 실행
            int[] answer = new int[testCaseSize]; //답 저장하기 위한 배열

            int[] testCases = new int[6];

            //testCaseAmount만큼 반복 실행
            for (int i = 0; i < testCaseSize; i++)
            {
                testCases = GetInput(6); //테스트 값들 (x1, y1, r1, x2, y2, r2)
                answer[i] = Test(testCases);
            }

            //완성된 테스트케이스 하나씩 출력
            for (int i = 0; i < answer.Length; i++) { Console.WriteLine(answer[i]); }
        }

        //입력 받아서 int 배열로 나눠주는 함수
        private static int[] GetInput(int size)
        {
            string[]? firstInput = null;
            do
            {
                firstInput = Console.ReadLine()!.Split();
                if (firstInput.Length != size) { Console.WriteLine($"리스트의 길이가 {size}가 아닙니다. 다시 입력하세요."); }
            } while (firstInput.Length != size);
            int[] result = new int[firstInput.Length];
            for (int i = 0; i < firstInput.Length; i++) { result[i] = int.Parse(firstInput[i]); }
            return result;
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
            //두 원의 중심 사이 거리 구하기
            long distAB = ReturnDistance(arr[0], arr[1], arr[3], arr[4]);

            if ((distAB == 0) && (arr[2] == arr[5])) { return -1; }

            long sumR1R2 = (long)Math.Pow(arr[2] + arr[5], 2);
            long minusR1R2 = (long)Math.Pow(arr[2] - arr[5], 2);

            if (distAB > sumR1R2 || distAB < minusR1R2) { return 0; }
            else if (distAB == sumR1R2 || distAB == minusR1R2 ) { return 1; }
            else { return 2; }
        }

        //두 점의 2차원 좌표 거리 구하는 함수
        private static long ReturnDistance(int x1, int y1, int x2, int y2)
        {
            double result = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            result = Math.Round(result, 3);
            return (long)result;
        }
    }
}
