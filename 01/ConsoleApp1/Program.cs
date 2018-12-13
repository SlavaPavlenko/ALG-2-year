using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void ShakeSort(int[] mas)
        {
            int b = 0;
            int left = 0;
            int right = mas.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++) //-->
                {
                    if (mas[i] > mas[i + 1])
                    {
                        b = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = b;
                        b = i;
                    }
                }
                right = b;
                if (left >= right) break;
                for (int i = right; i > left; i--)  //<--
                {
                    if (mas[i - 1] > mas[i])
                    {
                        b = mas[i];
                        mas[i] = mas[i - 1];
                        mas[i - 1] = b;
                        b = i;
                    }
                }
                left = b;
            }
        }

        public static void QuickSort(int[] mas, int first, int last)
        {
            int p = mas[(last - first) / 2 + first];
            int i = first, j = last;
            while (i <= j)
            {
                while (mas[i] < p && i <= last) i++;
                while (mas[j] > p && j >= first) j--;
                if (i <= j)
                {
                    int temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    i++;
                    j--;
                }
            }
            if (j > first) QuickSort(mas, first, j);
            if (i < last) QuickSort(mas, i, last);
        }

        public static void progon(int len)
        {
            int[] mas = new int[len];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
                mas[i] = rand.Next(10000);

            Console.WriteLine("Шейкер-сортировка: ");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            ShakeSort(mas);
            timer.Stop();
            long time1_ms = timer.ElapsedMilliseconds;
            long time1_ticks = timer.ElapsedTicks;
            Console.WriteLine("ShakeSort ms:  " + time1_ms);
            Console.WriteLine("ShakeSort ticks:  " + time1_ticks);

            Console.WriteLine("Быстрая сортировка:");
            long time2_ms = 0;
            long time2_ticks = 0;
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = rand.Next(10000);
                timer.Restart();
                QuickSort(mas, 0, mas.Length - 1);
                timer.Stop();
                time2_ms += timer.ElapsedMilliseconds;
                time2_ticks += timer.ElapsedTicks;

            }
            timer.Reset();
            Console.WriteLine("QS ms:" + time2_ms + "*10^(-2)");
            Console.WriteLine("QS ticks:" + time2_ticks + "*10^(-2)");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            progon(1000);
            progon(10000);
            progon(100000);

            Console.Write("КОНЕЦ");
            Console.Read();
        }
    }
}