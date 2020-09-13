using System;
using System.Linq;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n + 1];
            int[,] points = new int[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n+1; j++)
                {
                    numbers[i, j] = nums[j];
                }
            }
            points[0, 1] = numbers[0, 1];
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    points[i, j] = Math.Max(points[i - 1, j], points[i - 1, j - 1]) + numbers[i, j];
                }
            }
            int max = int.MinValue;
            for (int i = 0; i <=n; i++)
            {
                if (points[n-1,i]>max)
                {
                    max = points[n-1, i];
                }
            }
            Console.WriteLine(max);



        }
    }
}
/*
5
0 7 0 0 0 0
0 3 8 0 0 0
0 8 1 0 0 0
0 2 7 4 4 0
0 4 5 2 6 5
*/

