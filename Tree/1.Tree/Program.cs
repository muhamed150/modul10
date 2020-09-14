using System;

namespace _1.Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(7, new Tree<int>(19, new Tree<int>(1), new Tree<int>(12), new Tree<int>(31)),
                             new Tree<int>(21),
                            new Tree<int>(14, new Tree<int>(23), new Tree<int>(6)));
            tree.Print();
            //Console.WriteLine(string.Join(" ",tree.OrderDFS())); 
            Console.WriteLine(string.Join(" ",tree.BFS())); 
        }
    }
}
