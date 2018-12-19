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
            List<Item> list = new List<Item>();
            Item item = new Item("тарелка", 5, 3);
            list.Add(item);
            item = new Item("ваза", 7, 2);
            list.Add(item);
            item = new Item("парфюм", 4, 10);
            list.Add(item);
            item = new Item("вилка", 2, 1);
            list.Add(item);

            Backpack backpack1 = new Backpack(10);
            Console.WriteLine("Без повторений: ");
            backpack1.MakeAllSets(list);
            List<Item> tmp = backpack1.GetBestSet();
            foreach (Item _item in tmp)
                Console.WriteLine("Имя: " + _item.name + " Вес: " + _item.weight + " Цена: " + _item.price);

            Backpack backpack2 = new Backpack(10);
            QuickSort(list, 0, list.Count - 1);
            backpack2.MakeAllSetsWithBack(list);
            tmp = backpack2.GetBestSet();
            Console.WriteLine("С повторениями: ");
            foreach (Item _item in tmp)
                Console.WriteLine("Имя: " + _item.name + " Вес: " + _item.weight + " Цена: " + _item.price);
            Console.Read();
        }
        public static void QuickSort(List<Item> list, int first, int last)
        {
            double p = list[(last - first) / 2 + first].price / list[(last - first) / 2 + first].weight;
            int i = first, j = last;
            while (i <= j)
            {
                while (list[i].price / list[i].weight < p && i <= last) i++;
                while (list[j].price / list[j].weight > p && j >= first) j--;
                if (i <= j)
                {
                    double temp = list[i].price;
                    list[i].price = list[j].price;
                    list[j].price = temp;
                    temp = list[i].weight;
                    list[i].weight = list[j].weight;
                    list[j].weight = temp;
                    string tmp = list[i].name;
                    list[i].name = list[j].name;
                    list[j].name = tmp;
                    i++;
                    j--;
                }
            }
            if (j > first) QuickSort(list, first, j);
            if (i < last) QuickSort(list, i, last);
        }
    }
}
