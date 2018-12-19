using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Backpack
    {
        private List<Item> bestItems = null;
        private double bestWeight;
        private double bestPrice;
        public Backpack(double _maxWeight)
        {
            bestWeight = _maxWeight;
        }
        private double TotalWeigth(List<Item> list)
        {
            double totalWeight = 0;
            foreach (Item item in list)
                totalWeight += item.weight;
            return totalWeight;
        }
        private double TotalPrice(List<Item> list)
        {
            double totalPrice = 0;
            foreach (Item item in list)
                totalPrice += item.price;
            return totalPrice;
        }
        private void CompareSet(List<Item> list)
        {
            if (bestItems == null)
            {
                if (TotalWeigth(list) <= bestWeight)
                {
                    bestItems = list;
                    bestPrice = TotalPrice(list);
                }
            }
            else
            {
                if (TotalWeigth(list) <= bestWeight && TotalPrice(list) > bestPrice)
                {
                    bestItems = list;
                    bestPrice = TotalPrice(list);
                }
            }
        }
        public void MakeAllSets(List<Item> list)
        {
            if (list.Count > 0)
                CompareSet(list);
            for (int i = 0; i < list.Count; i++)
            {
                List<Item> newSet = new List<Item>(list);
                newSet.RemoveAt(i);
                MakeAllSets(newSet);
            }
        }
        public void MakeAllSetsWithBack(List<Item> list)
        {
            bestItems = new List<Item>();
            bool end = false;
            double tmpWeight = bestWeight;
            int i = list.Count - 1;
            while (!end)
            {
                if (tmpWeight >= list[i].weight)
                {
                    bestItems.Add(list[i]);
                    tmpWeight -= list[i].weight;
                }
                else i--;
                if (tmpWeight == 0 || i == 0 && tmpWeight < list[i].weight)
                    end = true;
            }
        }
        public List<Item> GetBestSet()
        {
            return bestItems;
        }
    }
}
