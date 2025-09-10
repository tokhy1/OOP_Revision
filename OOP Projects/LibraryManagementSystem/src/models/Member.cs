using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Member : User
    {
        // private because you cannot update the borrowed books outside of this class, the member is the only person who's responsible to borrow books.
        public List<Book> BorrowedBooks { get; private set; }
        public Member(string name, string email, int age, string phoneNumber) : base(name, email, age, phoneNumber)
        {
            BorrowedBooks = new List<Book>();
        }


        public bool BorrowBook(Book book)
        {
            // it doesn't make sense to borrow the same book twice
            if (BorrowedBooks.Any(b => b.Id == book.Id))
                return false;

            if (!book.Borrow())
                return false;

            BorrowedBooks.Add(book);
            return true;
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Remove(book))
                book.Return();

        }

        public override string GetDetails()
        {
            return $"{Name} ({Email}) - Borrowed {BorrowedBooks.Count} books";
        }
    };
}