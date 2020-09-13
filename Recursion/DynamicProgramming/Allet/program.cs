using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var L = line[0];
            var n = line[1];
            var d = Console.ReadLine().Split().Select(int.Parse).ToList();
            var Br = new int[L+1];
            Br[0] = 1;

            for (int i = 1; i <= L; i++)
            {
                int count = 0;
                for (int j = 0; j < d.Count; j++)
                {
                    if (i-d[j]>=0)
                    {
                        count += Br[i - d[j]];
                    }
                }
                Br[i] = count;

            }
            Console.WriteLine(Br[L]);





        }
    }
}
