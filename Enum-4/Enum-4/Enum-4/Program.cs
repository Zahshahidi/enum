using System;

namespace Enum_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.title = "The Alchemist";
            b1.author = "Paulo Coelho";
            b1.price = 15;

            b1.printInfo();
        }
    }

    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int price { get; set; }

        public void printInfo()
        {
            Console.WriteLine("The title of the book is : " + title);
            Console.WriteLine("The author of the book is : " + author);
            Console.WriteLine("The price of the book is :  " + price);
        }

    }
}
