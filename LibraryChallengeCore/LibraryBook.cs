using System;

namespace LibraryChallengeCore
{
    public class LibraryBook : ILibraryBook
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public LibraryBookCategory Category { get; set; }
        public string Isbn { get; set; }
        public DateTime PublishedDate { get; set; }
        
        public CheckoutResult Checkout()
        {
            if (DueDate != null)
            {
                return new CheckoutResult { CheckedOutResultStatus = CheckedOutResultStatus.Error, Message = "Book already checked out!"};
            }

            return new CheckoutResult { CheckedOutResultStatus = CheckedOutResultStatus.Ok};
        }

        public string LentToCustomerId { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
