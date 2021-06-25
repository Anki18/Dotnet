using System;

namespace Struct
{

    //struct is the value type data type that represents data structures. 
    //It can contain a parameterized constructor, static constructor, constants, fields, methods, 
    //properties, indexers, operators, events, and nested types.
    struct Book
    {
        public string Name;
        public int Price;

        //public string PurchaseUser { get; set; }

        //must include all the fields in the ctor other wise it gives error
        public Book(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "The Alchemist";
            book.Price = 200;
            Console.WriteLine($"First book details is {book.Name} , {book.Price}");
            //using parameterized ctor
            Book economicBook = new Book("Rich dad poor dad", 300);
            Console.WriteLine($"Second book details is {economicBook.Name} , {economicBook.Price}");
        }
    }
}
