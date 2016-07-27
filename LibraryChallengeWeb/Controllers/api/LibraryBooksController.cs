using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibraryChallengeCore;

namespace LibraryChallengeWeb.Controllers.Api
{
    public class LibraryBooksController : ApiController
    {
        [Route("api/library/books")]
        public HttpResponseMessage GetAllLibraryBooks()
        {
            var libraryService = new LibraryService();

            IList<ILibraryBook> books = libraryService.AllBooks();

            return Request.CreateResponse(HttpStatusCode.OK, books);
        }

        [Route("api/library/books/{category}")]
        public HttpResponseMessage GetAllLibraryBooksForACategory(LibraryBookCategory category)
        {
            var libraryService = new LibraryService();

            IEnumerable<ILibraryBook> books = libraryService.AllBooks(category);

            return Request.CreateResponse(HttpStatusCode.OK, books);
        }

        [Route("api/library/books/{bookid}/checkout"), HttpPost]
        public HttpResponseMessage CheckoutALibraryBook(Guid bookId)
        {
            var libraryService = new LibraryService();

            ILibraryBook book = libraryService.Book(bookId);

            string message = string.Empty;
            if (book != null)
            {
                DateTime dueDate = DateTime.Now.AddDays(30);

                CheckoutResult result = book.Checkout();

                if (result.CheckedOutResultStatus == CheckedOutResultStatus.Ok)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { BookId = bookId, DueDate = dueDate });    
                }
                message = result.Message;
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, message);
        }
    }
}
