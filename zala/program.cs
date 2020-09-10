using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вселена: ");
            var university = Console.ReadLine().Split().Select(int.Parse).ToList();
            var countOfSubsets = int.Parse(Console.ReadLine());
            List<List<int>> subsets = new List<List<int>>();
            List<int> currentSubset = new List<int>();
            var count = 0;
            for (int i = 0; i < countOfSubsets; i++)
            {
                var input = Console.ReadLine().Split(' ',',').Select(int.Parse).ToList();
                subsets.Add(input);
            }
            subsets = subsets.OrderByDescending(x => x.Count).ToList();

            /*foreach (var item in subsets)
            {
                Console.WriteLine(string.Join(", ",item));
            }
             */
            currentSubset = subsets.First();

            for (int i = 0; i < countOfSubsets; i++)
            {
                for (int j = 0; j < currentSubset.Count; j++)
                {
                    if (university.Contains(currentSubset[j]))
                    {
                        university.Remove(currentSubset.Where());
                        currentSubset = subsets[i];
                    }
                }
                
            }
             
    

        }
    }
}
