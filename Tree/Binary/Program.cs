using System;

namespace _2.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binary = new BinaryTree<int>();
            binary.Add(6);
            binary.Add(1);
            binary.Add(4);
            binary.Add(2);
            binary.Add(9);
            binary.Add(7);
            binary.Add(3);
            Console.WriteLine(binary.Count);
            binary.Remove(3);
            Console.WriteLine(binary.Count);
            Console.WriteLine(binary.Contains(3));
        }
    }
}
