namespace ConsoleApp1
{
    using System;

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            Console.WriteLine("Insert the information of two books:");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Information of book 1:");
            Console.Write("Input name of the book: ");
            book1.Title = Console.ReadLine();
            Console.Write("Input the author: ");
            book1.Author = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Information of book 2:");
            Console.Write("Input name of the book: ");
            book2.Title = Console.ReadLine();
            Console.Write("Input the author: ");
            book2.Author = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Expected Output:");
            Console.WriteLine($"1: Title = {book1.Title}, Author = {book1.Author}");
            Console.WriteLine($"2: Title = {book2.Title}, Author = {book2.Author}");

            Console.ReadLine();
        }
    }
}