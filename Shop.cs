using System;
using System.Collections.ObjectModel;

namespace First
{
    class Shop
    {

        public ObservableCollection<Item> productList = new ObservableCollection<Item>();

        public void Add(int id, string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                Console.WriteLine("Некорректное название");
                return;
            }

            productList.Add(new Item { Id = id, Name = productName });
        }

        public void Remove(int id)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].Id == id)
                {
                    productList.Remove(productList[i]);
                }
            }

        }
    }
}
