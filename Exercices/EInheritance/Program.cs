using System;

namespace EInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Document book = new Book("Book Test 1", 100, "Book Author 1");
            Document magazine = new Magazine("Magazine Test 1", 100, 32);

            Console.WriteLine(book);
            Console.WriteLine(magazine);
        }
    }
}
