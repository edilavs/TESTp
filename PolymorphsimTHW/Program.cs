using System;

namespace PolyHW
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            book.Name = "Salam";
            book.Price = 8.99;
            book.Genre = "elmi";
            book.Author = "hiko";

            Book book1 = new Book();
            book1.Name = "S11";
            book1.Price = 21.99;
            book1.Genre = "e78i";
            book1.Author = "hikokokokok";

            Library library = new Library();
            library.AddProduct(book);
            library.AddProduct(book1);
            foreach (var item in library.GetProductsByPrice(20, 50))
            {
                item.GetInfo();
            }
        }
    }
}
