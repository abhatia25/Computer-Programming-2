using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Author author1 = new Author();
            author1.name = "David Baldacci";
            author1.email = "david.baldacci@gmail.net";
            author1.gender = 'M';

            Book book1 = new Book(author1, "The Target");
            book1.price = 25.99;
            book1.unitsInStock = 8;

            Author author2 = new Author();
            author2.name = "John Doe";
            author2.email = "john.doe@gmail.net";
            author2.gender = 'M';

            Book book2 = new Book(author2, "The Lion");
            book2.price = 20.99;
            book2.unitsInStock = 5;

            Console.WriteLine("Author\nName: " + author1.name + "\nEmail: " + author1.email + "\nGender: " + author1.gender);
            Console.WriteLine("Book\nTitle: " + book1.title + "\nPrice: " + book1.price + "\nNumbers in Stock: " + book1.unitsInStock);
            Console.WriteLine("\nAuthor\nName: " + author2.name + "\nEmail: " + author2.email + "\nGender: " + author2.gender);
            Console.WriteLine("Book\nTitle: " + book2.title + "\nPrice: " + book2.price + "\nNumbers in Stock: " + book2.unitsInStock);
            Console.ReadLine();
        }
    }

    class Author
    {
        public string name { get; set; } //get and set are auto implementers
        public string email { get; set; }
        public char gender { get; set; }

        public Author () //() is default constructor
        {
            name = "";
            email = "";
            gender = '\0';
        }
    }

    class Book
    {
        public Author author { get; set; } //takes info from class author and brings it into class book
        public string title { get; set; }
        public double price { get; set; }
        public int unitsInStock { get; set; }

        public Book()
        {
            author = null;
            title = "";
            price = 0;
            unitsInStock = 0;
        }

        public Book(Author auth, string title)
        {
            author = auth;
            this.title = title;
            price = 0;
            unitsInStock = 0;
        }
    }
}
