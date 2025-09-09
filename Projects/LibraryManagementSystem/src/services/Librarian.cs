using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Librarian : User
    {
        public string EmployeeId { get; private set; }

        public Librarian(string name, string email, int age, string phoneNumber, string employeeId)
            : base(name, email, age, phoneNumber)
        {
            EmployeeId = employeeId;
        }

        public bool AddBook(Book book, Library library)
        {
            // Validation specific to librarian operations
            if (book == null)
                throw new ArgumentNullException(nameof(book));

            if (library == null)
                throw new ArgumentNullException(nameof(library));

            if (book.Year > DateTime.Now.Year + 1) // Can't add books from far future
                throw new InvalidOperationException("Cannot add books from the distant future");

            if (book.CopiesAvailable < 0)
                throw new InvalidOperationException("Cannot add book with negative copies");

            // Log the operation (real-world librarians keep records)
            Console.WriteLine($"[LOG] Librarian {Name} added book: {book.Title} to library");

            // Additional business logic
            if (library.Books.Any(b => b.Id == book.Id))
            {
                Console.WriteLine("Book already exists, adding copies instead...");
                var existingBook = library.Books.First(b => b.Id == book.Id);
                existingBook.AddCopies(book.CopiesAvailable);
                return true;
            }

            library.AddBook(book);
            return true;
        }

        public bool RemoveBook(Book book, Library library)
        {
            // Validation and business logic
            if (book == null || library == null)
                return false;

            if (library.Books.All(b => b.Id != book.Id))
            {
                Console.WriteLine("Book not found in this library");
                return false;
            }

            // Check if any member has borrowed this book
            bool isBorrowed = library.Members
                .Any(member => member.BorrowedBooks.Any(b => b.Id == book.Id));

            if (isBorrowed)
            {
                Console.WriteLine("Cannot remove book: Currently borrowed by members");
                return false;
            }

            Console.WriteLine($"[LOG] Librarian {Name} removed book: {book.Title}");
            library.RemoveBook(book);
            return true;
        }
    }
}
