using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class QueueModified
    {
        public class Node
        {
            private int value;
            private int index;
            private Node next;
            private Node prev;

            public Node(int index, Node next)
            {
                this.value = index;
                this.next = next;
                this.index = 0;
            }
            public Node(int value)
            {
                this.value = value;
                this.next = null;
                index = 0;
            }
            public Node(int value, int index)
            {
                this.value = value;
                this.next = null;
                this.index = index;
            }
            public Node(int value, int index, Node next)
            {
                this.value = value;
                this.next = next;
                this.index = index;
            }
            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    this.next = value;
                }
            }
            public Node Prev
            {
                get
                {
                    return prev;
                }
                set
                {
                    this.prev = value;
                }
            }
            public int Value
            {
                get
                {
                    return value;
                }
                set
                {
                    this.value = value;
                }
            }
            public int Num
            {
                get
                {
                    return index;
                }
                set
                {
                    this.index = value;
                }
            }
        }
        public class Queue
        {
            Node first;
            Node last;
                       
            public void addFirst(int value, int index)
            {
                if (last == null)
                {
                    first = new Node(value, index, null);
                    last = first;
                    first.Next = null;
                }
                else
                {
                    Node node = new Node(value, index);
                    last.Prev = node;
                    node.Next = last;
                    last = node;
                }
            }

            public void removeFirst()
            {
                if (last == null)
                {
                    first = null;
                    last = null;
                }
                else last = last.Next;
            }
            public void removeLast()
            {
                if (first.Prev != null)
                {
                    first = first.Prev;
                    first.Next = null;
                }
                else
                {
                    last = null;
                    first = null;
                }
            }

            public int firstv
            {
                get
                {
                    if (last == null) return -1;
                    else
                        return last.Value;
                }
            }

            public int firstn
            {
                get
                {
                    return last.Num;
                }
            }

            public int lastv
            {
                get
                {
                    return first.Value;
                }
            }

            public int lastn
            {
                get
                {
                    return first.Num;
                }
            }

            public bool isEmpty()
            {
                if (first == null && last == null)
                    return true;
                else return false;
            }
        }
    }
}
