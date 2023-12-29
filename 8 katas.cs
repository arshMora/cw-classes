using codewars;
using Microsoft.Diagnostics.Runtime;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

//x  pseudo-benchmark
/*
var startTime = System.Diagnostics.Stopwatch.StartNew();
for (int benchIt = 0; benchIt < 1000000; benchIt++)
{
}
startTime.Stop();
var resultTime = startTime.Elapsed;
Console.WriteLine(resultTime.Milliseconds);*/

//x                  .ToList().ForEach(x => Console.Write(x + " "));



namespace codewars
{
    internal class _8Kata
    {
    //! ->  Reverse List Order
    /*public static List<int> CW1ReverseList(List<int> list)
    {
        List<int> yeniDizi = new List<int>();

        for (int i = list.Count - 1; i >= 0; i--)
        {
            yeniDizi.Add(list[i]);
        }

        return yeniDizi;
    }
    //Just using list.Reverse() calls the in-place method for List, mutating the input.This calls the LINQ extension method that returns a reversed list and leaves input untouched
    public static List<int> ReverseList(List<int> list) => Enumerable.Reverse(list).ToList(); //todo best*/
    //! ->  Multiple of index
    /*public static IEnumerable<int> CW1MultipleOfIndex(List<int> input) =>
        input.Where((x, i) => x == 0 && i == 0 || i != 0 && x % i == 0); //todo best
    public static List<int> MultipleOfIndex(List<int> xs)
    {
        List<int> result = new List<int>();
        if (xs[0] == 0)
            result.Add(0);
        for (int i = 1; i < xs.Count; i++)
        {
            if (xs[i] % i == 0)
                result.Add(xs[i]);
        }
        //xs.Where((x, i) => i != 0 && x % i == 0).ToList().ForEach(x => Console.Write(x + " "));
        return result;
    }*/
    //! ->  Hex to Decimal
    /*public static int CW2HexToDec(string hexString)
    {
        var n = Convert.ToInt32(hexString.Replace("-", ""), 16);
        return hexString.StartsWith("-") ? n * -1 : n;
    }
    public static int CW1HexToDec(string hexString) =>
        Convert.ToInt32(hexString.TrimStart('-'), 16) * (hexString[0] == '-' ? -1 : 1); //todo чуть-чуть хуже моего
    public static int HexToDec(string hexString) =>
        hexString[0] == '-' ? -Convert.ToInt32(hexString[1..], 16) : Convert.ToInt32(hexString, 16); //todo best*/
    //! -> Remove String Spaces
    /*public static string CW1NoSpace(string input) => Regex.Replace(input, @"\s+", "");
    public static string NoSpace(string input) => input.Replace(" ", ""); //todo best (в разы)*/
    //! ->  Add Length
    /*public static string[] CW1AddLength(string str)
    {
        return str.Split(' ').Select(o => o + " " + o.Length).ToArray();
        //можно было просто пробел добавить
    }
    public static string[] AddLength(string str) => str.Split().Select(x => x + $" {x.Length}").ToArray();*/
    //! ->  Beginner - Lost Without a Map
    /*public static int[] Maps(int[] arr) => arr.Select(x => x + x).ToArray();*/
    //! ->  Hello, Name or World!
    /*public static string CW2Hello(string s = "")
    {
        if (s == "") s = "world";
        return $"Hello, {char.ToUpper(s[0])}{s[1..].ToLower()}!";
    }
    public static string CW1Hello(string name = "")
    {
        return string.IsNullOrEmpty(name)
            ? "Hello, World!"
            : $"Hello, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())}!";
    }
    //?-----------------------------
    public static string Hello(string? name) =>
        $"Hello, {(name?.Length > 0 ? char.ToUpper(name[0]) + name[1..].ToLowerInvariant() + '!' : "World!")}"; //todo best
    public static string Hello() => $"Hello, World!";*/
    //! ->  Filter out the geese
    /*public static IEnumerable<string> CW1GooseFilter(IEnumerable<string> birds)
    {
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        return birds.Except(geese);
        //Careful, this only returns unique strings so it will remove duplicate entries from birds.For Example, if birds = { "Mallard", "African", "Mallard"}, GooseFilter(birds) would return { "Mallard"}
        //instead of { "Mallard" ,"Mallard"}.

        //This works in this case since all birds passed into the filter are unique.

    }
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
        var filtBirds = new List<string>();
        foreach (string gee in birds)
        {
            if (!geese.Contains(gee))
            {
                filtBirds.Add(gee);
            }
        }
        return filtBirds;
    }*/
    //! ->  The Wide-Mouthed frog! 
    /*public static string CW1MouthSize(string animal)
    {
        return animal.Equals("alligator", StringComparison.OrdinalIgnoreCase) ? "small" : "wide";
    }
    public static string MouthSize(string animal) => (animal.ToLower() == "alligator") ? "small" : "wide";*/
    //! ->  Sum of positive
    /*public static int CW1PositiveSum(int[] arr) //todo второй
    {
        return arr.Where(x => x > 0).Sum();
    }
    public static int PositiveSum(int[] arr) => arr.Aggregate(0, (x,y) => y > 0 ? y + x : x + 0);
    public static int PositiveSum2(int[] arr) => arr.Sum(x => x > 0 ? x : 0);
    public static int PositiveSum3(int[] arr)
    {
        int sum = 0;
        foreach (int el in arr)
        {
            if (el > 0)
            {
                sum += el;
            }
        }

        return sum;
    }//todo best*/
    //! ->  Bin to Decimal
    /*public static int CW1binToDec(string s)
    {
        uint res = 0;
        var pos = 0;
        for (var i = 0; i < s.Length; i++)
        {
            uint value = 0;
            switch (s[i])
            {
                case '0': value = 0; break;
                case '1': value = 1; break;
                default: throw new Exception("334");
            }
            res = res | (value << (s.Length - i - 1));
        }
        return (int)res;
    }
    public static int binToDec(string s) => Convert.ToInt32(s, 2); //todo best*/
    //! ->  Remove exclamation marks
    /*public static string CW1RemoveExclamationMarks(string s)
    {
        return s.Replace("!", "");
    } //todo best
    public static string CW2RemoveExclamationMarks(string s)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var c in s)
        {
            if (c != '!')
                sb.Append(c);
        }

        return sb.ToString();
    } 
    public static string RemoveExclamationMarks(string s) => string.Concat(s.Where(x => x != '!')); //? худший*/
    //! ->  Grasshopper - Messi goals function
    /*public static int CW1GetGoals(params int[] goalsPerLeague) => goalsPerLeague.Sum();
    public static int GetGoals(int laLigaGoals, int copaDelReyGoals, int championsLeagueGoals) =>
        laLigaGoals + copaDelReyGoals + championsLeagueGoals; //todo best*/
    //! ->  Area or Perimeter
    /*public static int AreaOrPerimeter(int l, int w) => l == w ? l * w : l * 2 + w * 2;*/
    //! ->  Grasshopper - Terminal game combat function
    /*public static float CW1Combat(float health, float damage) => Math.Max(0, health - damage); //todo best
    public static float Combat(float health, float damage) => (health -= damage) > 0 ? health : 0;*/
    //! ->  Count of positives / sum of negatives
    /*public static int[] CountPositivesSumNegatives2(int[]? input)
    {
        if (input is null || input.Length == 0)
            return Array.Empty<int>();

        var ret = new int[2];
        foreach (var i in input)
        {
            if (i > 0)
                ret[0]++;
            else if (i < 0)
                ret[1] += i;
        }
        return ret;
    } //todo best
    public static int[] CountPositivesSumNegatives(int[]? input)
    {
        if (input is null || input.Length == 0)
            return Array.Empty<int>();

        var ret = new int[2];
        ret[0] = input.Count(x => x > 0);
        ret[1] = input.Where(x => x < 0).Sum();

        return ret; 
    }*/
    //! ->  L1: Set Alarm
    /*public static bool SetAlarm(bool employed, bool vacation) => employed && !vacation;*/
    //! ->  Counting sheep...
    /*public static int CountSheeps(bool[] sheeps) => sheeps.Count(x => x);*/
    //! ->  Beginner Series #2 Clock
    /*public static int CW3Past(int h, int m, int s)
    {
        return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
    } //todo best
    public static int CW2Past(int h, int m, int s)
    {
        //2 часа 31 минута и 16 секунд

        return ((h * 60 + m) * 60 + s) * 1000;
    }
    public static int CW1Past(int h, int m, int s)
    {
        m += h * 60;
        s += m * 60;
        s *= 1000;
        return s;
    }
    public static int Past(int h, int m, int s) => (int)(1000 * s + 60000 * m + h * 3.6 * Math.Pow(10, 6));*/
    //! ->  Is it even?
    /*public bool IsEven(double n) => n % 2 == 0;*/
    //! ->  Switch it Up!
    /*public static string CW1SwitchItUp(int number)
    {
        return new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }[number];
    }
    public static string SwitchItUp(int number) =>
        number switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            _ => "Zero"
        }; //todo best*/
    //! ->  Calculate BMI
    /*public static string CW1Bmi(double w, double h) =>
        (w = w / h / h) > 30 ? "Obese" : w > 25 ? "Overweight" : w > 18.5 ? "Normal" : "Underweight";
    public static string Bmi(double weight, double height)
    {
        double bmi = weight / (height * height);
        if (bmi <= 18.5)
            return "Underweight";
        else if (bmi <= 25.0)
            return "Normal";
        else if (bmi <= 30.0)
            return "Overweight";
        else
            return "Obese";
    }*/
    //! ->  Is the string uppercase?
    /*public static bool CW2IsUpperCase(string s)
    {
        return !s.Any(x => Char.IsLower(x));
    }
    public static bool CW1IsUpperCase(string value)
    {
        return value.ToUpper() == value;
    }
    public static bool IsUpperCase(string text) //todo best
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(text[i]))
                return false;
        }
        return true;
    }*/
    //! ->  What is between?
    /*public static int[] CW1Between(int a, int b)
    {
        return Enumerable.Range(Math.Min(a, b), Math.Abs(a - b) + 1).ToArray();
    } //todo best
    public static int[] Between(int a, int b)
    {
        return Enumerable.Range(a, a < 0 ? b < 0 ? 
            Math.Abs(a) - Math.Abs(b) + 1 :
            Math.Abs(a) + Math.Abs(b) + 1 :
            Math.Abs(a - b) + 1).ToArray();
    }*/
    //! ->  Keep up the hoop
    /*public static string HoopCount(int n) => n > 9 ? "Great, now move on to tricks" : "Keep at it until you get it";*/
    //! ->  Invert values
    /*public static int[] InvertValues(int[] input) => input.Select(x => -x).ToArray();*/
    //! ->  Will there be enough space?
    /*public static int CW1Enough(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);
    public static int Enough(int cap, int on, int wait) => on + wait > cap ? wait + on - cap : 0;*/
    //! ->  I love you, a little , a lot, passionately ... not at all
    /*public static string CW1HowMuchILoveYou(int nb_petals) =>
            (nb_petals % 6) switch
            {
                0 => "not at all",
                1 => "I love you",
                2 => "a little",
                3 => "a lot",
                4 => "passionately",
                5 => "madly"
            }; //todo best
        public static string HowMuchILoveYou(int nb_petals) =>
            new Dictionary<int, string>()
            {
                {1,"I love you" },
                {2,"a little" },
                {3,"a lot" },
                {4,"passionately" },
                {5,"madly" },
                {6,"not at all" },
            }.ElementAt((nb_petals - 1) % 6).Value; //todo best*/
    //! ->  Transportation on vacation 
    /*public static int CW1RentalCarCost(int d) =>
        d * 40 - (d > 6 ? 50 : d > 2 ? 20 : 0);
    public static int RentalCarCost(int d) 
    {
        int ret = (d * 40);
        return d < 3 ? ret : d < 7 ? ret - 20 : ret - 50;
    }*/
    //! ->  Removing Elements
    /*public static object[] RemoveEveryOther(object[] arr) => arr.Where((x, i) => i % 2 == 0).ToArray();*/
    //! ->  Grasshopper - Terminal game move function
    /*public static int Move(int position, int roll) => position + roll + roll;*/
    //! ->  Beginner - Reduce but Grow
    /*public static int Grow(int[] x)
    {
        int ret = x.Aggregate((x, y) => x * y);
        Console.WriteLine(ret);

        return 0;
    }*/
    //! ->  Complementary DNA
    /*public static string CW1MakeComplement(string dna)
    {
        return string.Concat(dna.Select(GetComplement));
    } //todo best
    public static char GetComplement(char symbol)
    {
        switch (symbol)
        {
            case 'A':
                return 'T';
            case 'T':
                return 'A';
            case 'C':
                return 'G';
            case 'G':
                return 'C';
            default:
                throw new ArgumentException();
        }
    }
    //-------------------
    public static string CW2MakeComplement(string dna)
    {
        var mychars = dna.ToCharArray();

        var outChars = new String(mychars.Select(x => map[x]).ToArray());

        return outChars;
    }

    private static Dictionary<char, char> map =
            new Dictionary<char, char>
            {
            {'T', 'A'},
            {'A', 'T'},
            {'C', 'G'},
            {'G', 'C'}
            };
    //------------------------
    public static string CW3MakeComplement(string dna)
    {
        StringBuilder strain = new StringBuilder();

        for (int i = 0; i < dna.Length; i++)
        {
            switch (dna[i])
            {
                case 'A':
                    strain.Append('T');
                    break;
                case 'T':
                    strain.Append('A');
                    break;
                case 'C':
                    strain.Append('G');
                    break;
                case 'G':
                    strain.Append('C');
                    break;
            }
        }
        return strain.ToString();
    } //todo best
    public static string MakeComplement(string dna)
    {
        string ret = "";

        foreach (var c in dna)
            switch (c)
            {
                case 'A':
                    ret += 'T';
                    break;
                case 'T':
                    ret += 'A';
                    break;
                case 'C':
                    ret += 'G';
                    break;
                case 'G':
                    ret += 'C';
                    break;
                default:
                    ret += c;
                    break;
            }

        return ret;
    } //todo best*/
    //! ->  Convert a String to a Number!
    /*public static int CW1StringToNumber(String str) => int.Parse(str);
    public static int CW2StringToNumber(String str)
    {
        int n;
        if (!int.TryParse(str, out n))
            throw new ArgumentException("str");

        return n;
    }
    public static int StringToNumber(String str) => Convert.ToInt32(str); //todo best*/
    //! ->  Return Negative
    /*public static int MakeNegative(int number) => -Math.Abs(number);*/
    //! ->  Sentence Smash
    /*public static string CWSmash(string[] words)
    {
        string result = words[0];
        for (int i = 1; i < words.Length; ++i)
        {
            result += " " + words[i];
        }
        return result;
    }
    public static string Smash(string[] words) => string.Join(" ", words); //todo best*/
    //! ->  Calculate average
    /* public static double FindAverage(double[] array) => array.Length > 0 ? array.Average() : 0;*/
    //! -> Beginner Series #1 School Paperwork 
    /*public static int Paperwork(int n, int m) => n < 0 || m < 0 ? 0 : n * m;*/
    //! ->  Abbreviate a Two Word Name
    /*public static string CW1AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
    public static string CW2AbbrevName(string name)
    {
        string[] words = name.Split(' ');

        return (words[0][0] + "." + words[1][0]).ToUpper();
    }
    public static string AbbrevName(string name) => string.Join(".", name.Split().ToList().Select(x => x.ToUpper().ToString().First()));*/
    //! ->  No zeros for heros
    /*public static int CW1NoBoringZeros(int n)
    {
        while (n != 0 && n % 10 == 0)
            n /= 10;

        return n;
    } //todo best
    public static int CW2NoBoringZeros(int n)
    {
        return (n == 0) ? 0 : Convert.ToInt32(n.ToString().TrimEnd('0'));
    }
    public static int NoBoringZeros(int n)
    {
        string s = n.ToString();
        if (s.Length == 1 || char.GetNumericValue(s.Last()) != 0) return n;

        int idxStart = 0, idxOver = s.Length - 1;
        for (int i = idxOver; i > 0 && char.GetNumericValue(s[i]) == 0; i--)
            idxStart = i;

        return Convert.ToInt32(s[..idxStart]);
    }*/
    //! ->  Correct the mistakes of the character recognition software
    /*public static string CW1Correct(string text) =>
        string.Join("", text.Select(x => x == '5' ? x = 'S' : x == '0' ? x = 'O' : x == '1' ? x = 'I' : x = x).ToArray());
    public static string CW2Correct(string text) =>
        text.Replace("5", "S").Replace("0", "O").Replace("1", "I");
    public static string Correct(string text)
    {
        Dictionary<char, char> d = new();
        d.Add('5', 'S');
        d.Add('0', 'O');
        d.Add('1', 'I');

        return string.Concat(text.Select(x => d.ContainsKey(x) ? d[x] : x));
    }*/
    //! ->  Convert number to reversed array of digits
    /* public static long[] CWDigitize(long n) => $"{n}".Select(c => (long)c - '0').Reverse().ToArray(); //todo best
    public static long[] Digitize(long n) => n.ToString().Select(x => long.Parse(x.ToString())).Reverse().ToArray();*/
    //! ->  Sum without highest and lowest number
    /*public static int CW1Sum(int[] numbers)
    {
        return numbers == null || numbers.Length < 2
            ? 0
            : numbers.Sum() - numbers.Max() - numbers.Min();
    }
    public static int CW2Sum(int[] n) => (n?.Length ?? 0) > 1 ? n.Sum() - n.Max() - n.Min() : 0;
    public static int CW3Sum(int[] n) => n?.OrderBy(i => i).Skip(1).Take(n.Length - 2).Sum() ?? 0;
    public static int Sum(int[] numbers) => numbers is not null && numbers.Length > 1 ? numbers.Where((x, i) =>
        i != Array.IndexOf(numbers, numbers.Min()) && i != Array.IndexOf(numbers, numbers.Max())).Sum() : 0;*/
    //! ->  Find the smallest integer in the array
    /*public static int FindSmallestInt(int[] args) => args.Min();*/
    //! ->  Expressions Matter
    /*public static int CWExpressionsMatter(int a, int b, int c)
        => new[] { a * (b + c), a * b * c, a + b * c, a + b + c, (a + b) * c }.Max(); //todo best
    public static int ExpressionsMatter(int a, int b, int c) =>
        Math.Max(a * b * c,
            Math.Max(a + b + c,
                Math.Max(a + b * c,
                    Math.Max((a + b) * c,
                        Math.Max(a * b + c,
                            a * (b + c))))));*/
    //! ->  Thinkful - Logic Drills: Traffic light
    /*public static string CW2UpdateLight(string current)
    /
        return current switch
        {
            "green" => "yellow",
            "yellow" => "red",
            "red" => "green",
            _ => "red",
        };
    }
    public static string CW1UpdateLight(string current) =>
            new Dictionary<string, string>{
    {"green","yellow"}, {"yellow","red"}, {"red","green"}}[current]; //todo best
    public static string UpdateLight(string current)
    {
        Dictionary<string, string> Traffic_light = new()
    {
        {"red", "green" },
        {"yellow", "red" },
        {"green", "yellow" }
    };

        return Traffic_light[current];
    }*/
    //! ->  Will you make it?
    /*public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => mpg * fuelLeft >= distanceToPump;*/
    //! -> Find the odd int
    /*public static int CW1find_it(int[] seq)
    {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
    }
    public static int find_it(int[] seq) => seq.GroupBy(c => c).Where(x => x.Count() % 2 != 0).First().First();*/
    //! -> Square(n) Sum
    /*public static int CW1SquareSum(int[] n) => n.Sum(x => x * x); //todo best
    public static int CW2SquareSum(int[] n) => n.Sum(i => i * i);
    public static int SquareSum(int[] numbers) => numbers.Select(x => (int)Math.Pow(x, 2)).Sum();*/
    //! -> Third Angle of a Triangle
    /*public static int OtherAngle(int a, int b) => 180 - a - b;*/
    //! -> Powers of 2
    /*public static BigInteger[] PowersOfTwo(int n)
    {
        BigInteger[] arr = new BigInteger[n + 1];
        for (int i = 0; i <= n; arr[i] = (BigInteger)Math.Pow(2, i++)) ;
        arr.ToList().ForEach(x => Console.Write(x + " "));

        return arr;
    }*/
    //! -> Convert a Boolean to a String
    /*public static string CWBooleanToString(bool b) => $"{b}{1}";
    public static string BooleanToString(bool b) => b ? "True" : "False"; // b.ToString();*/
    //! -> Keep Hydrated!
    /*public static int Litres(double time) => (int)(time * 0.5); // (int)time/2*/
    //! -> altERnaTIng cAsE <=> ALTerNAtiNG CaSe
    /* public static string CWToAlternatingCase(string Input)
    {
        return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
    }
    public static string ToAlternatingCase(string s) =>
        string.Concat(s.Select(x => char.IsLower(x) ? char.ToUpperInvariant(x) : char.ToLowerInvariant(x)));*/
    //! -> Convert a string to an array
    /*public static string[] StringToArray(string str) => str.Split();*/
    //! -> Welcome!
    /*public static string CW1Greet(string language)
    {
        return language switch
        {
            "czech" => "Vitejte",
            "danish" => "Velkomst",
            "dutch" => "Welkom",
            "estonian" => "Tere tulemast",
            "finnish" => "Tervetuloa",
            "flemish" => "Welgekomen",
            "french" => "Bienvenue",
            "german" => "Willkommen",
            "irish" => "Failte",
            "italian" => "Benvenuto",
            "latvian" => "Gaidits",
            "lithuanian" => "Laukiamas",
            "polish" => "Witamy",
            "spanish" => "Bienvenido",
            "swedish" => "Valkommen",
            "welsh" => "Croeso",
            _ => "Welcome"
        };
    } //todo best
    public static string CW2Greet(string language)
    {
        return (lang.ContainsKey(language))
            ? lang[language]
            : "Welcome";
    }
    private static readonly Dictionary<string, string> lang = new Dictionary<string, string>
    {
    {"english", "Welcome"},
    {"czech", "Vitejte"},
    {"danish", "Velkomst"},
    {"dutch", "Welkom"},
    {"estonian", "Tere tulemast"},
    {"finnish", "Tervetuloa"},
    {"flemish", "Welgekomen"},
    {"french", "Bienvenue"},
    {"german", "Willkommen"},
    {"irish", "Failte"},
    {"italian", "Benvenuto"},
    {"latvian", "Gaidits"},
    {"lithuanian", "Laukiamas"},
    {"polish", "Witamy"},
    {"spanish", "Bienvenido"},
    {"swedish", "Valkommen"},
    {"welsh", "Croeso"}
    };
    public static string Greet(string language)
    {
        Dictionary<string, string> d = new()
    {
        {"english", "Welcome"},
        {"czech", "Vitejte"},
        {"danish", "Velkomst"},
        {"dutch", "Welkom"},
        {"estonian", "Tere tulemast"},
        {"finnish", "Tervetuloa"},
        {"flemish", "Welgekomen"},
        {"french", "Bienvenue"},
        {"german", "Willkommen"},
        {"irish", "Failte"},
        {"italian", "Benvenuto"},
        {"latvian", "Gaidits"},
        {"lithuanian", "Laukiamas"},
        {"polish", "Witamy"},
        {"spanish", "Bienvenido"},
        {"swedish", "Valkommen"},
        {"welsh", "Croeso"}
    };

        return d.ContainsKey(language) ? d[language] : d["english"];
    }*/
    //! -> Opposite number
    /*public static int Opposite(int number) => -number;*/
    //! -> Rock Paper Scissors!
    /*public static string CW1Rps(string p1, string p2)
    // Console.WriteLine(_8Kata.Rps("scissorc", "rock"));
    {
        if (p1 == p2) return "Draw!";
        int p = (p1 + p2) == "scissorspaper" || (p1 + p2) == "rockscissors" || (p1 + p2) == "paperrock" ? 1 : 2;
        return "Player " + p + " won!";
    }
    public static string CW2Rps(string p1, string p2)
    {
        if (p1 == p2)
            return "Draw!";

        if (((p1 == "rock") && (p2 == "scissors")) ||
            ((p1 == "scissors") && (p2 == "paper")) ||
            ((p1 == "paper") && (p2 == "rock")))
        {
            return "Player 1 won!";
        }
        else
        {
            return "Player 2 won!";
        }
    }
    public static string Rps(string p1, string p2)
    {
        if (p1 == p2) return "Draw!";

        if (p1 == "scissors")
            if (p2 == "paper")
                return "Player 1 won!";
            else
                return "Player 2 won!";
        else if (p1 == "paper")
            if (p2 == "rock")
                return "Player 1 won!";
            else
                return "Player 2 won!";
        else if (p2 == "scissors")
            return "Player 1 won!";
        else
            return "Player 2 won!";
    }*/
    //! -> You're a square!
    /*public static bool IsSquare(int n) => Math.Sqrt(n) % 1 == 0;*/
    //! -> Regex validate PIN code
    /*public static bool CW1ValidatePin(string pin)
    {
        return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
    }
    public static bool CW2ValidatePin(string pin)
    {
        return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
    }
    public static bool ValidatePin(string pin)
    {
        string str = Regex.Replace(pin, "[^0-9]", "");
        return uint.TryParse(pin, out _) && (pin.Length == str.Length && (pin.Length == 4 || pin.Length == 6));
    }*/
    //! -> DNA to RNA Conversion
    /*public static string CWdnaToRna(string dna) => dna.Replace('T', 'U');
    public static string DnaToRna(string dna) => Regex.Replace(dna, "T", "U");*/
    //! -> Fake Binary
    /*public static string CW1FakeBin(string x)
    //_8Kata.FakeBin("45385593107843568");
    {
        StringBuilder builder = new StringBuilder();

        foreach (char t in x)
        {
            builder.Append(t >= '5' ? '1' : '0');
        }

        return builder.ToString();
    }
    public static string CW2FakeBin(string x)
    {
        x = Regex.Replace(x, "[4321]", "0");
        x = Regex.Replace(x, "[56789]", "1");
        return x;
    }
    public static string FakeBin(string x)
    {
        string ret = "";
        foreach (char c in x)
            if (c - '0' < 5)
                ret += "0";
            else
                ret += "1";

        return ret;
    }*/
    //! -> A Needle in the Haystack
    /*public static string CWFindNeedle(object[] haystack)
    //Console.WriteLine(_8Kata.FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));
    {
        return "found the needle at position " + Array.IndexOf(haystack, "needle");
    }
    public static string FindNeedle(object[] haystack) =>
        $"found the needle at position {haystack.ToList().IndexOf("needle")}";*/
    //! -> Reversed Strings
    /* public static string CWSolution(string str)
    {
        return new string(str.ToArray().Reverse().ToArray());
    }
    public static string Solution(string str) => string.Concat(str.Select(i => i).Reverse());*/
}
}
