using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BinaryTree
{
    public class BinaryTree<T> where T: IComparable
    {
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public T Item { get; set; }
        }

        private Node Root { get; set; }
        public int Count { get; private set; }

        public void Add(T item)
        {
            Node node = new Node();
            node.Item = item;
            Count++;
            if (Root==null)
            {
                Root = node;
                return;
            }
            Node iterator = Root;

            while (true)
            {
                if (iterator.Left!=null&&iterator.Item.CompareTo(item)>=0)
                {
                    iterator = iterator.Left;
                }
                else if (iterator.Right!=null&&iterator.Item.CompareTo(item)<0)
                {
                    iterator = iterator.Right;
                }
                else
                {
                    break;
                }
            }
            if (iterator.Item.CompareTo(item)>=0)
            {
                iterator.Left = node;
            }
            else if(iterator.Item.CompareTo(item)<0)
            {
                iterator.Right = node;
            }
        } 
        public void Remove(T item)
        {
            if (Root==null||!this.Contains(item))
            {
                throw new InvalidOperationException();
            }
            Count--;
            Root = Delete(Root, item); 
        }

        private Node Delete(Node root, T item)
        {
            if (root==null)
            {
                return null;
            }
            if (root.Item.CompareTo(item)>0)
            {
                root.Left = Delete(root.Left, item);
            }
            else if (root.Item.CompareTo(item)<0)
            {
                root.Right = Delete(root.Right, item);
            }
            else
            {
                if (root.Left==null)
                {
                    return root.Right;
                }
                if (root.Right == null)
                {
                    return root.Left;
                }

                Node leftMost = root.Right;
                while (leftMost.Left!=null)
                {
                    leftMost = leftMost.Left;
                }
                root.Item = leftMost.Item;
                root.Right = Delete(root.Right, leftMost.Item);

            }
            return root;
        }

        public bool Contains(T item)

        {
            if (Root == null)
            {
                return false;
            }
            Node iterator = Root;
            while (true)
            {
                if (iterator == null)
                {
                    return false;
                }
                else if (iterator.Item.CompareTo(item) == 0)
                {
                    return true;
                }
                else if (iterator.Item.CompareTo(item) > 0)
                {
                    iterator = iterator.Left;
                }
                else if (iterator.Item.CompareTo(item) < 0)
                {
                    iterator = iterator.Right;
                }
            } 
        }

            Public voiNode GetNode()
            {

            }

            public void PrintPreOrder (Node root)
            {
                if (root!=null)
                {
                    PrintPreOrder(root.Left);
                    Console.Write(root.Item + " ");
                    PrintPreOrder(root.Right);
                }      
            }
        }
    }
}
