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
            int[] mas = new int[10] {3, 12, 2, 7, 2, 1, 7, 3, 5, 1};
            int res = 1;
            for (int i = 0; i < mas.Length; i++)
                res *=mas[i];
            Console.WriteLine("Результат: " + res);
            Console.Read();
        }
    }
}
