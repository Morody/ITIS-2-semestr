using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class LinkedList<T> where T : IComparable 
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public bool Empty
        {
            get { return count == 0; }
        }

        public LinkedList()
        {

        }

        public void AddAfter(LinkedListNode<T> node, T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value, node.Next);
            node.Next = newNode;
            count++;
        }

        public void RemoveAfter(LinkedListNode<T> node)
        {
            LinkedListNode<T> removedNode = node.Next;

            node.Next = removedNode.Next;
            removedNode.Next = null;

            if (removedNode == tail)
            {
                tail = node;
            }
            count--;
        }

        public void Remove(LinkedListNode<T> node)
        {
            if (node.Next != null)
            {
                node.Value = node.Next.Value;
                RemoveAfter(node.Next);

            }
        }

        public LinkedListNode<T> Find (T value)
        {
            LinkedListNode<T> ptr = head;
            while ( ptr != null)
            {
                if (ptr.Value.CompareTo(value) == 0)
                    return ptr;
                
                    ptr = ptr.Next;
                
                
            }
            return null;
        }

        public void Add (T value)
        {
            if (head == null)
            {
                head = tail = new LinkedListNode<T>(value, null);
                count++;
            }
            else
            {
                AddAfter(tail, value);
                tail = tail.Next;
            }
            
        }

        public void ChangeMin(T value)
        {
            var min = head;
            while (min != null)
            {
                if (min  tail)
                {

                }
            }

        }
    }
}
