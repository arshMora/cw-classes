using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bred_bolnogo_shizofreniyey_s_maniyey_velichiya
{
    internal class OwnMath
    {
    // находит общие наим. и наиб. делители
        public bool NOD(int x, int y, out int least, out int greatest)
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

        // число Фибоначчи от его последовательности 
        public int Fibonacci(int n)
        {

            int f1 = 1;
            int f2 = 1;
            int fn = f2;

            for (int i = 2; i < n; i++)
            {
                if (n < 2) return 1;
                else
                {
                    fn = f2 + f1;
                    f1 = f2;
                    f2 = fn;
                }
            }

            return fn;
        }
    }

    internal class ArrayActions
    {
        Random rand = new Random();

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
        //? быстрая сортировка
        /*public int[] QuickSort()
        {

        }*/
        static int FindPivot(int[] numbers, int minIdx, int maxIdx)
        {
            int pivot = minIdx-1;
            int temp = 0;
            for (int i = minIdx; i < maxIdx; i++)
                if (numbers[i] < numbers[maxIdx])
                {
                    pivot++;
                    temp = numbers[pivot];
                    numbers[pivot] = numbers[i];
                    numbers[i] = temp;
                }

            pivot++;
            temp = numbers[pivot];
            numbers[pivot] = numbers[maxIdx];
            numbers[maxIdx] = temp;

            return pivot;
        }




        //? БИНАРНЫЙ ПОИСК ( O(log_2(n) )
        // входные элементы: отсортированный список, искомое значение
        // выходные данные: индекс искомого значения
        static int Binary_search(List<int> list, int item)
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
        // входные данные: список
        // выходные данные: индекс наименьшего элемента
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
        // вход: список
        // выход: новый отсортированный список
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
}
