using System;
using System.Linq;

namespace Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] v = new int[n + 1, n + 1];
            int[,] up = new int[n + 1, n + 1];
            int[,] left = new int[n + 1, n + 1];

            //такси отдолу-нагоре
            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j <=n; j++)
                {
                    up[i, j] = input[j];
                }
            }

            //такси отляво-надясно
            for (int i = 0; i <=n ; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 1; j <= n; j++)
                {
                    left[i, j] = input[j-1];
                }
            }

            v[0, 0] = 0;
            
            //ред 0
            for (int i = 1; i <=n ; i++)
            {
                v[0, i] = v[0,i-1] + left[0,i];
            }

            //колона 0
            for (int i = 1; i <= n; i++)
            {
                v[i, 0] = v[i - 1,0] + up[i,0];
            }

            //останалите клетки
            for (int i = 1; i <=n ; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int fromLeft = v[i, j - 1] + left[i, j];
                    int fromDown = v[i - 1, j] + up[i, j];
                    if (fromLeft<fromDown)
                    {
                        v[i, j] = fromLeft;
                    }
                    else
                    {
                        v[i, j] = fromDown;
                    }
                }
            }
            Console.WriteLine(v[n,n]);


        }
    }
}
/*
3
3 2 5 2
2 4 5 4
5 6 7 6
4 6 7
5 7 9
3 2 5
5 7 8
--
21
*/
