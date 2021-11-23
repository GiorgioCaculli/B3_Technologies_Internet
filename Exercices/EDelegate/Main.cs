using System;
using System.Globalization;

namespace EDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Exercice 1");
            Exercice1();
            Console.WriteLine("Exercice 2");
            Exercice2();
            Console.WriteLine("Exercice 3");
            Exercice3();
        }

        public static void Exercice1()
        {
            ProcessString ps = DeleteUpper;
            Console.WriteLine(ps("DeLeTe UpPeRcAsE LeTtErS"));
            ps = DeleteLower;
            Console.WriteLine(ps("DeLeTe LoWeRcAsE LeTtErS"));
        }

        public delegate string ProcessString(string str);

        public static string DeleteUpper(string str)
        {
            Console.WriteLine("Original String: " + str);
            string newString = "";
            foreach (char c in str)
            {
                if (!Char.IsUpper(c))
                {
                    newString += c;
                }
            }

            str = newString;

            return str;
        }

        public static string DeleteLower(string str)
        {
            Console.WriteLine("Original String: " + str);
            string newString = "";
            foreach (char c in str)
            {
                if (!Char.IsLower(c))
                {
                    newString += c;
                }
            }

            str = newString;

            return str;
        }

        public static void Exercice2()
        {
            string originalString = "Bonjour tout le monde";
            string searchedString = "tout";
            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Searched String: " + searchedString);
            Console.Write("Word count: ");
            Console.WriteLine(CountWordsFromString("Bonjour tout le monde", word=>word.Equals("tout")));
        }

        public delegate bool WordInString(string str);

        public static int CountWordsFromString(string str, WordInString wordInString)
        {
            int count = 0;
            foreach (string word in str.Split())
            {
                if (wordInString(word))
                {
                    count++;
                }
            }
            return count;
        }

        public static void Exercice3()
        {
            Func<int, int, int > mult = delegate(int a, int b) { return a * b; };
            Console.WriteLine(mult(3, 6));
            Action<string, string> concat = delegate(string a, string b) { Console.WriteLine(a + " : " + b); };
            concat("String 1", "String 2");
            Predicate<int> pair = delegate(int i) { return i % 2 == 0; };
            Console.WriteLine(pair(2));
            Console.WriteLine(pair(1));
        }
    }
}
