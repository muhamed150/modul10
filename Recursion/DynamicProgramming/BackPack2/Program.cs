using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            var items = new List<Item>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                    var parts = line.Split(" ");
                    items.Add(new Item
                    {
                        Name = parts[0],
                        Weight = int.Parse(parts[1]),
                        Price = int.Parse(parts[2])
                    });
            }
            var prices = new int[items.Count + 1, maxCapacity + 1];
            var itemsIncluded = new bool[items.Count + 1, maxCapacity + 1];
            for (int itemIndex = 0; itemIndex < items.Count; itemIndex++)//propuskame 1 red
            {
                var item = items[itemIndex];
                var rowIndex = itemIndex + 1;
                for (int capacity = 0; capacity < maxCapacity+1; capacity++)
                {
                    if (item.Weight>capacity)
                    {
                        continue;
                    }

                    var excluding = prices[rowIndex - 1, capacity];
                    var including = item.Price + prices[rowIndex - 1, capacity - item.Weight];

                    if (including>excluding)
                    {
                        prices[rowIndex, capacity] = including;
                        itemsIncluded[rowIndex, capacity] = true;
                    }
                    else
                    {
                        prices[rowIndex, capacity] = excluding;
                        itemsIncluded[rowIndex, capacity] = true;
                    }
                }
            }

            var CurrentCapacity = maxCapacity;
            
            var result = new List<Item>();

            for (int itemIndex = items.Count-1; itemIndex >= 0; itemIndex--)
            {
                var currentItem = items[itemIndex];
                //if (CurrentCapacity<=0)
                //{
                //    break;
                //}
                if (itemsIncluded[itemIndex + 1, CurrentCapacity])
                {
                    result.Add(currentItem);
                    CurrentCapacity -= currentItem.Weight;

                }
                
            }

            Console.WriteLine(result.Sum(item=>item.Weight));
            Console.WriteLine(prices[items.Count,maxCapacity]);// totalValue
           
        }

       
    }
}
