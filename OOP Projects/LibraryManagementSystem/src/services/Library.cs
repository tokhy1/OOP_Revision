using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> Books { get; private set; }
        public List<Member> Members { get; private set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public Book SearchBookByTitle(string title)
        {
            return Books.Find(b => b.Title == title);
        }

        public Book SearchBookByAuthor(string author)
        {
            return Books.Find(b => b.Author == author);
        }

        public Book SearchBookById(int id)
        {
            return Books.Find(b => b.Id == id);
        }

        public void RegisterMember(Member member)
        {
            Members.Add(member);
        }
        public void RemoveMember(Member member)
        {
            Members.Remove(member);
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
    }
}