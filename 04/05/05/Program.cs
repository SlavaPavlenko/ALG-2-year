using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 1, 0, 0};
            //int[] mas = new int[] { 1, 2, 3, 1 };
            //int[] mas = new int[] { 7, 6, 2, 5, 3, 2, 1, 8, 4 };
            int k = 1;
            int value1 = 0;
            int value2 = 0;
            int index1 = 0;
            int index2 = 0;
            //заход в цикл
            value1 = mas[mas.Length - 1];
            for (int i = 0; i < mas.Length; i++)
            {
                index1 = value1;
                value1 = mas[index1];
                //Console.Write(value1 + " ");
            }
            //вычисление k
            index2 = value1;
            value2 = mas[index2];
            k++;
            while (index2 != index1 && value2 != value1)
            {
                index2 = value2;
                value2 = mas[index2];
                k++;
            }
            //нахождение повторяющегося числа
            value1 = mas[mas.Length - 1];
            value2 = mas[mas.Length - 1];
            for (int i = 0; i < k; i++)
            {
                index2 = value2;
                value2 = mas[index2];
            }
            while (index1 != index2 && value1 != value2)
            {
                index1 = value1;
                value1 = mas[index1];
                index2 = value2;
                value2 = mas[index2];
            }
            Console.WriteLine("Повторяющееся число: " + value1);
            Console.Read();
        }
    }
}