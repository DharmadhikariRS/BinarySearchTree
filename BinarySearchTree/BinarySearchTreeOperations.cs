using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTreeOperations<K> where K : IComparable
    {
        public BinarySearchTreeNode<K> Root = null;
        public void AddElement(K Element)
        {

            BinarySearchTreeNode<K> binarySearchTreeNode = new BinarySearchTreeNode<K>(Element);
            if (Root == null)
            {
                Root = binarySearchTreeNode;
                Console.WriteLine("Added {0} at Root ",Element);
            }
            else
            {
                BinarySearchTreeNode<K> Temp = Root;
                if ((dynamic)Element < Root.Key)
                {
                    while (Temp.Left != null)
                    {
                        if ((dynamic)Element < Temp.Key)
                        {
                            Temp = Temp.Left;
                        }
                        else if (Temp.Right != null)
                        {
                            Temp = Temp.Right;

                        }
                        else
                        {
                            break;
                        }
                    }
                    if ((dynamic)Element < Temp.Key)
                    {
                        Console.WriteLine("Added {0} at left of {1} ",Element, Temp.Key);
                        Temp.Left = binarySearchTreeNode;
                    }
                    else
                    {
                        Console.WriteLine("Added {0} at Right of {1} ", Element, Temp.Key);
                        Temp.Right = binarySearchTreeNode;
                    }

                }
                else
                {
                    while (Temp.Right != null)
                    {
                        if ((dynamic)Element < Temp.Key)
                        {
                            Temp = Temp.Left;
                        }
                        else if (Temp.Right != null)
                        {
                            Temp = Temp.Right;

                        }
                        else
                        {
                            break;
                        }
                    }
                    if ((dynamic)Element < Temp.Key)
                    {
                        Console.WriteLine("Added {0} at left of {1} ", Element, Temp.Key);
                        Temp.Left = binarySearchTreeNode;
                    }
                    else
                    {
                        Console.WriteLine("Added {0} at Right of {1} ", Element, Temp.Key);
                        Temp.Right = binarySearchTreeNode;

                    }

                }
                
            }
        }
        public void SearchElement(K Element)
        {
            BinarySearchTreeNode<K> Temp = Root;

            while (Temp.Right != null || Temp.Left != null)
            {
                if ((dynamic)Element < Temp.Key)
                {
                    Temp = Temp.Left;
                }
                else
                {
                    Temp = Temp.Right;
                }
                if ((dynamic)Element == Temp.Key)
                {
                    Console.WriteLine("Element is found= " + Temp.Key);
                    break;
                }

            }
            if (Temp.Right == null && Temp.Left == null && Temp.Key != (dynamic)Element)
            {
                Console.WriteLine("Element is Not found= " + Element);
            }

        }
    }
}
