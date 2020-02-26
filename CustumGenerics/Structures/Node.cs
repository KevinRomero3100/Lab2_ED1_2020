using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumGenerics.Structures
{
    class Node<T>
    {
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }
        public T Value { get; set; }

        

    }
}
