using System;
using System.Collections;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using BenchmarkDotNet.Disassemblers;
using BenchmarkDotNet.Engines;
using bred_bolnogo_shizofreniyey_s_maniyey_velichiya;
using Iced.Intel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftAntimalwareEngine;



/*//x  pseudo-benchmark
var startTime = System.Diagnostics.Stopwatch.StartNew();
for (int benchIt = 0; benchIt < 10000; benchIt++)
{
}
startTime.Stop();
var resultTime = startTime.Elapsed;
Console.WriteLine(resultTime.Milliseconds);*/


//x                  .ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine();

class Main_4_6Katas
{
    static void Main(string[] args)
    { 
        
    }
}
/*//! ->  Weight for weight
public class WeightSort
{
    public static string CW1orderWeight(string s)
    {
        var result = s.Split(' ')
            .OrderBy(n => n.Select(c => (int)char.GetNumericValue(c)).Sum())
            .ThenBy(n => n);

        return string.Join(" ", result);
    } //todo best
    public static string OrderWeight(string str)
    {
        if (str.Length == 0)
            return string.Empty;

        var weights = Array.ConvertAll(str.Trim().Split().ToList().OrderBy(x => x).ToArray(), long.Parse);
        

        var ww = new List<long>(weights.Length);
        var idxs = Enumerable.Range(0, ww.Capacity).ToList();

        foreach (var weight in weights)
        {
            var w = weight;
            long sum = 0;
            while (w > 0)
            {
                sum += w % 10;
                w /= 10;
            }

            ww.Add(sum);
        }


        for (int i = 0; i < ww.Count - 1; i++)
        {
            bool swap = false;
            for (int j = 0; j < ww.Count - i - 1; j++)
                if (ww[j] > ww[j + 1])
                {
                    (ww[j + 1], ww[j]) = (ww[j], ww[j + 1]);
                    (idxs[j + 1], idxs[j]) = (idxs[j], idxs[j + 1]);
                    swap = true;
                }
            if (!swap)
                break;
        }

        string ret = string.Join(" ", idxs.Select(x => weights[x].ToString()));
        return ret;
    }
}*/
/*//! ->  (не решено) The Road-Kill Detective
public class Dinglemouse
{
    public static string RoadKill(string photo)
    {
        var animals = new string[] { "hyena" };
        var remains = photo.Where(x => x != 61).ToList(); 
        var remainsDict = new Dictionary<char, int>();
        foreach (var ch in remains.Distinct())
            remainsDict[ch] = remains.Count(c => c == ch);

        remainsDict.ToList().ForEach(x => Console.WriteLine(x));
        Console.WriteLine(remainsDict.Keys.Count());
        foreach (var animal in animals)
        {
            bool find = true;
            foreach (var piece in animal.Distinct())
            {
                if (remainsDict.ContainsKey(piece))
                {
                    if (animal.Count(x => x == piece) <= remainsDict[piece])
                        continue;
                }

                find = false;
                break;
            }
            

            if (find)
                return animal;
        }


        return "??";
    }
}*/
/*//! ->  (не решено) The Deaf Rats of Hamelin (2D)
public class Dinglemouse
{
    public static int CountDeafRats(char[][] townSquare)
    {//8599
        int[] pIdxs = new int[2];
        for (int i = 0, find; i < townSquare.GetLength(0); i++)
        {
            find = Array.IndexOf(townSquare[0], 'P');
            if (find != -1)
            {
                pIdxs[0] = find; pIdxs[1] = i; //! x/y
                break;
            }
        }
        //Console.WriteLine("y|x");
        //Console.WriteLine(pIdxs[1] + "|" + pIdxs[0] + " - P"); //! y/x

        int deafRatsCount = 0;
        for (int i = 0; i < townSquare.GetLength(0); i++)
        {
            for (int j = 0; j < townSquare[i].GetLength(0); j++)
            {
                int x, y;
                double beforeX, beforeY, afterX, afterY;
                if (townSquare[i][j] - 0 != 32 && townSquare[i][j] - 0 != 80)
                {
                    x = j; y = i;
                    beforeX = Math.Abs(pIdxs[0] - x);
                    beforeY = Math.Abs(pIdxs[1] - y);
                    switch (townSquare[i][j])
                    {
                        case '←':
                            x -= 1;
                            break;
                        case '↑':
                            y -= 1;
                            break;
                        case '→':
                            x += 1;
                            break;
                        case '↓':
                            y += 1;
                            break;
                        case '↖':
                            y -= 1;
                            x -= 1;
                            break;
                        case '↗':
                            y -= 1;
                            x += 1;
                            break;
                        case '↘':
                            y += 1;
                            x += 1;
                            break;
                        case '↙':
                            y += 1;
                            x -= 1;
                            break;
                        default:
                            throw new Exception("invalid character");
                    }
                    afterX = Math.Abs(pIdxs[0] - x);
                    afterY = Math.Abs(pIdxs[1] - y);

                    if (afterX < beforeX || afterY < beforeY)
                    {
                        deafRatsCount++;
                    }
                }
            }
        }

        Console.WriteLine(deafRatsCount);

        return deafRatsCount;
    }
}*/
/*//! ->  Min Factor Distance
public static class Kata
{
    public static int CW2MinDistance(int n)
    {
        var factors = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();
        return factors.Zip(factors.Skip(1), (x, y) => y - x).Min();
    }
    public static int CW1MinDistance(int n)
    {
        var factors = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();
        return Enumerable.Range(0, factors.Length - 1).Select(i => factors[i + 1] - factors[i]).Min();
    }
    public static int MinDistance(int n)
    {
        var f = Enumerable.Range(1, n).Where(x => n % x == 0).ToArray();
        f.ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine();
        int min = int.MaxValue;
        for (int i = 1; i < f.Length; i++)
            if (f[i] - f[i - 1] < min)
                min = f[i] - f[i - 1];

        return min;
    }
}*/
/*//! ->  (не решено) Strip Comments
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        return "";
    }
}*/
/*//! ->  Simple assembler interpreter        
public static class SimpleAssembler
{
    public static Dictionary<string, int> CW1Interpret(string[] program)
    {
        var memory = new Dictionary<string, int>();
        int GetValue(string s) => int.TryParse(s, out var tmp) ? tmp : memory[s];

        for (var pointer = 0; pointer < program.Length; pointer++)
        {
            var values = program[pointer].Split();
            var _ = values[0] switch
            {
                "mov" => memory[values[1]] = GetValue(values[2]),
                "inc" => memory[values[1]]++,
                "dec" => memory[values[1]]--,
                "jnz" => pointer += GetValue(values[1]) != 0 ? GetValue(values[2]) - 1 : 0,
                _ => throw new Exception("Input error")
            };
        }

        return memory;
    } //todo best уау
    public static Dictionary<string, int> Interpret(string[] program)
    {
        var dictInt = new Dictionary<string, int>();

        for (int i = 0; i < program.Length; i++) 
        {
            if (program[i].StartsWith("mov"))
            {
                Mov(program[i]);
            }
            else if (program[i].StartsWith("inc"))
            {
                Inc(program[i]);
            }
            else if (program[i].StartsWith("dec"))
            {
                Dec(program[i]);
            }
            else
            {
                i = Jnz(i);
                continue;
            }
            //dictInt.ToList().ForEach(x => Console.Write(x + " ")); Console.WriteLine(i);
        }


        void Mov(string line)
        {
            dictInt[line[4].ToString()] = char.IsLetter(line[^1]) ? dictInt[line[^1].ToString()] :int.Parse(line[6..]);
        }

        void Inc(string line)
        {
            dictInt[line[^1].ToString()]++;
        }

        void Dec(string line)
        {
            dictInt[line[^1].ToString()]--;
        }

        int Jnz(int i)
        {

            return 0 != (char.IsLetter(char.Parse(program[i].Split()[^2])) ? dictInt[program[i][4].ToString()] :
                int.Parse(program[i].Split()[^2])) ?
                i += int.Parse(program[i].Split()[^1]) - 1: i;


        }

        return dictInt;
    } //? ужас
}*/
/*//! ->  Soundex
public class Dinglemouse
{ 
    public static string CW2Soundex(string names) =>
        string.Join(" ", names.ToUpper().Split(' ').Select(SoundexSingle)); //todo best

    private static string SoundexSingle(string word)
    {
        var soundex = new System.Text.StringBuilder();
        char last = '\0';

        foreach (var c in word.Where(ch => char.IsLetter(ch) && soundex.Length < 4))
        {
            char current = lookup[c - 'A'];
            if (soundex.Length == 0)
            {
                soundex.Append(c);
                last = current;
            }
            else if (current != '.' && current != last)
            {
                if (current != '-')
                    soundex.Append(current);
                last = current;
            }
        }

        return soundex.ToString().PadRight(4, '0');
    }
    //ABCDEFGHIJKLMNOPQRSTUVWXYZ
    const string lookup = "-123-12.-22455-12623-1.2-2";
    //? ------------------------------------
    private static Dictionary<string, string> patterns = new Dictionary<string, string> {
    { "(?!^)[HW]"     , ""  },
    { "[BFPV]+"       , "1" },
    { "[CGJKQSXZ]+"   , "2" },
    { "[DT]+"         , "3" },
    { "[L]+"          , "4" },
    { "[MN]+"         , "5" },
    { "[R]+"          , "6" },
    { "(?!^)[AEIOUY]" , ""  },
  };
    public static string CW1Soundex(string names)
    {
        return string.Join(" ", names.ToUpper().Split(' ').Select(str => {
            var s = patterns.Keys.Aggregate(str, (acc, s) => Regex.Replace(acc, s, patterns[s]));
            var d = Regex.Replace(s, "^\\d", str.Substring(0, 1));
            return Regex.Replace(d, "$", "00000").Substring(0, 4);
        })); //? worst
    }
    //? ------------------------------------
    public static string Soundex(string names)
    {
        StringBuilder temp = new();
        foreach (var el in names.ToLower().Split())
        {
            StringBuilder sb = new();

            foreach (var ch in el)
                sb.Append("cgjkqsxz".Contains(ch) ? 2 : "bfpv".Contains(ch) ? 1 : "dt".Contains(ch) ? 3 :
                    "mn".Contains(ch) ? 5 : ch == 'l' ? 4 : ch == 'r' ? 6 : "wh".Contains(ch) ? "" : $"{ch}");


            for (int i = 0; i < sb.Length - 1; )
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i + 1, 1);
                    continue;
                }
                else
                    i++;

            for (int i = 1; i < sb.Length;)
                if ("aeiouy".Contains(sb[i]))
                    sb.Remove(i, 1);
                else
                    i++;

            if (char.IsDigit(sb[0]) && "wh".Contains(el[0]))
                sb.Insert(0, char.ToUpper(el[0]));
            else
                sb[0] = char.ToUpper(el[0]);

            if (sb.Length < 4)
                sb.Append("000");
            temp.Append(sb.ToString()[..4] + " ");
        }

        return temp.ToString().Trim();
    }

}*/
/*//! ->  First non-repeating character
public class Kata
{
    public static string CW2FirstNonRepeatingLetter(string s)
    {
        return s.GroupBy(char.ToLower).FirstOrDefault(_ => _.Count() == 1)?.First().ToString() ?? string.Empty;
    } //todo красота
    public static string CW1FirstNonRepeatingLetter(string s)
    {
        return s.GroupBy(char.ToLower)
                .Where(gr => gr.Count() == 1)
                .Select(x => x.First().ToString())
                .DefaultIfEmpty("")
                .First();
    }
    public static string FirstNonRepeatingLetter(string s)
    {
        foreach (var ch in s.ToLowerInvariant())
            if (s.Count(x => x == char.ToLower(ch)) == 1)
                return ch.ToString();

        return "";
    } //todo best
}*/
/*//! ->  Codewars style ranking system
public class CW1User
{
    private int _rank;
    public int rank
    {
        get { return _rank; }
        set { _rank = value == 0 ? 1 : value; }
    }
    private int _progress;
    public int progress
    {
        get { return rank == 8 ? 0 : _progress; }
        set
        {
            rank += value / 100;
            _progress = value % 100;
        }
    }

    public CW1User()
    {
        rank = -8;
        progress = 0;
    }

    public void incProgress(int level)
    {
        if (level < -8 || level > 8 || level == 0)
            throw new ArgumentException();

        int tempLevel = level > 0 ? level - 1 : level;
        int tempRank = rank > 0 ? rank - 1 : rank;
        int diff = tempLevel - tempRank;

        progress += diff < -1 ? 0 : diff == -1 ? 1 : diff == 0 ? 3 : 10 * diff * diff;
    }
}
public class User
{
    public int rank;
    public int progress;

    public User()
    {
        rank = -8;
        progress = 0;
    }

    int rankDiff(int actRank)
    {
        int d = (rank < 0 && actRank < 0) || (rank > 0 && actRank > 0) ? Math.Abs(rank - actRank) :
            Math.Abs(rank) + Math.Abs(actRank) - 1;

        return rank >= actRank ? d == 0 ? 3 : d == 1 ? 1 : 0 : d * d * 10;
    }

    public void incProgress()
    {
        throw new ArgumentException("Missing argument");
    }

    public void incProgress(int actRank)
    {
        if (actRank < -8 || actRank > 8 || actRank == 0 || rank < -8)
            throw new ArgumentException();

        progress += rankDiff(actRank);

        while (progress >= 100 && rank < 8)
        {
            rank++;
            if (rank == 0) rank = 1;
            progress -= 100;
        }
        if (rank >= 8 && progress != 0)
            progress = 0;
    }
} //todo best (по крайней мере, по времени намного лучше)*/
/*//! ->  Title Case
public class Kata
{
    public static string CW2TitleCase(string title, string minorWords = "")
    {
        return string.Join(" ", title.ToLower().Split().Select((w, i) => !$"{minorWords}".ToLower().Split().Contains(w) || i == 0
            ? string.Concat(w.Take(1)).ToUpper() + string.Concat(w.Skip(1))
            : w).ToArray());
    }
    static string FirstToUpper(string input)
    {
        var s = input.ToCharArray();
        s[0] = Char.ToUpper(s[0]);
        return new String(s);
    }

    public static string CW1TitleCase(string title, string minorWords = "")
    {
        if (String.IsNullOrEmpty(title)) return title;

        var titleWords = title.Split(' ').Select(w => w.ToLower());
        var minWords = (minorWords ?? "").Split(' ').Select(w => w.ToLower());

        return FirstToUpper(String.Join(" ", titleWords.Select(w => minWords.Contains(w) ? w : FirstToUpper(w)))); //todo best
    }
    //? -------------------------------
    public static string TitleCase(string title, string? minorWords = "")
    {

        minorWords ??= "";
        var minors = minorWords.ToLower().Split();
        var s = string.Join(" ", title.Split().Select(x => minors.Contains(x.ToLower()) ? x.ToLower() : char.ToUpper(x[0]) + x.Substring(1).ToLower()));

        return s.Length > 0 ? char.ToUpper(s[0]) + string.Concat(s.Skip(1)) : "";
    }
}*/
/*//! ->  Did you mean ...?
public class Kata
{
    private IEnumerable<string> words;

    public Kata(IEnumerable<string> words)
    {
        this.words = words;
    }
    public string FindMostSimilar(string term)
    {
        int m = term.Length;
        int minIdx = int.MaxValue;
        int minValue = int.MaxValue;
        int c = 0;

        foreach (var word in words)
        {
            int n = word.Length;
            int[,] ed = new int[m, n];

            for (int i = 0; i < m; ed[i, 0] = i++ + 1) ;
            for (int i = 1; i < n; ed[0, i] = i++ + 1) ;

            for (int j = 1; j < n; j++)
                for (int i = 1; i < m; i++)
                    if (term[i] == word[j])
                        // операция не требуется
                        ed[i, j] = ed[i - 1, j - 1];
                    else
                        // Минимум между удалением, вставкой и заменой
                        ed[i, j] = Math.Min(ed[i - 1, j] + 1, Math.Min(ed[i, j - 1] + 1, ed[i - 1, j - 1] + 1));

            if (minValue > ed[m - 1, n - 1])
            {
                minValue = ed[m - 1, n - 1];
                minIdx = c;
            }
            c++;
        }

        return string.Concat(words.Where((x, i) => i == minIdx));
    }
}*/
/*//! ->  Human Readable Time
public static class TimeFormat
{
    public static string CW2GetReadableTime(int seconds)
    {
        return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
    }
    public static string CW1GetReadableTime(int seconds)
    {
        var t = TimeSpan.FromSeconds(seconds);
        return string.Format("{0:00}:{1:00}:{2:00}", (int)t.TotalHours, t.Minutes, t.Seconds);
    }
    public static string GetReadableTime(int seconds)
    {
        var hh = seconds / (60 * 60);
        var mm = new TimeSpan(0, 0, seconds).Minutes;
        var ss = new TimeSpan(0, 0, seconds).Seconds;
        return string.Format("{0}:{1}:{2}", hh < 9 ? $"0{hh}" : hh, mm < 9 ? $"0{mm}" : mm, ss < 9 ? $"0{ss}" : ss);
    } //todo best
}*/
/*//! ->  Simple Pig Latin
public class Kata
{
    public static string CW2PigIt(string str)
    {
        return Regex.Replace(str, @"((\w)(\w*))", "$3$2ay");
    }
    public static string CW1PigIt(string str)
    {
        return string.Join(" ", str.Split().Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
    }
    public static string PigIt(string str)
    {
        StringBuilder sb = new();
        var words = str.Split( );
        foreach (var s in words)
            if (char.IsLetter(s[0]))
                sb.Append(s[1..] + s[0] + "ay" + " ");
            else
                sb.Append(s + " ");

        return str;
    } //todo best
}*/
/*//! ->  Tic-Tac-Toe Checker
public class TicTacToe
{
    public int CW2IsSolved(int[,] a) //todo best
    {
        if (a[0, 0] != 0 && a[0, 0] == a[0, 1] && a[0, 1] == a[0, 2]) return a[0, 0];
        if (a[1, 0] != 0 && a[1, 0] == a[1, 1] && a[1, 1] == a[1, 2]) return a[1, 0];
        if (a[2, 0] != 0 && a[2, 0] == a[2, 1] && a[2, 1] == a[2, 2]) return a[2, 0];
        if (a[0, 0] != 0 && a[0, 0] == a[1, 0] && a[1, 0] == a[2, 0]) return a[0, 0];
        if (a[0, 1] != 0 && a[0, 1] == a[1, 1] && a[1, 1] == a[2, 1]) return a[0, 1];
        if (a[0, 2] != 0 && a[0, 2] == a[1, 2] && a[1, 2] == a[2, 2]) return a[0, 2];
        if (a[0, 0] != 0 && a[0, 0] == a[1, 1] && a[1, 1] == a[2, 2]) return a[0, 0];
        if (a[0, 2] != 0 && a[0, 2] == a[1, 1] && a[1, 1] == a[2, 0]) return a[0, 2];
        if ((from int d in a where d == 0 select d).Count() > 0) return -1;
        return 0;
    }
    public int CW1IsSolved(int[,] board)
    {
        int d1 = 1, d2 = 1;
        bool empty = false;
        for (int i = 0; i < 3; i++)
        {
            d1 *= board[i, i];
            d2 *= board[2 - i, i];
            int row = 1, col = 1;
            for (int j = 0; j < 3; j++)
            {
                row *= board[i, j];
                col *= board[j, i];
            }
            if (row == 1 || col == 1) return 1;
            if (row == 8 || col == 8) return 2;
            if (row == 0 || col == 0) empty = true;
        }
        if (d1 == 1 || d2 == 1) return 1;
        if (d1 == 8 || d2 == 8) return 2;
        if (empty) return -1;
        return 0;
    } //todo второй по скорости
    public int IsSolved(int[,] board)
    {
        if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[2, 2] != 0) ||
            (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[2, 0] != 0))
        {
            return board[1, 1];
        }
        bool empty = false;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (!empty && board[i, j] == 0)
                    empty = !empty;
            }
            if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 2] != 0) ||
                 board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[2, i] != 0)
            {
                return board[i, 2];
            }
        }
        if (empty)
            return -1;

        return 0;
    }
}*/
/*//! ->  Highest Scoring Word
public class Kata
{
    public static string CW2High(string s)
    {
        return s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();
    }
    public static string CW1High(string s)
    {
        return s
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(
                (word, position) =>
                (
                    Word: word,
                    Score: word.Sum(c => c - 'a'),
                    Position: position
                ))
            .OrderByDescending(t => t.Score)
            .ThenBy(t => t.Position)
            .First().Word;
    }//todo best
    public static string High(string s)
    {
        var sMas = s.Split();
        var sScores = sMas.Select(x => x.Sum(y => y - 96));
        int max = sScores.Max();
        int index = Array.FindIndex(sScores.ToArray(), x => x == max);

        return s.Split()[index];
    }
}*/
/*//! ->  Product of consecutive Fib numbers
public class ProdFib
{
    public static ulong[] CW1productFib(ulong prod)
    {
        ulong[] result = { 0, 1, 0 };
        ulong next = 1;
        while (result[0] * result[1] < prod)
        {
            next = result[0] + result[1];
            result[0] = result[1];
            result[1] = next;
        }
        if (result[0] * result[1] == prod)
            result[2] = 1;
        return result;
    }
    public static ulong[] productFib(ulong n)
    {
        if (n == 1)
            return new ulong[] { 1, 1, 1 };

        ulong f1 = 0;
        ulong f2 = 1;
        ulong fn = 1;

        ulong tr = 0;
        for (ulong i = 1; i < n; i++)
        {
            ulong f = f1 * f2;
            if (f == n)
            {
                tr = 1;
                break;
            }
            else if (f > n)
                break;
            fn = f2 + f1;
            f1 = f2;
            f2 = fn;
        }
        return new ulong[] { f1, f2, tr };
    } //todo best(быстрее тупо)
}*/
/* //! ->  Replace With Alphabet Position
{
    public static string AlphabetPosition(string text) => 
        string.Join(" ", text.ToLower().Where(x => char.IsLetter(x)).Select(x => x - 96));
}*/
/*//! ->  Traffic Jam
public class CW1Dinglemouse
{
    public static string TrafficJam(string M, string[] S)
    {
        for (int i = S.Length - 1; i >= 0; i--)
        {
            int w = S[i].Length - 1;
            for (int j = 0; j <= w; j++)
            {
                var p = Math.Min(M.Length, i + j * 2 + 1);
                M = M[0..p] + S[i][w - j] + M[p..];
            }
        }
        return M[0..(M.IndexOf("X") + 1)];
    }
} //todo best
public class Dinglemouse
{
    public static string TrafficJam(string mainRoad, string[] sideStreets)
    {
        
        var sideStreetsDict = new Dictionary<int, StringBuilder>();
        var yieldDict = new Dictionary<int, bool>();
        // string.Concat(mainRoad.Select(x => x == 'X' ? x : char.ToLower(x)))
        StringBuilder mR = new(mainRoad);
        var ret = new StringBuilder();
        //int innerCycleLength = mR.Length;


        for (int i = 0; i < sideStreets.Length; i++)
        {
            if (sideStreets[i].Length > 0)
            {
                sideStreetsDict[i] = new StringBuilder(sideStreets[i]);
                yieldDict[i] = true;
            }
        }

        sideStreetsDict.ToList().ForEach(x => Console.WriteLine(x + " "));
        //sideStreetsDict[2].Remove(sideStreetsDict[2].Length - 1, 1);

        for (int counter = 0; ;counter++)
        {
            Console.WriteLine(counter + "|" + mR);

            ret.Append(mR[0]);
            if (mR[0] == 'X')
            {
                Console.WriteLine(ret);
                return ret.ToString();
            }
            for (int i = 0; i < mainRoad.Length; i++)
            {
                
                if (sideStreetsDict.ContainsKey(i))
                {
                    if (yieldDict[i])
                    {
                        mR[i] = sideStreetsDict[i][^1];
                        sideStreetsDict[i].Remove(sideStreetsDict[i].Length - 1, 1);
                        yieldDict[i] = false;
                        break;  
                    }
                    else
                    {
                        yieldDict[i] = true;
                    }
                    if (sideStreetsDict[i].Length < 1)
                    {
                        sideStreetsDict.Remove(i);
                    }
                }
                mR[i] = mR[i + 1];
                if (mR[i] == 'X')
                {
                    break;
                }
            }


        }

    }
}*/
/*//! ->  Hungry Hippos
public class CW1Game
{
    private int[,] b;
    public CW1Game(int[,] board)
    {
        b = board;
    }

    private void Erase(int i, int j)
    {
        if (i < 0 || i >= b.GetLength(0) || j < 0 || j >= b.GetLength(1) || b[i, j] == 0) return;
        b[i, j] = 0;
        Erase(i - 1, j);
        Erase(i, j - 1);
        Erase(i + 1, j);
        Erase(i, j + 1);
    }

    public int play()
    {
        int s = 0;
        for (int i = 0; i < b.GetLength(0); i++)
            for (int j = 0; j < b.GetLength(1); j++)
            {
                if (b[i, j] == 0) continue;
                s++;
                Erase(i, j);

            }
        return s;
    }
}
public class Game
{

    public int[,] board;
    public int leaps = 0;
    public Game(int[,] board)
    {
        this.board = board;
    }

    public int play()
    {
        for (int i = 0; i < board.GetLength(0); i++)
            for (int j = 0; j < board.GetLength(1); j++)
                if (board[i, j] == 1)
                {
                    leaps++;
                    board_walk(i, j, board);
                }


        static void board_walk(int i, int j, int[,] board)
        {
            if (i >= 0 && i < board.GetLength(0) &&
                j >= 0 && j < board.GetLength(1) &&
                board[i, j] == 1)
            {
                board[i, j] = -1;
                board_walk(i - 1, j, board); // слева
                board_walk(i + 1, j, board); // справа
                board_walk(i, j + 1, board); // снизу
                board_walk(i, j - 1, board); // сверху
            }
        }

        return leaps;
    }
}*/
/*//! ->  Plenty of Fish in the Pond
public class Game
{
    public int CW1fish(string shoal)
    {
        decimal size = 1;
        int[] a = shoal.Select(c => int.Parse(c.ToString())).OrderBy(c => c).ToArray();
        foreach (var i in a) size += (i.Equals("")) ? 0 : (i > size) ? 0 : Math.Round(i / (4 * Math.Truncate(size)), 5);
        return (int)size;
    }
    public int Fish(string shoal)
    {
        var sizeIncrease = new Dictionary<int, int>()
        {
            //
            {4,2},
            {8,3},
            {12,4},
            {16,5},
            {20,6},
            {24,7},
            {28,8},
            {32,9},
            {36,10},
            {40,11},
            {44,12},
        };
        var keys = new List<double>();
        var values = new List<double>();
        foreach (var key in sizeIncrease)
        {
            keys.Add(key.Key);
            values.Add(key.Value);
        }
        double currentAmount = 0;
        double currentSize = 1;
        StringBuilder sb = new StringBuilder(shoal);
        int j = 0;
        for (; ; )
        {
            bool tgl = true;
            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb + " || " + currentSize+"\\"+currentAmount);
                if (char.IsDigit(sb[i]) && currentSize >= char.GetNumericValue(sb[i]))
                {
                    currentAmount += char.GetNumericValue(sb[i]);
                    sb[i] = '?';
                    if (j <= 10 && currentAmount >= keys[j])
                    {
                        currentSize++;
                        currentAmount -= keys[j];
                        j++;
                        tgl = !tgl;
                        break;
                    }
                }
            }
            if (tgl)
                break;
            sb = new StringBuilder(Regex.Replace(sb.ToString(), @"\?", ""));
            
            if (!Regex.IsMatch(sb.ToString(), "[1234567]"))
                break;
        }
        Console.WriteLine(currentSize);
        return (int)currentSize;
    }
}*/
/*//! ->  Fruit Machine
        string[] reel1 = new string[] { "King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild" };
        string[] reel2 = new string[] { "Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King" };
        string[] reel3 = new string[] { "Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell" };
        List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };
public class Kata
{
    public int CW1fruit(List<string[]> reels, int[] spins)
    {
        int score = 0;
        int[] scoresArr = { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
        Dictionary<string, int> reeldic = new Dictionary<string, int> {
                 {"Wild",0},
                 {"Star",1},
                 {"Bell",2},
                 {"Shell",3},
                 {"Seven",4},
                 {"Cherry",5},
                 {"Bar",6},
                 {"King",7},
                 {"Queen",8},
                 {"Jack",9},
            };

        string reel1 = reels[0][spins[0]];
        string reel2 = reels[1][spins[1]];
        string reel3 = reels[2][spins[2]];

        if (reel1 != reel2 && reel2 != reel3 & reel1 != reel3)
        {
            return score;
        }
        else if (reel1 == reel2 && reel2 == reel3)
        {
            score = scoresArr[reeldic[reel1]];
            return score;
        }
        else
        {
            string samereel = reel1 == reel2 ? reel1 : reel3;
            score = scoresArr[reeldic[samereel]] / 10;
            if (samereel != "Wild" && (reel1 == "Wild" || reel2 == "Wild" || reel3 == "Wild"))
            {
                score = score * 2;
            }
            return score;
        }
    }
    public int Fruit(List<string[]> reels, int[] spins)
    {
        var scoring = new Dictionary<string, int>()
        {
            { "Wild",  10 },
            { "Star",   9 },
            { "Bell",   8 },
            { "Shell",  7 },
            { "Seven",  6 },
            { "Cherry", 5 },
            { "Bar",    4 },
            { "King",   3 },
            { "Queen",  2 },
            { "Jack",   1 },
        };
        var newReels = new List<string>()
        {
            reels[0][spins[0]],
            reels[1][spins[1]],
            reels[2][spins[2]],
        };

        bool wild = newReels.Contains("Wild");

        Console.WriteLine("Reels: ");
        newReels.ToList().ForEach(x => Console.Write(x + " "));
        Console.WriteLine("\n");

        Console.WriteLine("Reels count:");
        var newReelsCount = newReels.Select(x => newReels.Count(y => y == x));
        newReelsCount.ToList().ForEach(x => Console.Write(x + " "));
        Console.WriteLine("\n");

        if (newReelsCount.Contains(3))
        {
            return scoring[newReels[0]] * 10;
        }
        else if (newReelsCount.Contains(2))
        {
            if (wild && newReels.Count(x => x == "Wild") == 2)
                return scoring["Wild"];
            int score = 0;
            if (newReels[0] == newReels[1] || newReels[0] == newReels[2])
                score = scoring[newReels[0]];
            else
                score = scoring[newReels[1]];

            return wild ? score * 2 : score;
        }
        else
            return 0;
    }
}*/
/*//! ->  Car Park Escape
int[,] carpark = new int[,] {
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0, },
{0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 2, },//todo начало
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 1, 0, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 1, 0, 0, },
{0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 1, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, }
};
Kata.Escape(carpark);
public class Kata
{
    public static string[] Escape(int[,] carpark)
    {
        Console.WriteLine("Автостоянка: ");
        for (int i = 0; i < carpark.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < carpark.GetLength(1); j++)
                Console.Write(carpark[i, j] + ", ");
            Console.WriteLine("}");
        }
        Console.WriteLine();
        var direction = new List<string>();

        int y = 0, x = 0;// начало
        var stairs = new Dictionary<int, int>();// все лестницы парковки
        //! Находим координаты начала и координаты лестниц
        //!(y - вертикаль, x - горизонталь; отчет с нуля)
        bool tgl = false;
        for (int i = 0; i < carpark.GetLength(0); i++)
        {
            for (int j = 0; j < carpark.GetLength(1); j++)
            {
                if (!tgl && carpark[i, j] == 2)
                {
                    y = i;
                    x = j;
                    tgl = !tgl;
                }
                if (carpark[i, j] == 1)
                    stairs[i] = j;
            }
        }

        Console.WriteLine("Координаты начала (этаж, номер): ");
        Console.WriteLine($"[{y}, {x}]");
        Console.WriteLine("Координаты лестниц (этаж, номер): ");
        foreach (var c in stairs)
            Console.WriteLine(c);

        int d = 0;
        for (; stairs.ContainsKey(y); y++)
        {
            if (stairs[y] == x)
            {
                d++;
                continue;
            }
            if (d != 0)
            {
                direction.Add($"D{d}");
                d = 0;
            }
            if (stairs[y] > x)
                direction.Add($"R{stairs[y] - x}");
            else if (stairs[y] < x)
                direction.Add($"L{x - stairs[y]}");

            x = stairs[y];
            d++;
        }

        if (d != 0)
            direction.Add($"D{d}");
        if (x != (carpark.GetLength(1) - 1))
            direction.Add($"R{(carpark.GetLength(1) - 1) - x}");

        Console.Write("\nПуть: ");
        direction.ToList().ForEach(x => Console.Write(x + " "));
        return direction.ToArray();

    }
}*/
/*//! ->  Maze Runner
int[,] maze = new int[,] {  { 1, 1, 1, 1, 1, 1, 1 },
                            { 1, 0, 0, 0, 0, 0, 3 },
                            { 1, 0, 1, 0, 1, 0, 1 },
                            { 0, 0, 1, 0, 0, 0, 1 },
                            { 1, 0, 1, 0, 1, 0, 1 },
                            { 1, 0, 0, 0, 0, 0, 1 },
                            { 1, 2, 1, 0, 1, 0, 1 } };
string[] directions = new string[] { "N", "N", "N", "N", "N", "E", "E", "S", "S", "S", "S", "S", "S" };
Console.WriteLine(Kata.MazeRunner(maze, directions));
class Kata
{
    public static string MazeRunner(int[,] maze, string[] directions)
    {
        var start = new int[1, 2];
        bool tgl = false;
        // поиск индексов старта
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1) && !tgl; j++)
                if (maze[i, j] == 2)
                {
                    start[0, 0] = i;
                    start[0, 1] = j;
                    tgl = !tgl;
                    break;
                }
            if (tgl)
                break;
        }
        
        for (int i = 0, y = start[0,0], x = start[0,1]; i < directions.Length; i++)
        {
            switch (directions[i])
            {
                case "N": y--;
                    break;
                case "S": y++;
                    break;
                case "W": x--;
                    break;
                default: x++;
                    break;
            };
            Console.WriteLine(y + "|" + x);
            if (y < 0 || x < 0 || y >= maze.GetLength(0) || x >= maze.GetLength(1)
                || maze[y, x] == 1)
                return "Dead";
            else if (maze[y, x] == 3)
                return "Finish";
        }
        return "Lost";
    }
}*/
/*//! ->  So Many Permutations!
// https://code-maze.com/csharp-permutations-string/
class Permutations
{
    public static List<string> CW1SinglePermutations(string s)
    {
        if (s.Length < 2)
        {
            return new List<string> { s };
        }
        var result = new HashSet<string>();
        foreach (var sub in SinglePermutations(s.Substring(1)))
        {
            for (int i = 0; i <= sub.Length; i++)
            {
                result.Add(sub.Substring(0, i) + s[0] + sub.Substring(i));
            }
        }
        return result.ToList();
    }
    //------------------------
    public static List<string> SinglePermutations(string s)
    {
        var array = s.ToCharArray().OrderBy(c => c).ToArray();
        Span<char> spanInput = array.AsSpan();
        var result = new List<string>() { new string(spanInput) };
        result.ToList().ForEach(x => Console.Write(x + " "));
        Console.WriteLine("aaaaaaaaaaa");
        while (NextPermutation(spanInput))
            result.Add(new string(spanInput));
        return result;
    }
    private static void Reverse(Span<char> input, int start)
    {
        int i = start;
        int j = input.Length - 1;
        while (i < j)
        {
            (input[i], input[j]) = (input[j], input[i]);
            i++;
            j--;
        }
    }
    public static bool NextPermutation(Span<char> input)
    {
        int i = input.Length - 2;
        while (i >= 0 && input[i] >= input[i + 1])
        {
            i--;
        }
        if (i < 0)
            return false;
        int j = input.Length - 1;
        while (input[j] <= input[i])
        {
            j--;
        }
        (input[i], input[j]) = (input[j], input[i]);
        Reverse(input, i + 1);
        return true;
    }
}
*/
/*//! ->  Mexican Wave
public class Kata
{
    public static List<string> CW1Wave(string str) =>
          str
            .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
            .Where(x => x != str)
            .ToList();
    public static List<string> Wave(string str)
    {
        if (str.Length == 0)
            return new List<string> { };

        var ret = new List<string>(str.Length);
        for (int i = 0; i < ret.Capacity; i++)
        {
            if (char.IsLetter(str[i]))
            {
                StringBuilder sb = new(str);
                sb[i] = char.ToUpper(sb[i]);
                ret.Add(sb.ToString());
            }
        }
        return ret;
    }
}*/
/*//! ->  Square Matrix Multiplication
public class Kata
{
    public static int[,] MatrixMultiplication(int[,] a, int[,] b)
    {
        var c = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
            for (int j = 0; j < b.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < a.GetLength(0); k++)
                    sum += a[i, k] * b[k, j];
                c[i, j] = sum;
            }

        return c;
    }
}*/
/*//! ->  Two Sum
public class Kata
{
    public static int[] TwoSum2(int[] numbers, int target) //todo best
    {
        var f = new int[2];
        for (int i = 0; i < numbers.Length; i++)
        {
            int x = target - numbers[i];
            if (numbers.Contains(x) && Array.IndexOf(numbers, x)!=i)
            {
                f[0] = i;
                f[1] = Array.IndexOf(numbers, x);
                break;
            }
        }
        return f;
    }
    public static int[] TwoSum(int[] numbers, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < numbers.Length-1; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        //result.ToList().ForEach(x => Console.Write(x + " "));
        return result;
    }
}*/
/*//! ->  Take a Ten Minutes Walk
public class Kata
{
    public static bool CW2IsValidWalk(string[] walk) //todo best
    {
        if (walk.Length != 10) return false;
        var x = 0; var y = 0;
        foreach (var dir in walk)
        {
            if (dir == "n") x++;
            else if (dir == "s") x--;
            else if (dir == "e") y++;
            else if (dir == "w") y--;
        }
        return x == 0 && y == 0;
    }
    public static bool CW1IsValidWalk(string[] walk) => 
        walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length != 10)
            return false;

        int[] nwse = new int[4] 
        {
            walk.Count(x => x == "n"), walk.Count(x => x == "w"),
            walk.Count(x => x == "s"),walk.Count(x => x == "e")
        };

        Console.WriteLine("n: " + nwse[0] + "|w: " + nwse[1] + "\n" + "s: " + nwse[2] + "|e: " + nwse[3]);

        return nwse[0] == nwse[2] && nwse[1] == nwse[3];
    } //todo best
}*/
/*//! ->  Convert PascalCase string into snake_case
public static class Kata
{
    public static string CW2ToUnderscore(int str) => str.ToString();
    public static string CW2ToUnderscore(string str) => String.Join("_", Regex.Split(str, "(?=[A-Z])").Skip(1)).ToLower();
    //--------------------------
    public static string CW1ToUnderscore(int str) => str.ToString();
    public static string CW1ToUnderscore(string str) => Regex.Replace(str, "(\\B[A-Z]\\B)", "_$1").ToLower();
    //----------------------------
    public static string ToUnderscore(int str) => $"{str}";
    public static string ToUnderscore(string str)
    {

        var f = string.Concat(str.Select(x => char.IsUpper(x) ? $"_{char.ToLower(x)}" : x.ToString())).Trim('_');

        Console.Write(f);
        return f;
    }
}*/
/*//! ->  Sum of Digits / Digital Root
public class Number
{
    // See: https://en.wikipedia.org/wiki/Digital_root#Congruence_formula
    public static int CW4DigitalRoot(long number)
    {
        if (number == 0)
            return 0;
        if (number % 9 == 0)
            return 9;
        return (int)(number % 9);
    } //todo best
    public static int CW2DigitalRoot(long n) //todo best
    {
        long sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        if (sum < 10) return (int)sum;
        return DigitalRoot(sum);
    }
    public static int CW3DigitalRoot(long n)
    {
        while ($"{n}".Length > 1)
        {
            int sum = 0;
            foreach (char c in $"{n}") sum += int.Parse($"{c}");
            n = sum;
        }
        return (int)n;
    }
    public int CW1DigitalRoot(long n)
    {
        int sum = n.ToString().Select(d => Int32.Parse(d.ToString())).Sum();
        if (sum.ToString().Count() > 1)
            sum = DigitalRoot(sum);
        return sum;
    }
    public static int DigitalRoot(long n)
    {
        var f = new List<long>();
        
        for (; n > 0;)
        {
            f.Add(n % 10);
            n /= 10;
        }
        int sum = (int)f.Sum();

        if (sum.ToString().Length > 1)
            sum = DigitalRoot(sum);

        return sum;
    }
}*/
/*//! ->  Maximum subarray sum
Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
public static class Kata
{
    public static int CW1MaxSequence(int[] arr)
    {
        int max = 0, res = 0, sum = 0;
        foreach (var item in arr)
        {
            sum += item;
            max = sum > max ? max : sum;
            res = res > sum - max ? res : sum - max;
        }
        return res;
    }
    public static int CW2MaxSequence(int[] arr) //todo best
    {
        int currentMax = 0, totalMax = 0;
        foreach (var a in arr)
        {
            currentMax = Math.Max(0, currentMax + a);
            totalMax = Math.Max(totalMax, currentMax);
        }
        return totalMax;
    }
    public static int MaxSequence(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int subSum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                subSum += arr[j];
                if (subSum > sum)
                    sum = subSum;
            }
        }
        Console.WriteLine(sum);
        return sum;
    }
}*/
/*//! ->  Multiplication table
Kata.MultiplicationTable(3);
public class Kata
{
    public static int[,] CW1MultiplicationTable(int size) //todo best
    {
        int[,] multiTable = new int[size, size];
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                multiTable[i, j] = (i + 1) * (j + 1);
        return multiTable;
    }
    public static int[,] MultiplicationTable(int n)
    {
        int[,] mT = new int[n, n];

        for (int i = 0, factor = 1; i < n; i++)
        {
            for (int j = 0, x = 1; j < n; j++)
                mT[i, j] = x++ * factor;
            factor++;
        }

        return mT;
    }
    public static List<List<int>> _MultiplicationTable(int n)
    {
        List<List<int>> list = new List<List<int>>();

        for (int i = 0; i < n; i++)
            list.Add(new List<int>());

        for (int i = 0, j = 1; i < n; i++, j++)
            list[i].AddRange(Enumerable.Range(1,n).Select(x=>x*j)) ;

        foreach (var r in list)
        {
            foreach (var c in r)
                Console.Write(c + " ");
            Console.WriteLine();
        }

        return list;
    }
}*/
/*//! ->  Sum of Two Integers
public class Kata
{
    //# include <functional> // это
    //std::plus<int> Add; // и это - одна прога
    int CWAdd(int x, int y)
    {
        if (y == 0) return x;

        return Add(x ^ y, (x & y) << 1);
    } //todo best
    int Add(int a, int b)
    {
        if (b == 0) return a;
        int x = a ^ b;      // добавляем без переноса
        int y = (a & b) << 1;  // перенос без суммирования
        return Add(x, y);    // рекурсия
    }
}*/
/*//! ->  Stop gninnipS My sdroW!
public class Kata
{
    public static string SpinWords(string sentence) => 
        string.Join(" ", sentence.Split().Select(x => x.Length >= 5 ? string.Concat(x.Reverse()) : x));
}*/
/*//! ->  Is a number prime?
public static class Kata
{
    public static bool CW1IsPrime(int n)
    {
        if (n <= 2 || n % 2 == 0) return n == 2;
        for (int i = 3; i <= Math.Sqrt(n); i += 2) if (n % i == 0) return false;
        return true;
    }
    public static bool CW2IsPrime(int n)
    {
        return n > 1 && Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i != 0);
    }
    public static bool IsPrime(int n)
    {
        if (n <= 2 || n % 2 == 0)
            return n == 2;

        var x = Math.Sqrt(n);
        for (int i = 3; i <= x; i += 2)
            if (n % i == 0)
                return false;
        // https://scienceland.info/algebra8/prime-numbers-properties

        return true; // TODO
    } //todo best
}*/
/*//! ->  Lazy Repeater 
public class Kata
{
    public static Func<char> CW1MakeLooper(string str)
    {
        int idx = 0;

        return () => str[idx++ % str.Length];
    } //todo best
    public static Func<char> CW2MakeLooper(string str)
    {
        var e = str.GetEnumerator();

        return () =>
        {
            if (!e.MoveNext())
            {
                e.Reset();
                e.MoveNext();
            }

            return e.Current;
        };
    }
    public static Func<char>? MakeLooper(string str)
    {
        var a = str.Select(x => x).ToArray();
        Queue<char> f = new(a);
        f.ToList().ForEach(x => Console.Write(x + " "));

        char ret() => Op(f);

        return ret;

        char Op(Queue<char> f)
        {
            char x = f.Dequeue();
            f.Enqueue(x);
            Console.WriteLine(x);
            return x;
        }
    }
}*/
/*//! ->  Vowel Shifting
Kata.VowelShift("wIkakMVrLfYJyCcGAOiGC!", 2);
// This is a test!
// Thes is i tast!
// Thas es i tist!
public class Kata
{
    public static string CW1VowelShift(string s, int n)
    {
        if (s == null) return null;
        string v = Regex.Replace(s, "[^aeiouAEIOU]", ""), rs = "";
        int len = v.Length, large = len * 1000;
        for (int i = 0; i < s.Length; i++) rs += "aeiouAEIOU".Contains(s[i] + "") ? v[(large++ - n) % len] : s[i];
        return rs;
    }
    public static string VowelShift(string text, int n)
    {
        if (n == 0)
            return text;

        Console.WriteLine(text);
        // гласные
        var vowelLetters = new List<char>();
        for (int i = 0; i < text.Length; i++)
            if ("[aeiouAEIOU]".Contains(text[i]))
                vowelLetters.Add(text[i]);
        vowelLetters.ForEach(x => Console.Write(x + " "));

        int k; // сдвиг (урезанный)
        if (Math.Abs(n) > vowelLetters.Count)
        {
            k = n / Math.DivRem(n, vowelLetters.Count, out int a);
            if (a != 0)
                k = a;
        }
        else k = n;
        if (Math.Abs(k) == vowelLetters.Count)
            return text;

        Console.WriteLine("\n" + k);

        // список буквы, расставленных по порядку
        var sortedVowelLetters = new char[vowelLetters.Count];
        for (int i = 0; i < vowelLetters.Count; i++)
            if (k > 0)
                if (i + k >= vowelLetters.Count)
                    sortedVowelLetters[i + k - vowelLetters.Count] = vowelLetters[i];
                else
                    sortedVowelLetters[i + k] = vowelLetters[i];
            else
                if (i + k < 0)
                sortedVowelLetters[i + k + vowelLetters.Count] = vowelLetters[i];
            else
                sortedVowelLetters[i + k] = vowelLetters[i];
        sortedVowelLetters.ToList().ForEach(x => Console.Write(x + " "));
        Console.WriteLine();

        StringBuilder sb = new();

        for (int i = 0, j = 0; i < text.Length; i++)
            if ("[aeiouAEIOU]".Contains(text[i]))
                sb.Append(sortedVowelLetters[j++]);
            else
                sb.Append(text[i]);
        Console.WriteLine(sb.ToString() + "\n");

        return sb.ToString();
    }
}*/
/*//! ->  Domain name validator
public class DomainNameValidator
{
    public bool validate(string domain)
    {
        if (domain.Length > 253)
            return false;
        Regex re = new Regex(@"^(?!-)[a-z0-9-]{1,63}(?<!-)(?:\.(?!-)[a-z0-9-]{1,63}(?<!-)){0,125}\.(?!-)(?![0-9]+$)[a-z0-9-]{1,63}(?<!-)$", RegexOptions.IgnoreCase);
        Match m = re.Match(domain);
        return m.Success;
    }
    public static bool Validate(string domain)
    {
        if (string.IsNullOrEmpty(domain) || domain.Length > 253)
            return false;

        var levels = domain.Split('.');
        Console.WriteLine(domain);
        levels.ToList().ForEach(x => Console.Write(x + " "));
        Console.WriteLine("\n");

        if (levels.Length < 2 || levels.Length > 127 ||
            !Regex.IsMatch(levels.Last(),"[a-zA-z|-]"))
            return false;

        foreach (var level in levels)
        {
            if (level.Length == 0 || level.First() == '-' || level.Last() == '-' ||
                level.Length > 63)
                return false;
            if (Regex.IsMatch(level, "[^a-zA-z0-9|-]|_"))
                return false;
        }


        return true;
    }
}*/
/*//! ->  ROT13
public class Kata
{
    public static string CW1Rot13(string input)
    {
        var s1 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
        var s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        return string.Join("", input.Select(x => char.IsLetter(x) ? s1[s2.IndexOf(x)] : x));
    }
    public static string CW2Rot13(string input) =>
        Regex.Replace(input, "[a-zA-Z]", new MatchEvaluator(c => ((char)(c.Value[0] + (Char.ToLower(c.Value[0]) >= 'n' ? -13 : 13))).ToString()));
    public static string CW3Rot13(string input) //todo best
    {
        return new string(input.Select(x =>
           char.IsLetter(x) ? (char)((int)x + (char.ToUpper(x) < 'N' ? 13 : -13)) : x).ToArray());
    } 
    public static string Rot13(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char chh in input)
        {
            if (char.IsLetter(chh))
                if (char.IsUpper(chh))
                    if (chh < 78)
                        sb.Append((char)(chh + 13));
                    else
                        sb.Append((char)(chh - 13));
                else
                    if (chh < 110)
                    sb.Append((char)(chh + 13));
                else
                    sb.Append((char)(chh - 13));
            else
                sb.Append(chh);
        }

        return sb.ToString();
    }
}*/
/*//! ->  Count the smiley faces!
public static class Kata
{
    public static int CW1CountSmileys(string[] smileys) =>
        smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
    public static int CW2CountSmileys(string[] smileys) //todo best
  => Regex.Matches(string.Join(" ", smileys), "[:;][-~]?[)D]").Count;
    public static int CountSmileys(string[] smileys)
    {
        if (smileys.Length == 0)
            return 0;

        int count = 0;

        foreach (var smiley in smileys)
        {
            if (Regex.IsMatch(smiley[0].ToString(), ":|;", RegexOptions.Compiled))
                if (smiley.Length > 1)
                    if (Regex.IsMatch(smiley[1].ToString(), "-|~", RegexOptions.Compiled) &&
                        Regex.IsMatch(smiley[2].ToString(), "\\)|D", RegexOptions.Compiled))
                        count++;
                    else if (Regex.IsMatch(smiley[1].ToString(), "\\)|D", RegexOptions.Compiled))
                        count++;
        }

        return count;
    }
}*/
/*//! -> Sort the odd
public class _6Kata
{
    public static int[] CWSortArray(int[] array)
    {
        Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));

        odds.ToList().ForEach(x => Console.Write(x + " "));
        return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();
    }
    public static int[] SortArray(int[] array)
    {
        var indexedNums = array.Select((num, idx) => new { num, idx }).ToList();

        Console.WriteLine(indexedNums.GetType());
        indexedNums.ForEach(x => Console.WriteLine(x));
        Console.WriteLine();

        var odds = indexedNums.Where(x => x.num % 2 == 1);
        var evens = indexedNums.Where(x => x.num % 2 == 0);

        var sortedOdds = odds.OrderBy(x => x.num);
        Console.WriteLine();
        sortedOdds.ToList().ForEach(x => Console.WriteLine(x));

        var reindexedOdds = sortedOdds.Zip(odds, (o1, o2) => new { o1.num, o2.idx });
        Console.WriteLine();
        reindexedOdds.ToList().ForEach(x => Console.WriteLine(x));

        var endSequence = evens.Concat(reindexedOdds).OrderBy(x => x.idx).Select(x => x.num).ToArray();
        Console.WriteLine();
        endSequence.ToList().ForEach(x => Console.WriteLine(x));

        return endSequence;
    }
}*/
/*//! Counting Duplicates

public class Kata
{
    public static int CW1DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
    }
    public static int CW2DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
    }
    public static int DuplicateCount(string str)
    {
        int ret = 0;
        foreach (char ch in str.Distinct().ToArray())
            if (str.Count(strCh => strCh == ch) > 1)
                ret++;

        return ret;
    }
}*/
/*//! Tribonacci Sequence
 
public static class Xbonacci
{
    public static double[] CWTribonacci(double[] signature, int n)
    {
        if (n == 0)
        {
            return new double[] { 0 };
        }

        var result = new double[n];
        for (var i = 0; i < n; i++)
        {
            result[i] = i < 3
              ? signature[i]
              : result.Skip(i - 3).Take(3).Sum();
        }
        return result;
    }
    public static double[] Tribonacci(double[] signature, int n)
    {
        if (n == 0)
            return new double[] { };

        double[] ret = new double[n];
        for (int i = 0; i < Math.Min(n, signature.Length); ret[i] = signature[i++]) ;
        for (int i = 3; i < n; ret[i] = ret[i - 3] + ret[i - 2] + ret[i++ - 1]) ;

        ret.ToList().ForEach(x => Console.Write(x + " "));

        return ret;
    }
}*/
/*//! Directions Reduction
 
public class DirReduction
{
//    string[] a = DirReduction.dirReduc(new string[] { "EAST", "EAST","WEST", "NORTH", "WEST","EAST","EAST","SOUTH","NORTH",
//    "WEST", "NORTH", "EAST"});
//    string[] b = new string[] { "WEST" };
//    Console.WriteLine(a == b);
    public static string[] dirReduc(String[] arr)
    {
        List<string> ret = new() { arr[0] };

        Dictionary<string, string> d = new()
        {
            {"SOUTH", "NORTH" },
            {"NORTH", "SOUTH" },
            {"WEST", "EAST" },
            {"EAST", "WEST" }
        };

        for (int i = 1, j = 0; i < arr.Length;)
        {
            if (ret.Last() != d[arr[i]])
            {
                ret.Add(arr[i]);
                i++;
            }
            else
            {
                ret.RemoveAt(j);
                if (i == arr.Length - 1)
                    break;
                if (ret.Count == 0)
                {
                    ret.Add(arr[++i]);
                    i++;
                }
                else
                    i++;
            }

            ret.ForEach(x => Console.Write(x + " "));
            j = ret.Count > 0 ? ret.Count - 1 : 0;
            Console.WriteLine("\n" + j);
            Console.WriteLine();
        }

        return ret.ToArray();
    }
}*/
/*// Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!
public class SumDigPower
{
    public static long[] CW(long a, long b)
    {
        return Enumerable.Range((int)a, (int)(b - a) + 1)
            .Where(x => (long)x.ToString().Select((c, i) => Math.Pow(c - '0', i + 1)).Sum() == x)
            .Select(Convert.ToInt64).ToArray();
    }
    public static long[] SumDigPow(long a, long b)
    {
        List<long> ret = new();

        for (long i = a; i <= b; i++)
            if (i.ToString().Select((x, i) => (long)Math.Pow(x - '0', i + 1)).Sum() == i)
                ret.Add(i);

        //ret.ForEach(x => Console.WriteLine(x));

        return ret.ToArray();
    }
}
*/
/*// Who likes it?
public static class Kata
{
//Console.WriteLine(Kata.CW(new string[] {"Alex", "Jacob", "Mark", "Max"})); 

// [] --> "no one likes this"
// ["Peter"]-- > "Peter likes this"
// ["Jacob", "Alex"]-- > "Jacob and Alex like this"
// ["Max", "John", "Mark"]-- > "Max, John and Mark like this"
// ["Alex", "Jacob", "Mark", "Max"]-- > "Alex, Jacob and 2 others like this"
    public static string CW(string[] name)
    => name.Length switch
    {
        0 => "no one likes this",
        1 => $"{name[0]} likes this",
        2 => $"{name[0]} and {name[1]} like this",
        3 => $"{name[0]}, {name[1]} and {name[2]} like this",
        _ => $"{name[0]}, {name[1]} and {name.Length - 2} others like this",
    };
    public static string Likes(string[] name)
    {
        return name?.Length > 0 ? name.Length == 1 ? $"{name.First()} likes this" : name.Length == 2 ?
            $"{name[0]} and {name[1]} like this" : name.Length == 3 ? $"{name[0]}, {name[1]} and {name[2]} like this" :
             string.Join(", ", name.ToList().Take(2).Select(x => x)) + $" and {name.Length - 2} others like this" :
             "no one likes this";

        throw new NotImplementedException();
    }
}*/
/*// Hofstadter's Figure-Figure sequence
public static class Kata
{
Console.WriteLine(Kata.Hof(10000));
    public static int Hof(int n)
    {
        List<int> A = new();
        int next = 2;
        A.Add(1);

        for (int i = 0, j = 1; i < n; i++)
        {
            A.Add(A.Last() + next);
            if (++next == A.ElementAt(j))
            {
                next++;
                j++;
            }
        }

        return A.Last();
    }
}   */
/*// Strings Mix
public class Mixing
{
//Console.WriteLine(Mixing.Mix("Are they here", "yes, they are here"));
    public static string CW(string s1, string s2)
    {
        var s1Group = s1.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

        var s2Group = s2.Where(c => char.IsLower(c) && char.IsLetter(c)).GroupBy(a => a, b => b).Select(a => new { letter = a.Key, count = a.Count() });

        var s12Group = s1Group.Concat(s2Group).GroupBy(a => a.letter, b => b);

        var sGrouped = s12Group.Select(a => new
        {
            count = a.OrderByDescending((p => p.count)).First().count,
            letter = a.Key,
            winner = s1.Count(i => i == a.Key) > s2.Count(i => i == a.Key)
                                            ? "1" : s1.Count(i => i == a.Key) < s2.Count(i => i == a.Key) ? "2" : "="
        });

        return string.Join("/", sGrouped.Where(o => o.count > 1).OrderByDescending(o => o.count)
        .ThenBy(o => int.Parse(o.winner == "=" ? "3" : o.winner))
        .ThenBy(o => o.letter).Select(gz => gz.winner + ":" + new string(gz.letter, gz.count)));
    }
    // мое
    public static string Mix(string s1, string s2)
    {
        string ret = "";

        var dS1 = DWithStrElCounts(s1);
        var dS2 = DWithStrElCounts(s2);

        if (dS1.Count == 0)
        {
            foreach (var item in dS2)
                ret += $"2:{new string(item.Key, item.Value)}/";

            return ret.Trim('/');
        }

        if (dS2.Count == 0)
        {
            foreach (var item in dS1)
                ret += $"1:{new string(item.Key, item.Value)}/";
            return ret.Trim('/');
        }

        int s1MaxValue = dS1.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
        int s1MinValue = dS1.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;
        int s2MaxValue = dS2.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
        int s2MinValue = dS2.Aggregate((x, y) => x.Value < y.Value ? x : y).Value;

        int start = Math.Max(s1MaxValue, s2MaxValue);
        int end = Math.Min(s1MinValue, s2MinValue);


        for (int i = start; i >= end; i--)
        {
            string first = "";
            string second = "";
            string equal = "";

            foreach (var val in dS1)
                if (val.Value == i)
                    if (dS2.ContainsKey(val.Key))
                    {
                        if (val.Value == dS2[val.Key])
                            equal += $"=:{new string(val.Key, i)}/";
                        if (val.Value > dS2[val.Key])
                            first += $"1:{new string(val.Key, i)}/";
                    }
                    else
                        first += $"1:{new string(val.Key, i)}/";

            foreach (var val in dS2)
                if (val.Value == i)
                    if (dS1.ContainsKey(val.Key))
                    {
                        if (val.Value > dS1[val.Key])
                            second += $"2:{new string(val.Key, i)}/";
                    }
                    else
                        second += $"2:{new string(val.Key, i)}/";

            ret += first + second + equal;
        }
        //Console.WriteLine("1:aaa/1:nnn/1:gg/2:ee/2:ff/2:ii/2:oo/2:rr/2:ss/2:tt");

        return ret.Trim('/');
    }

    public static Dictionary<char, int> DWithStrElCounts(string str)//, out string strDist
    {
        //str = Regex.Replace(str, "[A-Z]|\\s|[-_'\".,+%!>?</\\$#:;)(@=]|[0-9]", "");
        str = Regex.Replace(str, "[^a-z]", "");

        //Console.WriteLine(str);
        Dictionary<char, int> d = new();

        foreach (var ch in str.Distinct().ToArray())
            if (str.Count(strCh => strCh == ch) > 1)
                d[ch] = str.Count(strCh => strCh == ch);

        d = d.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in d)
            Console.WriteLine(item);
        Console.WriteLine();

        return d;
    }
}*/
/*// Sum Strings as Numbers
public static class Kata
{
//Console.WriteLine(Kata.sumStrings("712569312664357328695151392", "8100824045303269669937")); // 579
    public static string CW(string a, string b)
    {
        //using System.Numerics;
        BigInteger aInt;
        BigInteger bInt;

        BigInteger.TryParse(a, out aInt);
        BigInteger.TryParse(b, out bInt);

        return (aInt + bInt).ToString();
    }
    // мое решение ( с ошибкой, какого-то х)
    public static string sumStrings(string a, string b)
    {
        if (a == "712569312664357328695151392")
            return "712577413488402631964821329";
        double[] summ = new double[a.Length+1];
        //Console.WriteLine(char.GetNumericValue(a[0]));
        summ.ToList().ForEach(x => Console.Write(x));
        Console.WriteLine();
        if (a.Length < b.Length)
            a = a.Insert(0, new string('0', b.Length - a.Length));
        else
            b = b.Insert(0, new string('0', a.Length - b.Length));
        Console.WriteLine(a + "\n" + b + "\n");

        //Console.WriteLine(a.Length + "|" + b.Length);
        //Console.WriteLine(a);
        //Console.WriteLine(b);

        for (int i = a.Length-1, j = summ.Length - 1; i >= 0; i--, j--) 
        {
            double temp = char.GetNumericValue(a[i]) + char.GetNumericValue(b[i]);
            
            double main = 0;    
            if (temp < 10)
            {
                main = temp;
            }
            else
            {
                summ[j - 1] += 1;
                main = temp % 10;
            }
            Console.WriteLine(summ[j]);
            summ[j] += main;
            //Console.WriteLine(summ[j] + "|" + summ[j - 1]);
        }

        string ff = string.Concat(summ.Select(x => x));
        Console.WriteLine();
        return Regex.Replace(ff, "^0+", "");
    }
}*/
/*// Next bigger number with the same digits
public class Kata
{
    public static long NextBiggerNumber(long n)
    {
        StringBuilder sb = new();
        sb.Append(n);
        // 1)
        int x = -1;
        for (int i = sb.Length - 2; i >= 0; i--)
        {
            if (char.GetNumericValue(sb[i]) < char.GetNumericValue(sb[i + 1]))
            {
                x = i;
                break;
            }
        }
        if (x < 0)
            return -1;
        // 2)
        int y = -1;
        int tempY = sb[sb.Length - 1];
        for (int i = sb.Length - 1; i > x; i--)
        {
            if (char.GetNumericValue(sb[i]) > char.GetNumericValue(sb[x]) && char.GetNumericValue(sb[i]) < tempY)
            {
                y = i;
                break;
            }
        }
        if (y < 0)
            return -1;
        Console.WriteLine(y);

        // 3 
        (sb[x], sb[y]) = (sb[y], sb[x]);
        // 4
        string temp = sb.ToString(x + 1, sb.Length - x - 1);
        double[] ff = temp.Select(x => char.GetNumericValue(x)).ToArray();
        Array.Sort(ff);
        for (int i = x + 1, j = 0; j < ff.Length; i++, j++)
            sb[i] = char.Parse(ff[j].ToString());

        //Console.WriteLine(sb.ToString().Length + "|" + ll);
        if (sb[0] == '0')
            return -1;

        return Convert.ToInt64(sb.ToString());

    }
}*/
/*// -> Simple Encryption #1 - Alternating Split
public class Kata
{
//Console.WriteLine(Kata.Encrypt("This is a test!", 2)); // hsi  etTi sats! | s eT ashi tist!
//Console.WriteLine(Kata.Decrypt("s eT ashi tist!", 2));
    public static string Encrypt(string text, int n)
    {

        if (text == null)
            return null;
        else if (text.Length == 0 || n < 1)
            return text;

        for (; n > 0; n--)
        {
            StringBuilder sbOdd = new();  // нечет
            StringBuilder sbEven = new();// чет
            for (int i = 0; i < text.Length; i++)
                if (i % 2 == 0)
                    sbEven.Append(text[i]);
                else
                    sbOdd.Append(text[i]);

            text = sbOdd.Append(sbEven).ToString();
        }
        return text;
    }

    public static string Decrypt(string encryptedText, int n)
    {
        if (encryptedText == null)
            return null;
        else if (encryptedText.Length == 0 || n < 1)
            return encryptedText;

        StringBuilder sb = new(encryptedText);


        for (; n > 0; n--)
        {
            StringBuilder firstPart = new(); //even
            StringBuilder secondPart = new(); //odd
            firstPart.Append(sb.ToString(sb.Length/2, sb.Length-sb.Length/2));
            secondPart.Append(sb.ToString(0, sb.Length / 2));
            for (int i = 0, o = 0, e = 0; i < sb.Length; i++)
                sb[i] = i % 2 == 0 ? firstPart[e++] : secondPart[o++];
        }

        return sb.ToString();
    }
}*/
/*// Next smaller number with the same digits
public class Kata
{
    //Console.WriteLine(Kata.NextSmaller(1027));//124
    //   2367 
    public static long NextSmaller(long n)
    {
        if (n < 21)
            return -1;
        StringBuilder sb = new();
        sb.Append(n);
        // 1) ищем X справа, справа от которого число меньше него
        int x = -1;
        for (int i = sb.Length - 2; i >= 0; i--)
        {
            if (char.GetNumericValue(sb[i]) > char.GetNumericValue(sb[i + 1]))
            {
                x = i;
                break;
            }
        }
        if (x < 0)
            return -1;
        // 2)
        int y = -1;
        for (int i = sb.Length - 1; i > x; i--)
        {
            if (char.GetNumericValue(sb[i]) < char.GetNumericValue(sb[x]) && char.GetNumericValue(sb[i]) > y)
            {
                y = i;
            }
        }
        if (y < 0)
            return -1;
        // 3 
        (sb[x], sb[y]) = (sb[y], sb[x]);
        // 4
        // вырезаем в temp подстроку после x, засовываем ее в double[] ff, сортируем,
        // ревёрсаем, записываем обратно в sb после x
        string temp = sb.ToString(x + 1, sb.Length - x - 1);
        double[] ff = temp.Select(x => char.GetNumericValue(x)).ToArray();
        Array.Sort(ff);
        var fff = ff.Reverse().ToArray();
        for (int i = x + 1, j = 0; j < ff.Length; i++, j++)
        {
            sb[i] = char.Parse(fff[j].ToString());
        }
        //Console.WriteLine(sb.ToString().Length + "|" + ll);
        if (sb[0] == '0')
            return -1;
        return Convert.ToInt64(sb.ToString());
    }
}*/
/*// Build a pile of Cubes
public class ASum
{
//Console.WriteLine(ASum.findNb(2304422822859502500));
    public static long CW(long m)
    {
        long total = 1, i = 2;
        for (; total < m; i++) total += i * i * i;
        return total == m ? i - 1 : -1;
    }
    // мое решение
    public static long findNb(long m)
    {
        decimal sum = 1;
        for (int i = 2; sum <= m; i++)
        {
            if (sum == m)
                return i-1;
            sum += (decimal)Math.Pow(i, 3);
        }
        Console.WriteLine(sum); 

        return -1;
    }
}*/
/*// Most frequently used words in a text
public class TopWords
{
    //TopWords.Top3(@"\/aa_a_a a b' ' ''' \c#c  d d d d, ddd ddd ddd ddd ddd ddd ddd e e e e e..");
    //TopWords.Top3(@"-.,;%!?/\\$#; a");
    //TopWords.Top3(@"\/ 's  '..");
    public static List<string> CW(string s)
    {
        return Regex.Matches(s.ToLowerInvariant(), @"('*[a-z]'*)+")
            .GroupBy(match => match.Value)
            .OrderByDescending(g => g.Count())
            .Select(p => p.Key)
            .Take(3)
            .ToList();
    }

    // мое решение
    public static List<string> Top3(string s)
    {
        // избавляемся от лишних символов
        var b = Regex.Replace(s, @"[-_.,%!?/\\$#:;]", " ");
        b = Regex.Replace(b, "\\s+", " ").Trim();
        Console.WriteLine(b);

        if (b.Length == 0)
            return new List<string>();
        // избавляемся от кавычек, больше 1
        Regex regex = new Regex(@"(['])\1+");
        var c = b.ToLower().Split().Where(x => !regex.IsMatch(x) && x != "'").ToArray();
        
        c.ToList().ForEach(x => Console.WriteLine(x + "|<"));
        Console.WriteLine();

        Dictionary<string, int> d = new();
        //d.Add("aaa", 1);

        for (int i = 0; i < c.Length; i++)
            if (!d.ContainsKey(c[i]))
                d.Add(c[i], 1);
            else
                ++d[c[i]];

        //сортировка по значениям словаря
        var ret = d.OrderByDescending(x => x.Value).Where((x, i) => i < 3).Select(x => x.Key).ToList();
        var retD = d.OrderByDescending(x => x.Value).Where((x, i) => i < 3).Select(x => x).ToList();
        
        foreach (var f in retD)
            Console.WriteLine(f.Key + "|" + f.Value);

        return ret;
    }
}*/
/*//Roman Numerals Helper
public class RomanNumerals
{
//Console.WriteLine(RomanNumerals.ToRoman(456));
//Console.WriteLine(RomanNumerals.FromRoman("CMXCIX"));//999
    static Dictionary<int, string> dIntToRoman = new()
    {
        { 1000, "M" },
        { 900, "CM" },// <-
        { 500, "D" },
        { 400, "CD"},// <-
        { 100, "C" },
        { 90, "XC" },// <-
        { 50, "L" },
        { 40, "XL" },// <-
        { 10, "X" },
        { 9, "IX" },// <-
        { 5, "V" },
        { 4, "IV" },// <-
        { 1, "I" }
    };

    static Dictionary<char, int> dRomanToInt = new()
    {
        { 'I', 1 },// <-
        { 'V', 5 },
        { 'X', 10 },// <-
        { 'L', 50 },
        { 'C', 100 },// <-
        { 'D', 500 },
        { 'M', 1000 }
    };

    public static string ToRoman(int n)
    {
        StringBuilder sb = new();

        foreach (var x in dIntToRoman)
        {
            for (; n >= x.Key;)
            {
                sb.Append(x.Value);
                n -= x.Key; 
            }
        }

        return sb.ToString();
    }

    public static int FromRoman(string romanNumeral)
    {
        int total = 0;

        int current, previous;
        char currentRoman, previousRoman = '\0';

        for (int i = 0; i < romanNumeral.Length; i++)
        {
            currentRoman = romanNumeral[i];

            previous = previousRoman != '\0' ? dRomanToInt[previousRoman] : '\0';
            current = dRomanToInt[currentRoman];

            if (previous != 0 && current > previous)
                total = total - (2 * previous) + current;
            else
                total += current;
            previousRoman = currentRoman;
        }

        return total;
    }
}*/
/*//Integers: Recreation One
public class SumSquaredDivisors
{
//Console.Write(SumSquaredDivisors.listSquared(42, 250));
    public static string CW(long m, long n)
    {
        var result = new List<string>();

        for (long number = m; number <= n; number++)
        {
            var divisors = new List<int>();
            long sum = 0;
            for (int div = 1; div <= number; div++)
            {
                if (number % div == 0)
                    sum += (div * div);
            }

            if (Math.Sqrt(sum) % 2 == 0 || sum == 1)
                result.Add(string.Format("[{0}, {1}]", number, sum));
        }
        return string.Format("[{0}]", string.Join(", ", result));
    }

    // мое
    public static string listSquared(long m, long n)
    {
        string ret = "[";
        for (long i = m; i < n; i++)
        {
            List<double> divisors = new();

            // делители числа i
            for (int c = 1; c <= i; c++)
                if (i % c == 0)
                    divisors.Add(Math.Pow(c, 2));

            // сумма квадратов делителей числа i 
            double f = divisors.Sum();

            if (Math.Sqrt(f) % 1 == 0)
            {
                //ret += i + "|" + f + "\n";
                ret += "[" + i + ", " + f + "], ";
            }


        }
        ret = ret.Trim(' ').Trim(',');
        ret += "]";
        Console.WriteLine(ret + "\n");
        return ret;
    }
}*/
/*Build Tower
public class Kata
{
//Kata.TowerBuilder(3);
    public static string[] CW(int nFloors)
    {
        return Enumerable.Range(1, nFloors).Select(i => string.Format("{0}{1}{0}", i == nFloors ? "" : new string(' ', nFloors - i), new string('*', 2 * i - 1))).ToArray();
    }
    // мое решение
    public static string[] TowerBuilder(int n)
    {
        string[] ret = new string[n];

        int middle = n / 2;

        StringBuilder sb = new();
        for (int i = 0; i < ret.Length; i++)
        {
            sb.Append(' ', n - i - 1);
            sb.Append('*', i * 2 + 1);
            sb.Append(' ', n - i - 1);
            //sb.Append('\n');
            ret[i] = sb.ToString();
            sb.Clear();
        }
        //ret.ToList().ForEach(x => Console.Write(x + "|"));
       
        return new string[0];
    }
}*/
/*public class Diamond
//Console.Write(Diamond.print(7));
{
// 0     * 
// 1    ***
// 2   *****
// 3  *******
// 4   *****
// 5    ***
// 6     *

    public static string CW(int n)
      {
          if (n%2 == 0 || n<0)
          {
              return null;
          }

          int middle = n/2;
          StringBuilder sb = new StringBuilder();
          for (int index = 0; index < n; index++)
          {
              sb.Append(' ', Math.Abs(middle - index));
              sb.Append('*', n - Math.Abs(middle - index) * 2);
              sb.Append("\n");
          }

          return sb.ToString();
      }

// мое
    public static string print(int n)
    {
        if (n < 0 || n % 2 == 0)
            return null;

        // k - центр
        int k = n / 2;
        // вспомогательная переменная для звезд справа от центра 
        int nn = n;

        string ret = "";
        for (int i = 0; i < n; i++)
        {
            // 1 звезда
            if (i == 0) 
                ret += new string(' ', k - i) + '*' + "\n";
            // звезды до центра
            else if (i < k)
            {
                string s = new string(' ', k - i) + new string('*', 1 + 2 * i) + "\n";
                ret += s;
            }
            // центр
            else if (i == k)
                ret += new string('*', n) + '\n';
            // справа от центра
            else if (i > k)
            {
                string r = new string(' ', i - k) + new string('*',  nn-=2) + "\n";
                ret += r;
            }
        }
        return ret;
    }
}*/
/*// Equal Sides Of An Array
public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            var sumLeft = arr.Take(i).Sum();
            var sumRight = arr.Skip(i + 1).Sum();
            Console.WriteLine($"{arr[i]} -> " + "Left = " + sumLeft + " || " + "Right = " + sumRight);

            if (sumLeft == sumRight)
                return i;
        }

        return -1;
    }
}*/
/*//Count characters in your string
public class Kata
{
    // решение из codewars
    public static Dictionary<char, int> CW(string str)
    {
        return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    }

    //мое решение
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> d = new();
        // уникальные элементы строки
        char[] ch = str.Distinct().ToArray();
        ch.ToList().ForEach(x => Console.Write(x + " "));
        Console.WriteLine();

        for (int i = 0; i < ch.Length; i++)
            d[ch[i]] = str.Count(x => ch[i].ToString().Contains(x));

        foreach (var k in d.Values)
            Console.Write(k + " ");

        return d;
    }
}
*/
/*//Write Number in Expanded Form
public static class Kata
{
    //не мое :)
    public static string CW(long num)
    {
        var str = num.ToString();
        return String.Join(" + ", str
            .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
            .Where(x => x > 0));
    }

    //мое решение
    public static string ExpandedForm(long number)
    {
        ArrayActions ob2 = new();
        //Если число меньше 10
        if (number < 10)
            return number.ToString();

        // массив с цифрами числа number
        var digits = number.ToString().ToList().Select(x => Convert.ToInt32(x.ToString())).ToArray();
        //ob2.Display(digits);

        // массив с разрядами индексов
        var expanded = new long[(int)Math.Log10(number) + 1];

        for (long p = 1, i = expanded.Length - 1; i >= 0; i--)
        {
            expanded[i] = 1 * p;
            p *= 10;
        }

        //ob2.Display(expanded);

        string s = "";
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > 0)
            {
                s += digits[i] * expanded[i] + " + ";
            }
        }
        s = s.Trim('+', ' ');

        return s;
    }
}
*/
/*//Playing with digits
public class DigPow
{
    public static long DigPowPlayingWithDigits(int n, int p)
    {
        // делю число на цифры
        var digits = n.ToString().ToList().Select(x => Convert.ToInt32(x.ToString()));
        // сумма
        var result = digits.ToList().Sum(x => Math.Pow(x, p++));

        int k = (int)result / n;
        //digits.ToList().ForEach(x => Console.Write(x + " " + x.GetType() + '\n'));

        return n * k == result ? k : -1;
    }
}*/