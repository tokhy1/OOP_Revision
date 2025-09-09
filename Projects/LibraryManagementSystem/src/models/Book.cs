using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Book
    {
        private static int NextBookID = 1; // For making the ID auto-increment

        // All properties are private because in real-world i cannot update the book it's already printed, instead i'm gonna create a new one :)
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public int CopiesAvailable { get; private set; }

        public Book(string title, string author, int year, int copiesAvailable)
        {
            // basic validation
            if (copiesAvailable < 0)
                throw new ArgumentException("Copies available cannot be negative");
            if (year > DateTime.Now.Year)
                throw new ArgumentException("Year cannot be in the future");

            Id = NextBookID++;
            Title = title;
            Author = author;
            Year = year;
            CopiesAvailable = copiesAvailable;
        }

        public bool Borrow()
        {
            if (CopiesAvailable <= 0) return false;
            CopiesAvailable--;
            return true;
        }

        public void Return()
        {
            CopiesAvailable++;
        }

        public void AddCopies(int additionalCopies)
        {
            if (additionalCopies <= 0)
                throw new ArgumentException("Additional copies must be positive");

            CopiesAvailable += additionalCopies;
        }

        // get the details of the book
        public override string ToString()
        {
            return $"[{Id}] {Title} by {Author} ({Year}) - Available Copies: {CopiesAvailable}";
        }
    }
}