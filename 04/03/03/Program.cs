using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            LinkedListNode<int> node1 = list1.First;
            LinkedListNode<int> node2 = list2.First;
            //заполнение
            Console.WriteLine("list1:");
            for (int i = 0; i < 10; i++)
            {
                list1.AddLast(random.Next(100));
                Console.Write(list1.Last.Value + " ");
            }
            //копирование
            node1 = list1.First;
            while (node1 != null && node1.Value != -1)
            {
                list2.AddLast(node1.Value);
                node1.Value = -1;
                node1 = node1.Next;
            }
            //вывод
            node2 = list2.First;
            Console.WriteLine("\nlist2:");
            while (node2 != null)
            {
                Console.Write(node2.Value + " ");
                node2 = node2.Next;
            }
            Console.Read();
        }
    }
}
