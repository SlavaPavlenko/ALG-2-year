using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            Random random = new Random();
            //заполнение
            for (int i = 0; i < 10; i++)
                list.AddLast(random.Next(100));
            //проверка
            LinkedListNode<int> node = new LinkedListNode<int>(list.First.Value);
            while (node.Value != -1 && node.Next != null)
            {
                node.Value = -1;
                node = node.Next;
            }
            if (node.Value == -1)
                Console.WriteLine("Список зациклен");
            else Console.WriteLine("Список не зациклен");
            Console.Read();
        }
    }
}
