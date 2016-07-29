﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LibraryChallengeCore;
using System.Linq;

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
                    book.DueDate = dueDate;
                    return Request.CreateResponse(HttpStatusCode.OK, new { BookId = bookId, DueDate = dueDate });
                }
                message = result.Message;
            }
            else
            {
                message = "Book does not exist";
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest, message);
        }

        [Route("api/library/books/sort")]
        public HttpResponseMessage GetSortedLibraryBooks()
        {
            var libraryService = new LibraryService();
            HttpResponseMessage response = new HttpResponseMessage();

            List<CategoryBookList> listOfCategories = new List<CategoryBookList>();

            foreach (LibraryBookCategory category in Enum.GetValues(typeof(LibraryBookCategory)))
            {
                IEnumerable<ILibraryBook> books = libraryService.AllBooks(category);
                List<ILibraryBook> bookList = books.ToList<ILibraryBook>();

                ILibraryBookFineCalculator calculator = new LibraryBookFineCalculator();

                CategoryBookList catBookList = new CategoryBookList(bookList);
                catBookList.CategoryTotalFine = calculator.CalculateTotalFine(DateTime.Now, bookList);
                catBookList.CategoryString = category.ToString();
                //catBookList.Category = category;
                listOfCategories.Add(catBookList);
            }
            
            ////int removeComma;

            ////HttpResponseMessage.
            //string jsonResult = "{\n\"Books\":\n{";

            ////foreach (LibraryBookCategory category in Enum.GetValues(typeof(LibraryBookCategory)))
            ////{
            ////    jsonResult += "\"" + category.ToString() + "\": [";
            ////    IEnumerable<ILibraryBook> books = libraryService.AllBooks(category);

            ////    foreach (ILibraryBook book in books)
            ////    {

            ////        jsonResult += "{ \"title\":\"" + book.Title + "\", \"author\":\"" + book.Author + "\", \"isbn\":\"" + book.Isbn + "\", \"dueDate\":\"" + book.DueDate + "\"},\n";
            ////    }
            ////    removeComma = jsonResult.LastIndexOf(',');
            ////    jsonResult = jsonResult.Remove(removeComma, 1);
            ////    jsonResult += "],";
            ////}
            ////    removeComma = jsonResult.LastIndexOf(',');
            ////    jsonResult = jsonResult.Remove(removeComma, 1);
            //    jsonResult += "}}";

            return Request.CreateResponse(HttpStatusCode.OK, listOfCategories);
        }
    }
}
