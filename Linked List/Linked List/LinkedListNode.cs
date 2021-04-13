using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class LinkedListNode<T> where T: IComparable
    {
        public T Value;
        public LinkedListNode<T> Next;

        public LinkedListNode(T value, LinkedListNode<T> next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
