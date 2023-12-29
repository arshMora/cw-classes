using bred_bolnogo_shizofreniyey_s_maniyey_velichiya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
/*//x  pseudo-benchmark
var startTime = System.Diagnostics.Stopwatch.StartNew();
for (int benchIt = 0; benchIt < 1; benchIt++)
{
    var k = 200000;
    for (int i = 0; i < 1; i++)
    {
        var products = s.Split().Select(x => int.Parse(x)).ToArray();
        int sum = 0;
        Array.Sort(products);
        for (int j = 1; j < k; j++)
        {
            int count = 1;
            while (j < k && products[j] == products[j - 1])
            {
                count++;
                j++;
            }
            sum += count * products[j - 1] - (products[j - 1] * (count / 3 > 0 ? count / 3 : 0));
        }
        Console.WriteLine(sum);
    }
}
startTime.Stop();
var resultTime = startTime.Elapsed;
Console.WriteLine(resultTime);*/


//x                  .ToList().ForEach(x => Console.Write(x + " "));

/*class Main_3Katas
{
    static void Main(string[] args)
    {
        
    }
}*/


/*//! -> (не решен) Prime Streaming (PG-13)
public class Primes
{
    public static IEnumerable<int> Stream3()
    {
        List<int> primes = new() { 2, 3, 5 };
        int nMax = 100000, n = primes.Last() + 1;
        while (n <= nMax)
        {
            if (primes.All(divisor => n % divisor != 0))
                primes.Add(n);
            n++;
        }

        return primes;
    }
    public static IEnumerable<int> Stream2() =>
            Enumerable.Range(2, 1000000)
            .Where(number =>
            Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
            .All(divisor => number % divisor != 0)); //todo best
    public static IEnumerable<int> Stream()
    {
        List<int> primes = new() { 2 };

        for (int n = 3; n < 1000000; n++)
        {
            if (n <= 2 || n % 2 == 0)
                continue;
            var x = Math.Sqrt(n);
            bool prime = true;
            for (int i = 3; i <= x; i += 2)
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            if (prime)
                primes.Add(n);
        }
        return primes;
    }
}*/
/*//! ->  Make a spiral
public class Spiralizor
{
    public static int[,] CW2Spiralize(int size)
    {
        var spiral = new int[size, size];
        foreach (var p in Walk(-2, 0, 1, 0, size + 1))
        {
            spiral[p.y, p.x] = 1;
        }
        return spiral;
    }
    private static IEnumerable<(int x, int y)> Walk(int x, int y, int dx, int dy, int l)
    {
        if (l <= 0) yield break;
        for (var i = 0; i < l; i++)
        {
            x += dx;
            y += dy;
            if (x >= 0) yield return (x, y);
            if (l == 1) yield break;
        }
        foreach (var next in Walk(x, y, -dy, dx, dy == 0 ? l - 2 : l))
        {
            yield return next;
        }
    }
    //--------------------------------
    public static int[,] CW1Spiralize(int n)
    {
        var map = new int[n, n];
        int dx = 1, dy = 0;
        int x = 0, y = 0;
        int s = n - 1;

        for (int k = 0; k <= n; k++)
        {
            // fill line in dig direction
            for (int j = 0; j < s; j++)
                (map[y, x], x, y) = (1, x + dx, y + dy);

            // rotate digger clockwise
            (dx, dy) = (-dy, dx);

            // find next line length
            // it's a simple sequence with difference between even and odds n's
            // for n=11: 10 10 10 8 8 6 6 4 4 2 2 1
            // for n=10:  9  9  9 7 7 5 5 3 3 1 1 - two 1 on even n's
            // for n= 9:  8  8  8 6 6 4 4 2 2 1
            // for n= 9:  7  7  7 5 5 3 3 1 1
            if (k > 0 && k % 2 == 0) s -= 2;
            if (s < 1) s = 1;
        }

        return map;
    }
    public static int[,] Spiralize(int size)
    {
        //var ob = new ArrayActions();
        var spiral = new int[size, size];
        int y = 0, x = 0; // вертикаль/горизонталь
        int xRightBorder, yTopBorder = xRightBorder = size;
        int xLeftBorder = 0, yBottomBorder = xLeftBorder + 2;
        bool xTurn = true, yTurn = false;

        for (int i = 0; i < size; i++)
            if (x < xRightBorder && xTurn)
            {
                for (; x < xRightBorder; x++)
                    spiral[y, x] = 1;
                x--;
                y++;
                xTurn = !xTurn;
                yTurn = !yTurn;
                xRightBorder -= 2;
            }
            else if (y < yTopBorder && yTurn)
            {
                for (; y < yTopBorder; y++)
                    spiral[y, x] = 1;
                y--;
                x--;
                yTurn = !yTurn;
                xTurn = !xTurn;
                yTopBorder -= 2;
            }
            else if (x >= xLeftBorder && xTurn)
            {
                for (; x >= xLeftBorder; x--)
                    spiral[y, x] = 1;
                x++;
                y--;
                yTurn = !yTurn;
                xTurn = !xTurn;
                xLeftBorder += 2;
            }
            else if (y >= yBottomBorder && yTurn)
            {
                for (; y >= yBottomBorder; y--)
                    spiral[y, x] = 1;
                x++;
                y++;
                yTurn = !yTurn;
                xTurn = !xTurn;
                yBottomBorder += 2;
            }

        //ob.Display(spiral);

        return spiral;
    } //todo best
}*/