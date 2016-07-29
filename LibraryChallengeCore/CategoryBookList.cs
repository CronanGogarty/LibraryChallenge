using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryChallengeCore
{
    public class CategoryBookList 
    {
        //public LibraryBookCategory Category { get; set; }
        public string CategoryString { get; set; }
        public IEnumerable<ILibraryBook> Books { get; set; }
        public decimal CategoryTotalFine { get; set; }

        public CategoryBookList(IEnumerable<ILibraryBook> books)
        {
            if (books != null)
            {
                Books = books;
            }
        }
    }
}
