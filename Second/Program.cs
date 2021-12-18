using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> storage = new ConcurrentDictionary<string, int>();
            string[] menu = new string[3] { "1 - добавить книгу;", "2 - вывести список непрочитанного;", "3 - выйти\n" };

            var procentCalculate = new Task(() =>
            {
                while (true)
                {
                    foreach (var element in storage)
                    {
                        int tmp = element.Value + 1;

                        if (tmp == 100)
                        {
                            storage.TryRemove(element);
                        }

                        storage.TryUpdate(element.Key, tmp, element.Value);
                    }
                    Thread.Sleep(1000);
                }
            });

            procentCalculate.Start();

            bool willContinue = true;

            while (willContinue)
            {
                ViewMenu(menu);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Введите название книги: ");
                        string bookName = Console.ReadLine();

                        if (string.IsNullOrEmpty(bookName))
                        {
                            Console.WriteLine("Букв не обнаружено\n");
                        }

                        else if (storage.ContainsKey(bookName))
                        {
                            Console.WriteLine("Введенное название присутствует в коллекции\n");
                        }

                        else
                        {
                            storage.TryAdd(bookName, 0);
                        }
                        break;

                    case ConsoleKey.D2:
                        foreach (KeyValuePair<string, int> keyValue in storage)
                        {
                            Console.WriteLine(keyValue.Key + " - " + keyValue.Value + "%");
                        }
                        break;

                    case ConsoleKey.D3:
                        willContinue = false;
                        break;
                }
            }

        }

        static void ViewMenu(string[] menu)
        {
            foreach (var item in menu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
