using System;

// 프로그래머스 코딩테스트 연습
// 내
namespace DotProduct
{
    class MainClass
    {
        static int Solution(int[] a, int[] b)
        {
            int answer = 0;
            for (int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            return answer;
        }

        // Test
        static int[] a1 = { 1, 2, 3, 4 };
        static int[] a2 = { -1, 0, 1 };
        static int[] b1 = { -3, -1, 0, 2 };
        static int[] b2 = { 1, 0, -1 };

        public static void Main(string[] args)
        {
            Console.WriteLine(Solution(a1, b1));
            Console.WriteLine(Solution(a2, b2));
        }
    }
}
