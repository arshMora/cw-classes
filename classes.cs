using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bred_bolnogo_shizofreniyey_s_maniyey_velichiya
{
    internal class OwnMath
    {
        //? находит общие наим. и наиб. делители
        public static bool NOD(int x, int y, out int least, out int greatest)
        {
            int max = x > y ? x / 2 + 1 : y / 2 + 1;
            bool first = true;

            least = 1; // наименьший общий делитель
            greatest = 1; // наибольший

            // Find least and greatest common factors. 
            for (int i = 2; i < max; i++)
            {
                if (((x % i) == 0) && ((y % i) == 0))
                {
                    if (first)
                    {
                        least = i;
                        first = false;
                    }
                    greatest = i;
                }
            }

            if (least != 1) return true;
            else return false;
        }

        //? число Фибоначчи от его последовательности 
        public static int Fibonacci(int n)
        {

            int f1 = 1;
            int f2 = 1;
            int fn = f2;

            for (int i = 2; i < n; i++)
            {
                fn = f2 + f1;
                f1 = f2;
                f2 = fn;
            }

            return fn;
        }

        //? ФАКТОРИАЛ (рекурсия)
        public static int Fact(int n) => n > -1 ? FactPosHelper(n) : FactNegHelper(-n);
        // вспм. функция для положительных чисел функции Fact 
        public static int FactPosHelper(int n) => n == 0 ? 1 : n * FactPosHelper(n - 1);
        // вспм. функция для отрицательных чисел функции Fact 
        public static int FactNegHelper(int n) => n == 0 ? -1 : n * FactNegHelper(n - 1);

        //? ФАКТОРИАЛ2 (хвостовая рекурсия)
        public static int FactTailRec(int n) => FactTailRecHelper(n, 1);

        //вспогательная функция для FactTailRec
        private static int FactTailRecHelper(int n, int result) => n == 0 ? result : FactTailRecHelper(n - 1, n * result);
    }
    internal class ArrayActions
    {
        Random rand = new();

        //? вывод элементов одномерного массива в строчку
        public void Display(int[] mas)
        {
            foreach (int i in mas)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        //? вывод двумерного массива
        public void Display(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write(mas[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //? заполняет одномерный массив со строки(через пробел)
        public int[] ManualArrayFill(int[] mas)
        {
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < mas.Length; mas[i] = Convert.ToInt32(s[i++])) ;

            return mas;
        }
        //? заполняет двумерный массив со строки(через пробел)
        public int[,] ManualArrayFill(int[,] mas)
        {
            string[] s;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                s = Console.ReadLine().Split(' ');
                if (s != null)
                    for (int j = 0; j < mas.GetLength(1); j++)
                        mas[i, j] = Convert.ToInt32(s[j]);
            }
            return mas;

        }
        //? проверяет, неубывающий ли массив (то есть каждый следующий элемент не меньше предыдущего)
        public int[] MonNonDecreasingArray(ref bool monMasErr)
        {
            string[] s = Console.ReadLine().Split();
            int[] monMas = new int[s.Length];
            // от нуля заполняет сам натур. числами
            for (int i = 0; i < monMas.Length; monMas[i] = Convert.ToInt32(s[i++])) ;

            for (int i = 0; i < monMas.Length - 1; i++)
                if (monMas[i] > monMas[i + 1])
                {
                    monMasErr = true;
                    monMas = Array.Empty<int>();
                    Console.WriteLine("Ошибка: Монотонность массива не соблюдена.");
                    return monMas;
                }
            return monMas;
        }
        //? проверяет, невозрастающий ли массив (то есть каждый следующий элемент не больше предыдущего)
        public bool MonNonGrowingArray(int[] monMas)
        {
            // true - невозрастающий
            // false - ...

            for (int i = 0; i < monMas.Length - 1; i++)
                if (monMas[i] < monMas[i + 1])
                    return false;

            return true;
        }
        //? удаляет повторяющиеся элементы
        public int[] ExtraRem(ref int[] mas)
        {
            int[] supp1 = new int[mas.Length];
            int idx = 0;
            foreach (int i in mas)
            {
                if (!supp1.Contains(i))
                {
                    supp1[idx++] = i;
                }
            }

            Array.Resize(ref supp1, idx);
            mas = supp1.ToArray();
            return mas;
        }
        //? БЫСТРАЯ СОРТИРОВКА ДЛЯ МАССИВОВ ( O(logn * n) )
        /*
            ВХОД: массив, индекс первого элемента массива, индекс последнего элемента массива
            ВЫХОД: void, сортировка не создает дополнительный временный массив, а сортирует передаваемый ей массив
         */
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    (arr[right], arr[left]) = (arr[left], arr[right]);
                }
                else
                {
                    return right;
                }
            }
        }








        //? БЫСТРАЯ СОРТИРОВКА ДЛЯ СПИСКОВ ( O(logn * n) )
        public List<int> QSort(List<int> list)
        {
            int ll = list.Count; // количество элементов списка
            if (ll <= 1)
                return list;

            int pivotIdx = ll / 2; // индекс опорной точки
            int pivot = list[pivotIdx]; // опорная точка
            List<int> left = new List<int>(ll - 1);
            List<int> right = new List<int>(ll - 1);

            for (int i = 0; i < ll; i++)
            {
                if (i == pivotIdx)
                    continue;
                if (list[i] <= pivot)
                    left.Add(list[i]);
                else
                    right.Add(list[i]);
            }

            List<int> sorted = QSort(left);
            sorted.Add(pivot);
            sorted.AddRange(QSort(right));

            return sorted;
        }



        //? БИНАРНЫЙ ПОИСК ( O(log_2(n) )
        /* входные элементы: отсортированный список, искомое значение
            выходные данные: индекс искомого значения
         */
        public int Binary_search(List<int> list, int item)
        {
            int low = 0, high = list.Count - 1; // в переменных low и high хранятся границы той части списка, в которой выполняется поиск

            for (; low <= high;) // пока эта часть не сократится до одного элемента ...
            {
                int mid = (low + high) / 2, // ... проверяем средний элемент
                    guess = list[mid];

                if (guess == item)  // значение найдено
                    return mid;

                if (guess > item)   // много
                    high = mid - 1;
                else                // мало
                    low = mid + 1;
            }

            return -1; // значение не существует
        }


        //? Поиск наименьшего элемента в списке
        /* входные данные: список
            выходные данные: индекс наименьшего элемента
         */
        public static int FindSmallest(List<int> list)
        {
            int smallest = list[0], smallestIndex = 0; // для хранения наименьшего значения и индекса наименьшего значения

            for (int i = 1; i < list.Count; i++)
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    smallestIndex = i;
                }
            return smallestIndex;
        }


        //? СОРТИРОВКА ВЫБОРОМ ( O(n^2) )
        /*
            вход: список
            выход: новый отсортированный список
         */
        public static List<int> SelectionSort(List<int> list)
        {
            var newArr = new List<int>(list.Count);
            int _ = list.Count;
            for (int i = 0; i < _; i++)
            {
                int smallest = FindSmallest(list);
                newArr.Add(list[smallest]);
                list.RemoveAt(smallest);
            }

            return newArr;
        }


    }
    internal class GraphsActions
    {
        //? Алгоритм Беллмана-Форда, выводит кратчайшие пути от узла start до всех остальных O(VE)
        // вывод: массив 
        public int[] BellmanFord(Graph graph, char start)
        {
            int vertices = graph.GetVerticesCount();
            int[] distances = new int[vertices];

            for (int i = 0; i < vertices; distances[i++] = int.MaxValue) ;
            distances[start - 'A'] = 0; // символы узлов графа должны быть по алфавиту без "перескоков" (то есть, A, B, D - ошибка, нужно A,B,C)

            for (int i = 0; i < vertices - 1; i++)
                foreach (var edge in graph.GetEdges())
                {
                    int u = edge.Source - 'A'; //от
                    int v = edge.Destination - 'A'; //куда
                    int w = edge.Weight;


                    if (distances[u] != int.MaxValue && distances[v] > distances[u] + w)
                        distances[v] = distances[u] + w;
                }

            for (int i = 0; i < vertices - 1; i++)
                foreach (var edge in graph.GetEdges())
                {
                    int u = edge.Source - 'A'; //от
                    int v = edge.Destination - 'A'; //куда
                    int w = edge.Weight;


                    if (distances[u] != int.MaxValue && distances[v] > distances[u] + w)
                        throw new InvalidOperationException("Граф содержит отрицательный цикл");
                }




            return distances;
        }

        //? Поиск кратчайшего пути невзвешенного направленного графа от узла start до узла end с помощью BFS
        /*
            Вывод: в консоль все узлы от start -> ... -> end
         */
        /*
            Пример:
            var graph = new Dictionary<string, string[]>();

            graph["A"] = new[] { "B", "C" };
            graph["B"] = new[] { "D" };
            graph["C"] = new[] { "E", "F", "G" };
            graph["D"] = new[] { "G" };
            graph["E"] = new[] { "G" };
            graph["F"] = new[] { "D" };
            graph["G"] = new[] { "" };
            BFS(graph, "A", "G");

        */
        public void BFS(Dictionary<string, string[]> graph, string start, string end)
        {
            // Проверка наличия начального и конечного узлов в графе
            if (!graph.ContainsKey(start) || !graph.ContainsKey(end))
            {
                Console.WriteLine("Неверные входные данные.");
                return;
            }

            // Очередь для поиска в ширину
            Queue<string> queue = new Queue<string>(); // FIFO

            // Словарь для отслеживания родительских узлов (для восстановления пути)
            Dictionary<string, string> parent = new Dictionary<string, string>();

            // Множество посещенных узлов
            HashSet<string> visited = new HashSet<string>();

            // Добавляем начальный узел в очередь и помечаем его как посещенный
            queue.Enqueue(start);
            visited.Add(start);
            parent[start] = "";

            bool found = false;

            while (queue.Count > 0)
            {
                // Извлекаем текущий узел из очереди
                string current = queue.Dequeue();

                // Если текущий узел равен конечному узлу, значит путь найден
                if (current == end)
                {
                    found = true;
                    break;
                }

                // Перебираем соседей текущего узла
                foreach (string neighbor in graph[current])
                {
                    // Проверяем, не посещали ли уже соседний узел
                    if (!visited.Contains(neighbor))
                    {
                        // Добавляем соседний узел в очередь, отмечаем его как посещенный и устанавливаем родительский узел
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                        parent[neighbor] = current;
                    }
                }
            }

            Console.WriteLine(string.Join("\n", parent.Select(x => $"{x.Key} - {x.Value}")));

            if (found)
            {
                // Восстанавливаем кратчайший путь от конечного узла до начального
                List<string> path = new List<string>();
                string node = end;

                while (node != "")
                {
                    path.Add(node);
                    node = parent[node];
                }

                // Используем List.Reverse(), чтобы получить путь от начального узла до конечного
                path.Reverse();

                Console.WriteLine("Кратчайший путь от {0} до {1}: {2}", start, end, string.Join(" -> ", path));
            }
            else
            {
                Console.WriteLine("Путь от {0} до {1} не найден.", start, end);
            }
        }

        //? Поиск кратчайшего пути алгоритмом Дейкстры  ( O(n^2) - ? )
        /*
            Вход; граф вида <узел, <его соседи, вес>>, словарь стоимостей, словарь родителей
            Выход: цена наименьшего пути (но можно передалать, чтобы выводил сами узлы)
         */
        /*
        // пример
            // узел, <его соседи, вес>
            var graph = new Dictionary<string, Dictionary<string, int>>();
            graph["start"] = new Dictionary<string, int>();
            graph["start"]["a"] = 6;
            graph["start"]["b"] = 2;
            graph["start"]["c"] = 1;

            graph["a"] = new Dictionary<string, int>();
            graph["a"]["end"] = 1;

            graph["b"] = new Dictionary<string, int>();
            graph["b"]["a"] = 3;
            graph["b"]["end"] = 5;

            graph["c"] = new Dictionary<string, int>();
            graph["c"]["a"] = 3;
            graph["c"]["d"] = 1;

            graph["d"] = new Dictionary<string, int>();
            graph["d"]["f"] = 1;

            graph["f"] = new Dictionary<string, int>();
            graph["f"]["end"] = 0;

            graph["end"] = new Dictionary<string, int>();


            //словарь стоимостей
            var costs = new Dictionary<string, int>();
            costs["a"] = 6;
            costs["b"] = 2;
            costs["c"] = 1;
            costs["d"] = int.MaxValue;
            costs["f"] = int.MaxValue;
            costs["end"] = int.MaxValue;
            //словарь родителей
            var parents = new Dictionary<string, string>();
            parents["a"] = "start";
            parents["b"] = "start";
            parents["c"] = "start";
            parents["d"] = "c";
            parents["f"] = "d";
            parents["end"] = "";

            Console.WriteLine(ob.Alg_Deykstri(graph, costs, parents, out List<string> path));
            path.ForEach(x => Console.Write(x + " "));
        */
        public int Alg_Deykstri(Dictionary<string, Dictionary<string, int>> graph,
                         Dictionary<string, int> costs,
                         Dictionary<string, string> parents, out List<string> path)
        {
            HashSet<string> processed = new HashSet<string>();
            string node = Find_lowest_cost_node(costs, processed);
            for (; node != "";)
            {
                int cost = costs[node];
                var neighbors = graph[node];

                foreach (var n in neighbors.Keys)
                {
                    int new_cost = cost + neighbors[n];
                    if (costs[n] > new_cost)
                    {
                        costs[n] = new_cost;
                        parents[n] = node;
                    }
                }

                processed.Add(node);
                node = Find_lowest_cost_node(costs, processed);
            }

            path = new List<string>();
            node = "end";
            path.Add(node);

            for (; node != "start";)
            {
                path.Add(parents[node]);
                node = parents[node];
            }

            path.Reverse();

            return costs["end"];
        }

        private static string Find_lowest_cost_node(Dictionary<string, int> costs, HashSet<string> processed)
        {
            int lowest_cost = int.MaxValue;
            string lowest_cost_node = "";

            foreach (var node in costs.Keys)
            {
                int cost = costs[node];
                if (cost < lowest_cost && !processed.Contains(node))
                {
                    lowest_cost = cost;
                    lowest_cost_node = node;
                }
            }

            return lowest_cost_node;
        }


        internal class Graph //? для беллмана-форда
        {
            private int V; // количество вершин
            private List<Edge> edges; // список ребер


            public Graph(int vertices)
            {
                V = vertices;
                edges = new List<Edge>();
            }

            public void AddEdge(char source, char destination, int weight) =>
                edges.Add(new Edge(source, destination, weight));


            public List<Edge> GetEdges() => edges;

            public int GetVerticesCount() => V;

        }
        internal class Edge
        {
            public char Source { get; set; }
            public char Destination { get; set; }
            public int Weight { get; set; }

            public Edge(char source, char destination, int weight)
            {
                Source = source;
                Destination = destination;
                Weight = weight;
            }
        }

    }
    internal class StringActions
    {
        public int DamerauLevan_Distance(string source, string target)
        {
            if (string.IsNullOrEmpty(source))
                return string.IsNullOrEmpty(target) ? 0 : target.Length;
            if (string.IsNullOrEmpty(target))
                return source.Length;

            var n = source.Length;
            var m = target.Length;
            var distance = new int[2, m + 1];

            for (var j = 1; j <= m; distance[0, j] = j++) ;

            var currentRow = 0;
            bool transposition = false;
            for (var i = 1; i <= n; i++)
            {
                currentRow = i & 1;
                distance[currentRow, 0] = i;
                var previousRow = currentRow ^ 1;
                for (var j = 1; j <= m; j++)
                {
                    var cost = (target[j - 1] == source[i - 1] ? 0 : 1);
                    distance[currentRow, j] = Math.Min(Math.Min(
                        distance[previousRow, j] + 1,
                        distance[currentRow, j - 1] + 1),
                        distance[previousRow, j - 1] + cost);
                    if (i > 1 && j > 1 && source[i - 2] == target[j - 1] && source[i - 1] == target[j - 2])
                    {
                        distance[currentRow, j] = Math.Min(distance[currentRow, j], distance[previousRow - 1, j - 1] + cost);
                        transposition = true;
                    }
                }
                if (transposition)
                    distance[currentRow, m] = Math.Min(distance[currentRow, m], distance[previousRow - 1, m - 1]);
            }

            return distance[currentRow, m];

        }
    }

}
