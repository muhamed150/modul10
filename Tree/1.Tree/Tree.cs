using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Tree
{
    public class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public Tree(T value, params Tree<T> [] children)
        {
            this.value = value;
            this.children = children;
        }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(value);
            foreach (var child in children)
            {
                child.Print(indent + 1);
            }
        }

        public IEnumerable<T> OrderDFS()
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }

        private void DFS(Tree<T> tree, List<T> order)
        {
            foreach (var child in tree.children)
            {
                tree.DFS(child, order);
            }
            order.Add(tree.value);
        }

        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> queue = new Queue<Tree<T>>();
            queue.Enqueue(this);
            while (queue.Count!=0)
            {
                Tree<T> currentElement = queue.Dequeue();
                order.Add(currentElement.value);
                foreach (var child in currentElement.children)
                {
                    queue.Enqueue(child);
                }
                
            }
            return order;
        }
    }
}
