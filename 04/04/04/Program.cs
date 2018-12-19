using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueModified.Queue queue = new QueueModified.Queue();
            Random rand = new Random();
            Console.Write("k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[] { 7, 8, 13, 2, 9, 10, 4, 3, 8, 5, 7 };    //n=11
            for (int i = 0; i < mas.Length; i++)
            {
                if (i > k - 1 && queue.lastn == i - k)
                    queue.removeLast();
                while (!queue.isEmpty() && queue.firstv < mas[i])
                    queue.removeFirst();
                queue.addFirst(mas[i], i);
                Console.Write(queue.lastv + " ");
            }
            Console.Read();
        }
    }
}
