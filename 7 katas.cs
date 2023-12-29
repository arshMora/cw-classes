using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/*//x  pseudo-benchmark

var startTime = System.Diagnostics.Stopwatch.StartNew();
for (int benchIt = 0; benchIt < 1000000; benchIt++)
{

}
startTime.Stop();
var resultTime = startTime.Elapsed;
Console.WriteLine(resultTime.Milliseconds);*/


//x                  .ToList().ForEach(x => Console.Write(x + " "));
internal class _7Kata
{
    /*//! ->  Check the exam
    public static int CW2CheckExam(string[] arr1, string[] arr2)
    {
        var score = 0;
        for (int i = 0; i < arr1.Length; i++)
            score += arr2[i] == "" ? 0 : arr1[i] == arr2[i] ? 4 : -1;
        return score > 0 ? score : 0;
    } //todo best
    public static int CW1CheckExam(string[] arr1, string[] arr2)
    {
        return Math.Max(arr2.Select((s, i) => s == "" ? 0 : s == arr1[i] ? 4 : -1).Sum(), 0);
    }
    public static int CheckExam(string[] arr1, string[] arr2)
    {
        int score = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] == "" || arr2[i] == "")
                continue;

            if (arr1[i] == arr2[i])
                score += 4;
            else
                score -= 1;
        }

        return score < 0 ? 0 : score;
    }*/
    /*//! ->  Small enough? - Beginner
    public static bool CW1SmallEnough(int[] a, int limit) => Array.TrueForAll(a, x => x <= limit); //todo best
    public static bool SmallEnough(int[] a, int limit) => !a.Any(x => x > limit);*/
    /*//! ->  Sum of two lowest positive integers
    public static int CW1sumTwoSmallestNumbers(int[] numbers)
    {
        if (numbers == null)
        {
            throw new ArgumentNullException("numbers");
        }

        if (numbers.Length < 2)
        {
            throw new ArgumentException("numbers", "The array must have at least two elements.");
        }

        var x = int.MaxValue;
        var y = int.MaxValue;

        foreach (var z in numbers)
        {
            if (z < x)
            {
                y = x;
                x = z;
            }
            else if (z < y)
            {
                y = z;
            }
        }

        return x + y;
    }
    public static int sumTwoSmallestNumbers(int[] numbers) => numbers.OrderBy(x => x).Take(2).Sum();*/
    /*//! ->  Find the middle element
    public static int CW1Gimme(double[] inputArray) => 
        inputArray.ToList().IndexOf(inputArray.OrderBy(d => d).ElementAt(1)); //todo best
    public static int Gimme(double[] arr) =>
        Array.FindIndex(arr, x => x == arr.OrderBy(x => x).ToArray()[1]);*/
    /*//! ->  Fix string case
    public static string Solve(string s) =>
        //Count(char.IsUpper)
        s.Count(x => char.IsUpper(x)) > s.Length / 2 ? s.ToUpper() : s.ToLower();*/
    /*//! ->  Is this a triangle?
    public static bool IsTriangle(int a, int b, int c) => a + b > c && a + c > b && b + c > a;*/
    /*//! ->  Categorize New Member
    public static IEnumerable<string> CW1OpenOrSenior(int[][] data)
    {
        return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open");
    } //todo best
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        IEnumerable<string> categories = new List<string>();
        foreach (var c in data)
        {
            categories = categories.Append(c[0] < 55 ? string.Concat("Open") : c[1] < 8 ? string.Concat("Open") : string.Concat("Senior"));
        }

        return categories;
    }*/
    /*//! ->  Count the Digit
    public static int CW1NbDig(int n, int d)
    {
        return Enumerable.Range(0, n + 1).Select(x => (x * x).ToString().Count(y => y - 48 == d)).Sum();
    }
    public static int CW2NbDig(int n, int d)
    {
        var result = d == 0 ? 1 : 0;

        for (var k = 1; k <= n; ++k)
            for (var x = k * k; x != 0; x /= 10)
                if (x % 10 == d)
                    ++result;

        return result;
    } //todo best
    public static int NbDig(int n, int d)
    {
        int dCount = d == 0 ? 1 : 0;
        for (int i = 0; i <= n; i++)
        {
            int iSquare = i * i;
            for (; iSquare > 0 ; )
            {
                int digits = iSquare % 10;
                if (digits == d)
                    dCount++;
                iSquare /= 10;
            }
        }
        return dCount;
    }*/
    /*//! ->  Money, Money, Money
    public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
    {
        if (principal == desiredPrincipal)
            return 0;

        int years = 0;

        for (; principal < desiredPrincipal; )
        {
            principal += principal * interest - principal * interest * tax;
            years++;
            Console.WriteLine(principal + "|" + years);
        }

        return years;
    }*/
    /*//! ->  Sort Numbers
    public static int[] CW1SortNumbers(int[] nums) =>
        nums?.OrderBy(i => i).ToArray() ?? Array.Empty<int>(); //todo best
    public static int[] SortNumbers(int[] nums) => 
        nums?.Length> 0 ? nums.OrderBy(x => x).ToArray() : Array.Empty<int>();*/
    /*//! ->  Get the Middle Character
    public static string CW1GetMiddle(string s)
    {
        return string.IsNullOrEmpty(s)
            ? s
            : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
    }
    public static string GetMiddle(string s) =>
        s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : $"{s[s.Length / 2]}";*/
    /*//! ->  Beginner Series #4 Cockroach
    public static int CW1CockroachSpeed(double x) //todo best  
      => (int)(x / 0.036);  //? (x *  27.778); 
    public static int CockroachSpeed(double x) => (int)(x * 100000 / 3600);*/
    /*//! ->  Grasshopper - Check for factor
    public static bool CheckForFactor(int num, int factor) => num % factor == 0;*/
    /*//! ->  Count by X
    public static int[] CountBy2(int x, int n)
    {
        var ret = new int[n];
        for (int i = 1, j = 0; i <= n; ret[j++] = i++ * x) ;
        return ret;
    }
    public static int[] CountBy(int x, int n) => Enumerable.Range(1, n).Select(c => x * c).ToArray();*/
    /*//! ->  Count the divisors of a number
    public static int CW1Divisors(int n)
    {
        // todo
        var numberOfDivisors = 0;
        for (int i = 1; i <= n / 2; i++)
            if (n % i == 0)
                numberOfDivisors++;

        return numberOfDivisors;
    }
    public static int Divisors(int n) => Enumerable.Range(1, n/2).Count(x => n % x == 0)+1;*/
    /*//! ->  Reverse words
    public static string CW1ReverseWords(string str) => 
        string.Join(" ", str.Split().Select(x => string.Concat(x.Reverse()))); //todo best
    public static string ReverseWords(string str) =>
        string.Join(" ", str.Split().Select(x => new string(x.Reverse().ToArray())));*/
    /*//! ->  Testing 1-2-3
    public static List<string> Number(List<string> lines) =>
        lines.Select((x, i) => $"{i + 1}: {x}").ToList();*/
    /*//! ->  Anagram Detection
    public static bool IsAnagram(string test, string original) =>
        string.Concat(test.ToLower().OrderBy(c => c)) == string.Concat(original.ToLower().OrderBy(c => c));*/
    /* //! ->  Two to One
    public static string CW1Longest(string s1, string s2) =>
        new string((s1 + s2).Distinct().OrderBy(x => x).ToArray());
    public static string Longest(string s1, string s2) =>
        String.Concat((s1 + s2).Distinct().OrderBy(c => c));*/
    /*//! ->  Descending Order
    public static int DescendingOrder(int num) => int.Parse(string.Concat(num.ToString().OrderByDescending(c => c)));
    public static int DescendingOrder2(int n)
    {
        if (n == 0)
            return 0;

        var f = new List<long>();

        for (; n > 0;)
        {
            f.Add(n % 10);
            n /= 10;
        }
        return Convert.ToInt32(string.Concat(f.OrderByDescending(x => x)));
    }*/
    /*//! ->  Sum of a sequence
    public static class Kata
    {
        public static int CW1SequenceSum(int start, int end, int step)
        {
            int sum = 0;

            for (int i = start; i <= end; i += step)
            {
                sum += i;
            }

            return sum;
        }
        public static int CW2SequenceSum(int start, int end, int step)
        {
            return start == end ? end : start > end ? 0 : SequenceSum(start + step, end, step) + start;
        }
        public static int CW3SequenceSum(int start, int end, int step) //todo best
        {
            if (start > end)
            {
                return 0;
            }

            var n = (end - start) / step;

            return start * (n + 1) + step * n * (n + 1) / 2;
        }
        public static int SequenceSum(int start, int end, int step)
        {
            int s = 0;
            int f = start;

            while (f <= end)
            {
                s += f;
                f += step;
            }

            Console.WriteLine(s);
            return -1;
        }
    }*/
    /*//! ->  Square Every Digit
    public class Kata
    {
        public static int CW3SquareDigits(int n)
        {
            var result =
                n
                .ToString()
                .Select(Char.GetNumericValue)
                .Select(a => (a * a).ToString())
                .Aggregate("", (acc, s) => acc + s);
            return int.Parse(result);
        }
        public static int CW2SquareDigits(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += square * square;
            }
            return int.Parse(output);
        } // в строку можно записывать мат.выражения (string n = 2 * 2 //4 - string)
        public static int CW1SquareDigits(int n) => 
            int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
        public static int SquareDigits(int n)
        {
            if (n == 0)
                return 0;

            var ret = new List<double>();
            for (; n > 0;)
            {
                ret.Add(Math.Pow(n % 10, 2));
                n /= 10;
            }
            return Convert.ToInt32(string.Concat(ret.Select(x => x).Reverse()));
        }//todo best
    }*/
    /* //! ->  Ones and Zeros
    class Kata
    {
        public static int CW2binaryArrayToNumber(int[] BinaryArray)
        {
            return BinaryArray.Aggregate((value, bit) => (value << 1) | bit);
        }
        public static int CW1binaryArrayToNumber(int[] BinaryArray) //todo best
        {
            int sum = 0;

            for (int i = BinaryArray.Length - 1, p = 0; i > -1; i--, p++)
                if (BinaryArray[i] > 0) sum += (int)Math.Pow(2, p);

            return sum;
        }
        public static int binaryArrayToNumber(int[] BinaryArray) => 
            Convert.ToInt32(string.Concat(BinaryArray), 2); //todo best
    }*/
    /* //! ->  Printer Errors
        public class Printer
        {
            public static string CW1PrinterError(string s)
            {
                return s.Where(c => c > 'm').Count() + "/" + s.Length;
            }
            public static string PrinterError(String s) => $"{s.Length - Regex.Replace(s, "[^a-m]", "").Length}/{s.Length}";
        }
    */
    /*//! ->  Exes and Ohs
    public static class Kata
    {
    //Kata.XO("xxxm");
        public static bool CW1(string input)
        {
            input = input.ToLower();
            int count1 = input.Where(x => x == 'x').Count();
            int count2 = input.Where(x => x == 'o').Count();

            return (count1 == count2);
        }
        public static bool CW2(string input)
        {
            // (?i) - делает нечувствительным регистр
            return Regex.Matches(input, "(?i)o").Count == Regex.Matches(input, "(?i)x").Count;
        }
        public static bool XO(string input) => input.ToLower().Count(x => x == 'x') == input.ToLower().Count(x => x == 'o');
    }*/
}
