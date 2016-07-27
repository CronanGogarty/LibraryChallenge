using System;
using System.Collections.Generic;

namespace LibraryChallengeCore
{
    public class LibraryBookFineCalculator : ILibraryBookFineCalculator
    {
        /// <summary>
        /// Based on todays date calculate the fine for each book and return the total fine due for all of the books.
        /// Some books may not be currently checked out or may not be overdue
        /// 
        /// Rules
        /// 
        /// The fine for an individual book is calculated using the following rule 
        /// 
        /// 1. The library is closed on Sundays so no fees are calculated for Sundays
        /// 2. For days 1 - 10 the fine per day is 0.10
        /// 3. For days 11 - 20 the fine per day is 0.13
        /// 4. For days 21 - 50 the fine per day is 0.17
        /// 5. For days 51+ is 1% of the total fine increasing by 0.3% every day 
    	///     - e.g. day 51 1% of the current total, day 52 1.3% of the current total, day 53 1.6% for the current total
	    ///     - sundays still result in a 0 fine, but do increase the percentage amount
        /// 6. Wednesdays are "double fine" day. If the current day is a Wednesday then the fine for that day is double. Double fine day does not apply once the book is in the 51+ days range
        /// 7. If the book is "non-fiction" then is gets a 25% discount on its total fine
        ///  
        /// </summary>
        /// <param name="today">The date to check the books against to calculate the fine</param>
        /// <param name="books">A list of library books</param>
        /// <returns></returns>
        public decimal CalculateTotalFine(DateTime today, List<ILibraryBook> books)
        {
            decimal totalFine = 0;

            return Math.Truncate(100 * totalFine) / 100;
        }
    }
}