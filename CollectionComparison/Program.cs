using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace CollectionComparison
{
    internal class Program
    {
        static Stopwatch sw = new Stopwatch();
        static Random random = new Random();

        static void CollectionFiller(List<int> list, ArrayList arrayList, LinkedList<int> linkedList)
        {
            sw.Start();
            for (int i = 0; i < 1000000; i++)
                list.Add(random.Next());

            sw.Stop();
            Console.WriteLine($"Затраченное время для List {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
                arrayList.Add(random.Next());

            sw.Stop();
            Console.WriteLine($"Затраченное время для ArrayList {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
                linkedList.AddLast(random.Next());

            sw.Stop();
            Console.WriteLine($"Затраченное время для LinkedList {sw.Elapsed}");
        }
        static void CollectionFinder(List<int> list, ArrayList arrayList, LinkedList<int> linkedList)
        {
            sw.Restart();
            Console.WriteLine($"Элемент 496753 для List {list[496753]}");
            sw.Stop();
            Console.WriteLine($"Затраченное время для List {sw.Elapsed}");

            sw.Restart();
            Console.WriteLine($"Элемент 496753 для ArrayList {arrayList[496753]}");
            sw.Stop();
            Console.WriteLine($"Затраченное время для ArrayList {sw.Elapsed}");

            sw.Restart();
            Console.WriteLine($"Элемент 496753 для LinkedList {linkedList.ElementAt(496753)}");
            sw.Stop();
            Console.WriteLine($"Затраченное время для LinkedList {sw.Elapsed}");
        }
        static void CollectionDividingBy777SpeedMesauring(List<int> list, ArrayList arrayList, LinkedList<int> linkedList)
        {
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                if (list[i] % 777 == 0)
                    Console.WriteLine(list[i]);
            }
            sw.Stop();
            Console.WriteLine($"Затраченное время на поиск элементов делимых на 777 для List {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                if (Convert.ToInt32(arrayList[i]) % 777 == 0)
                    Console.WriteLine(arrayList[i]);
            }
            sw.Stop();
            Console.WriteLine($"Затраченное время на поиск элементов делимых на 777 для ArrayList {sw.Elapsed}");

            sw.Restart();
            for (int i = 0; i < 1000000; i++)
            {
                if (linkedList.ElementAt(i) % 777 == 0)
                    Console.WriteLine(linkedList.ElementAt(i));
            }
            sw.Stop();
            Console.WriteLine($"Затраченное время на поиск элементов делимых на 777 для ArrayList {sw.Elapsed}");
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            ArrayList arrayList = new ArrayList();
            LinkedList<int> linkedList = new LinkedList<int>();

            CollectionFiller(list, arrayList, linkedList);
            CollectionFinder(list, arrayList, linkedList);
            CollectionDividingBy777SpeedMesauring(list, arrayList, linkedList);
        }
    }
}