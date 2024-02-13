using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Numerics;
using bred_bolnogo_shizofreniyey_s_maniyey_velichiya;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations.Schema;

/*//x  pseudo-benchmark
var startTime = System.Diagnostics.Stopwatch.StartNew();
for (int benchIt = 0; benchIt < 10000; benchIt++)
{
}
startTime.Stop();
var resultTime = startTime.Elapsed;
Console.WriteLine(resultTime.Milliseconds);*/

namespace grokaem_algoritmi
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

//----------------- 9.2
            /*var inventory = new Inventory();
            inventory.AddItem("Water", 3, 10);
            inventory.AddItem("Book", 1, 3);
            inventory.AddItem("Food", 2, 9);
            inventory.AddItem("Jacket", 2, 5);
            inventory.AddItem("Camera", 1, 6);
            int backpack_capacity = 6;

            var masMax = new int[inventory.GetCount(), backpack_capacity];
            var i = 0;
            //var itemsUsed = new List<Item>();
            foreach (var item in inventory.GetItems())
            {
                for (int j = 0; j < backpack_capacity; j++)
                {
                    masMax[i, j] = Math.Max(i - 1 < 0 ? 0 : masMax[i - 1, j],
                        j + 1 < item.Weight ? 0 :
                        item.Value + (((i - 1 < 0) || (j - item.Weight < 0)) ? 0 : masMax[i - 1, j - item.Weight]));
                }
                i++;
            }

            int maxValue = masMax[inventory.GetCount() - 1, backpack_capacity - 1];
            string itemsUsedString = "";

            int iIndex = inventory.GetCount() - 1;
            int jIndex = backpack_capacity - 1;

            while (iIndex >= 0 && jIndex >= 0)
            {
                if (iIndex - 1 >= 0 && masMax[iIndex, jIndex] == masMax[iIndex - 1, jIndex])
                {
                    iIndex--;
                }
                else
                {
                    itemsUsedString += inventory.GetItems()[iIndex].Name + " ";
                    jIndex -= inventory.GetItems()[iIndex].Weight;
                    iIndex--;
                }
            }

            Console.WriteLine("Максимальная ценность: " + maxValue);
            Console.WriteLine("Использованные предметы: " + itemsUsedString);
            var ob = new ArrayActions();
            ob.Display(masMax);
            //Console.WriteLine(masMax[masMax.GetLength(0) - 1, masMax.GetLength(1) - 1]);*/
        /*class Inventory
        {
            public List<Item> Items;

            public Inventory()
            {
                Items = new List<Item>();
            }

            public void AddItem(string Name, int Weight, int Value) =>
                Items.Add(new Item(Name, Weight, Value));

            public List<Item> GetItems() => Items;

            public int GetCount() => Items.Count;
        }

        class Item
        {
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Value { get; set; }

            public Item(string name, int weight, int value)
            {
                Name = name;
                Weight = weight;
                Value = value;
            }
        }*/


//---------------------
    /*foreach (var a in graph.Keys)
    {
        Console.WriteLine($"{a} friends is {string.Join(", ", graph[a].Select(x => x.ToString()))}");
    }*/

    /*var graph = new Dictionary<string, string[]>();

    graph["you"] = new [] {"alice","bob","claire"};
    graph["bob"] = new[] { "anuj", "peggy" };
    graph["alice"] = new[] { "peggy" };
    graph["claire"] = new[] { "thom", "jonny" };
    graph["anuj"] = new[] { "" };
    graph["peggy"] = new[] { "" };
    graph["jonny"] = new[] { "" };
    graph["thom"] = new[] { "" };


    var f = Search("you");
    Console.WriteLine(f);

    bool Search(string name)
    {
        var search_queue = new Queue<string>(graph[name]);
        var searched = new HashSet<string>();
        while (search_queue.Count > 0)
        {
            var person = search_queue.Dequeue();
            if (!searched.Contains(person))
            {
                if (person_is_seller(person))
                {
                    Console.WriteLine($"{person} is a mango seller!");
                    return true;
                }
                else
                {
                    foreach (var item in graph[person])
                    {
                        if (item != "")
                        {
                            search_queue.Enqueue(item);
                        }
                        searched.Add(person); 
                    }
                }
            }
        }
        return false;
    }

    bool person_is_seller(string name) => name[^1] == 'm';
*/



    /////////////////////////////////////////////////
    //Console.Write(string.Join(' ', search_queue.Dequeue()) + "\n");


    /*//? Рекурсивная сумма
    public static int Summ(List<int> list)
    {
        if (list.Count < 2)
            return list.First();

        return list[0] + Summ(list.Skip(1).ToList());
    }

    public static int ElCount(List<int> list)
    {
        if (list is [])
            return 0;
        return 1 + ElCount(list.Skip(1).ToList());
    }

    public static int Maxx(List<int> list)
    {
        if (list.Count == 2)
            return list[0] >= list[1] ? list[0] : list[1];
        var sub_maxx = Maxx(list.Skip(1).ToList());
        return list[0] >= sub_maxx ? list[0] : sub_maxx;
    }*/



