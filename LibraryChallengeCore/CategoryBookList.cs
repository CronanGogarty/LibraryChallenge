using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryChallengeCore
{
    public class CategoryBookList
    {
        public string Category { get; set; }
        public IEnumerable<ILibraryBook> Books { get; set; }
        public decimal CategoryTotalFine { get; set; }

        //public CategoryBookList()
        //{

        //}

        public CategoryBookList(IEnumerable<ILibraryBook> books, string category, decimal categoryTotalFine)
        {
            if (books != null)
            {
                Books = books;
            }
            if (category != null)
            {
                Category = category;
            }
            if (true)    //TODO: test type is decimal
            {
                CategoryTotalFine = categoryTotalFine;
            }
        }
    }
}
