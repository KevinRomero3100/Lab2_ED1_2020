using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumGenerics.Structures
{
    class binaryTree<T>
    {
        public Node<T> Root { get; set; }
        List<T> listIt = new List<T>();
        public Node<T> createNode(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.right = null;
            newNode.left = null;
            newNode.Value = value;
            return newNode;
        }
        public void Insert(Node<T> pivot, T value)
        {
            if (Root == null)
            {
                Root = createNode(value);
            }
            else
            {
                var valueRoot = Root.Value;
                if (value.ToString().CompareTo(Root.Value.ToString()) > 0)//condicion para mayores)
                {
                    if (Root.right != null)
                    {
                        Root.right = createNode(value);
                    }
                    else
                    {
                        Insert(Root.right, value);
                    }
                }
                else if (value.ToString().CompareTo(Root.Value.ToString()) < 0)
                {
                    if (Root.left != null)
                    {
                        Root.left = createNode(value);
                    }
                    else
                    {
                        Insert(Root.left, value);
                    }
                }
            }
        }
    }
}
