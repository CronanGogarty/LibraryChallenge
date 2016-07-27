using System;
using System.Collections.Generic;
using System.Linq;
using LibraryChallengeCore.Data;

namespace LibraryChallengeCore
{
    public class LibraryService
    {
        private readonly IList<ILibraryBook> _books;

        public LibraryService()
        {
            _books = new LibraryData().Books;
        }

        public IList<ILibraryBook> AllBooks()
        {
            return _books;
        }

        public IEnumerable<ILibraryBook> AllBooks(LibraryBookCategory category)
        {
            return _books.Where(lb => lb.Category == category);
        }

        public ILibraryBook Book(Guid bookId)
        {
            return _books.FirstOrDefault(b => b.BookId == bookId);
        }
    }
}
