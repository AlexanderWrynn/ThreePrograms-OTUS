using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace First
{
    public class Customer
    {
        public static void OnItemChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Item newItem = e.NewItems[0] as Item;
                    Console.WriteLine($"Добавлен новый товар: {newItem.Name} c идентификатором {newItem.Id}");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Item oldItem = e.OldItems[0] as Item;
                    Console.WriteLine($"Удален товар: {oldItem.Name} c идентификатором {oldItem.Id}");
                    break;
            }
        }
    }
}
