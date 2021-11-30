using System;
using System.Globalization;
using EDelegate.Exercise4;

namespace EDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Exercise 1");
            Exercise1();
            Console.WriteLine("Exercise 2");
            Exercise2();
            Console.WriteLine("Exercise 3");
            Exercise3();
            Console.WriteLine("Exercise 4");
            Exercise4();
        }

        public static void Exercise1()
        {
            ProcessString ps = DeleteUpper;
            Console.WriteLine(ps("DeLeTe UpPeRcAsE LeTtErS"));
            ps = DeleteLower;
            Console.WriteLine(ps("DeLeTe LoWeRcAsE LeTtErS"));
        }

        private delegate string ProcessString(string str);

        private static string DeleteUpper(string str)
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

        private static string DeleteLower(string str)
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

        private static void Exercise2()
        {
            string originalString = "Bonjour tout le monde";
            string searchedString = "tout";
            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Searched String: " + searchedString);
            Console.Write("Word count: ");
            Console.WriteLine(CountWordsFromString("Bonjour tout le monde", word=>word.Equals("tout")));
        }

        private delegate bool WordInString(string str);

        private static int CountWordsFromString(string str, WordInString wordInString)
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

        private static void Exercise3()
        {
            Func<int, int, int > multiply = (a, b) => a * b;
            Console.WriteLine(multiply(3, 6));
            Action<string, string> concat = delegate(string a, string b) { Console.WriteLine(a + " : " + b); };
            concat("String 1", "String 2");
            Predicate<int> pair = delegate(int i) { return i % 2 == 0; };
            Console.WriteLine(pair(2));
            Console.WriteLine(pair(1));
        }

        public static void Exercise4()
        {
            Radio radio = new Radio()
            {
                Name = "La Zanzara"
            };
            Driver driver1 = new Driver()
            {
                Name = "Giorgio"
            };
            Driver driver2 = new Driver()
            {
                Name = "Tanguy"
            };
            Driver driver3 = new Driver()
            {
                Name = "Guillaume"
            };
        }
    }
}
