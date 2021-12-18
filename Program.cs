using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var customer = new Customer();
            shop.productList.CollectionChanged += Customer.OnItemChanged;

            bool continueCycle = true;

            while (continueCycle)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Введите идентификатор: ");
                        bool idIsANumber = int.TryParse(Console.ReadLine(), out int correctId);
                        if (idIsANumber)
                        {
                            string name = DateTime.Now.ToString();
                            shop.Add(correctId, name);
                        }

                        else
                        {
                            Console.WriteLine("Некорректный ввод \n");
                        }
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Идентификатор товара для удаления");
                        bool removeIdIsANumber = int.TryParse(Console.ReadLine(), out int removeId);
                        if (removeIdIsANumber)
                        {
                            shop.Remove(removeId);
                        }

                        else
                        {
                            Console.WriteLine("Некорректный ввод \n");
                        }
                        break;

                    case ConsoleKey.X:
                        continueCycle = false;
                        break;
                }
            }
        }
    }
}
