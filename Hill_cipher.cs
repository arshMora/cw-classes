using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bred_bolnogo_shizofreniyey_s_maniyey_velichiya;

namespace Hill_cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ob = new ArrayActions();
            Console.WriteLine("Текст: ");
            var sourceText = Console.ReadLine().ToUpper();

            var alphabet = new Dictionary<char, int>
            {
                {'А', 0},{'Б', 1},{'В', 2},{'Г', 3},{'Д', 4},{'Е', 5},{'Ё', 6},{'Ж', 7},{'З', 8},
                {'И', 9},{'Й', 10},{'К', 11},{'Л', 12},{'М', 13},{'Н', 14},{'О', 15},{'П', 16},{'Р', 17},
                {'С', 18},{'Т', 19},{'У', 20},{'Ф', 21},{'Х', 22},{'Ц', 23},{'Ч', 24},{'Ш', 25},{'Щ', 26},
                {'Ъ', 27},{'Ы', 28},{'Ь', 29},{'Э', 30},{'Ю', 31},{'Я', 32},{'.', 33},{',', 34},{' ', 35},
                {'?', 36}
            };

            var encodedText = sourceText.ToArray().Select(x => alphabet[x]).ToList();
            var encodedKey = "АЛЬПИНИЗМ".ToArray().Select(x => alphabet[x]).ToList();

            Console.WriteLine("Закодированный текст: ");
            encodedText.ForEach(x => Console.Write(x + " ")); Console.WriteLine();
            Console.WriteLine("Закодированный ключ: ");
            encodedKey.ForEach(x => Console.Write(x + " ")); Console.WriteLine("\n");


            var keyMatrix = new int[3, 3];
            for (int i = 0, c = 0; i < keyMatrix.GetLength(0); i++)
                for (int j = 0; j < keyMatrix.GetLength(1); j++)
                    keyMatrix[i, j] = encodedKey[c++];

            Console.WriteLine("Ключ в виде матрицы");
            ob.Display(keyMatrix);

            // Вычисление количества блоков
            int numBlocks = (int)Math.Ceiling((double)encodedText.Count / 3);

            // Матрица блоков
            var units = new int[numBlocks, 3];

            // заполнение матрицы блоков
            for (int i = 0, idx = 0, encTL = encodedText.Count; i < numBlocks; i++)
                for (int j = 0; j < 3; j++, idx++)
                    units[i, j] = idx < encTL ? encodedText[idx] : 35;

            Console.WriteLine("Матрица блоков шифра");
            ob.Display(units);

            // умножение блоков на матрицу-ключ
            static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
            {
                int rowsA = matrixA.GetLength(0);
                int colsA = matrixA.GetLength(1);
                int rowsB = matrixB.GetLength(0);
                int colsB = matrixB.GetLength(1);

                int[,] result = new int[rowsA, colsB];

                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsB; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < colsA; k++)
                        {
                            sum += matrixA[i, k] * matrixB[k, j];
                        }
                        result[i, j] = sum % 37;
                    }
                }

                return result;
            }

            var mM = MatrixMultiplication(units, keyMatrix);
            Console.WriteLine("Результат перемножения матрицу блоков текста на ключ-матрицу(+ %37):");
            ob.Display(mM);

            // декодирование матрицы-блоков
            var decMM = "";
            for (int i = 0; i < mM.GetLength(0); i++)
                for (int j = 0; j < mM.GetLength(1); j++)
                    decMM += alphabet.Where(x => x.Value == mM[i, j]).FirstOrDefault().Key;

            Console.WriteLine("Итоговый зашифрованный текст:\n" + decMM);

            Console.ReadLine();
        }
    }
}
