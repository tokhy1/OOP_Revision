using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Library Management System Test ===\n");

            // Create a library
            Library library = new Library();

            // Create some books
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, 3);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 2);
            Book book3 = new Book("1984", "George Orwell", 1949, 1);

            // Create a librarian
            Librarian librarian = new Librarian("Alice Johnson", "alice@library.com", 35, "555-1234", "EMP001");
            Console.WriteLine("Librarian created: " + librarian.GetDetails());

            // Librarian adds books to library
            librarian.AddBook(book1, library);
            librarian.AddBook(book2, library);
            librarian.AddBook(book3, library);
            Console.WriteLine($"\nAdded {library.Books.Count} books to the library");

            // Create members
            Member member1 = new Member("John Smith", "john@email.com", 28, "555-9876");
            Member member2 = new Member("Sarah Wilson", "sarah@email.com", 32, "555-4567");

            // Register members
            library.RegisterMember(member1);
            library.RegisterMember(member2);
            Console.WriteLine($"Registered {library.Members.Count} members\n");

            // Display all books
            Console.WriteLine("Available Books:");
            foreach (var book in library.Books)
            {
                Console.WriteLine("  " + book.ToString());
            }

            // Test borrowing books
            Console.WriteLine("\n=== Testing Book Borrowing ===");

            // Member1 borrows a book
            bool borrowResult1 = member1.BorrowBook(book1);
            Console.WriteLine($"{member1.Name} borrowed '{book1.Title}': {borrowResult1}");
            Console.WriteLine($"Available copies of '{book1.Title}': {book1.CopiesAvailable}");

            // Member2 tries to borrow the same book
            bool borrowResult2 = member2.BorrowBook(book1);
            Console.WriteLine($"{member2.Name} borrowed '{book1.Title}': {borrowResult2}");

            // Member2 borrows a different book
            bool borrowResult3 = member2.BorrowBook(book2);
            Console.WriteLine($"{member2.Name} borrowed '{book2.Title}': {borrowResult3}");

            // Display member details
            Console.WriteLine($"\n{member1.GetDetails()}");
            Console.WriteLine($"{member2.GetDetails()}");

            // Test returning books
            Console.WriteLine("\n=== Testing Book Returning ===");
            member1.ReturnBook(book1);
            Console.WriteLine($"{member1.Name} returned '{book1.Title}'");
            Console.WriteLine($"Available copies of '{book1.Title}': {book1.CopiesAvailable}");

            // Test searching for books
            Console.WriteLine("\n=== Testing Book Search ===");
            Book foundBook = library.SearchBookByTitle("1984");
            if (foundBook != null)
            {
                Console.WriteLine($"Found book: {foundBook.ToString()}");
            }

            // Test adding more copies
            Console.WriteLine("\n=== Testing Adding Copies ===");
            book3.AddCopies(2);
            Console.WriteLine($"Added copies to '{book3.Title}'. Now available: {book3.CopiesAvailable}");

            Console.WriteLine("\n=== Test Completed ===");
        }
    }
}