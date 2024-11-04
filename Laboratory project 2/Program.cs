using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Library

{
 class Program
 {
    static void Main(string[]args)
    {

        Book book1 = new Book ("The Great Gatsby","F. Scott Fitzgerald");
        book1.CheckOut();
        Book book2 = new Book ("Ulysses","James Joyce",720);
        book2.ReturnBook();

        Console.WriteLine(book1.ToString());
        Console.WriteLine(book2.ToString());
    }

}
}