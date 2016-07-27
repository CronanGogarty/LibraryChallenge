
--library challenge 

*Scenario
In our example tasks we are starting to build a solution that will allow libraries to manage the books they are loaning to members.
The first task is a implement a method that will allow for library fines to be calculated for a collection of books. 
There are a number of rules that need to be applied to each book for the period of time it is overdue.
The second task is extending the existing web api with a new feature that allow books to be listed grouped by category 
and display these results using HTML.

*Suggested environment (if you dont already have Visual Studio)
1. Visual Studio 2013 community edition
2. The web project can be started from within Visual Studio
3. The unit tests are using NUnit. These should be runnable / debuggable from the Test Explorer window.

*General Info
Please return the challenge to us within 48 hours of downloading / branching the project

*Library Challenge tasks

*Task 1

Steps
1. The method CalculateTotalFine() can be found in the class LibraryChallengeCore\LibraryFineCalculator.cs. 
Using the rules below implement the method.
2. Make sure the tests pass in the class LibraryChallengeCoreTests\LibraryBookFineCalculatorFixture.cs.

Rules

The fine for an individual book is calculated using the following rules 

For every day the book is over due:
1. The library is closed on Sundays. If the day is a sunday the result for this day is 0.00.
2. Wednesdays are "double fine" day. If the day is a Wednesday the result for that day is double.
3. For days 1 - 10 the fine per day is 0.10.
4. For days 11 - 20 the fine per day is 0.13.
5. For days 21 - 50 the fine per day is 0.17.
6. For days 51+ the fine for the day is 1% of the total fine so far increasing by 0.3% every day.
	- e.g. day 51 is 1% of the current total fine, day 52 is 1.3% of the current total fine, day 53 is 1.6% of the current total fine.
	- Rule 1 does apply. However, even though this day results in 0.00 the percentage amount to be applied for the fine does still increase.
	- Rule 2 (double fine day Wednesday) does not apply once the book is in the 51+ days range.

Discounts
1. If the book is "non-fiction" (biography) then it gets a 25% discount on its total fine.

Example 1
Sample of a fine for 1 book, over due by 14 days, in the category mystery

Book due date : June 13th 2015
Todays date : June 27th 2015
Category : Mystery

Day 1  - June 14th 2015 - SUN - $0.00 *
Day 2  - June 15th 2015 - MON - $0.10
Day 3  - June 16th 2015 - TUE - $0.10
Day 4  - June 17th 2015 - WED - $0.20 *
Day 5  - June 18th 2015 - THU - $0.10
Day 6  - June 19th 2015 - FRI - $0.10
Day 7  - June 20th 2015 - SAT - $0.10
Day 8  - June 21st 2015 - SUN - $0.00 * 
Day 9  - June 22nd 2015 - MON - $0.10
Day 10 - June 23rd 2015 - TUE - $0.10
Day 11 - June 24th 2015 - WED - $0.26 *
Day 12 - June 25th 2015 - THU - $0.13
Day 13 - June 26th 2015 - FRI - $0.13
Day 14 - June 27th 2015 - SAT - $0.13

Discount - $0.00
Total - $1.55

--

Example 2
A second sample of how the % discount is calculated. (This is using 2 digit decimal numbers for ease of reading. At runtime there will be more decimal places)

This book is overdue by 59 days

First 47 days... then
Day 48 - THU - $0.17
Day 49 - FRI - $0.17
Day 50 - SAT - $0.17 (The example total to this point is $6.55)
Day 51 - SUN - $0.00 (1%) *
Day 52 - MON - $0.08 (1.3% of $6.55)
Day 53 - TUE - $0.10 (1.6% of $6.63)
Day 54 - WED - $0.12 (1.9% of $6.73)
Day 55 - THU - $0.15 (2.2% of $6.85)
Day 56 - FRI - $0.17 (2.5% of $7.00)
Day 57 - SAT - $0.20 (2.8% of $7.17)
Day 58 - SUN - $0.00 (3.1%) *
Day 59 - MON - $0.24 (3.4% of $7.17)

Total - $7.41

------------------------------------------------------------------------------------

Complete Task 2 using either jquery or reactjs 

*Task 2 (jquery)

Library Challenge notes

1. There are 3 existing api endpoints 
	/api/library/books 
	and 
	/api/library/books/{category} where an example would be /api/library/books/mystery
	and
	/api/library/books/{bookid}/checkout - used to set the due date for a book

Steps
1. Use the file task2.html to display the results.
2. Create a new api end point in C# that returns all books grouped by category and within each category ordered by title. See LibraryChallengeWeb/Controllers/api/LibraryBooksController.cs
3. Using this new api end point display a list of books grouped by category. 
	- Show the category name then a list of books in the category. 
	- Show the book title, author, isbn, due date.
	- Highlight the book in orange is it is due today. 
	- Highlight the book in red if it is over due.
	- Highlight the book in green if it has a due date in the future.
	- Show a count of the number of books in the category next to the category name
	- Show the total amount of library fines outstanding for the category.
	- When a user clicks on the category show / hide (expand / collapse) the books within the category.

e.g.

Biography (3) - $5.92
	book 1
	book 2
	book 3
Mystery (4) - $0.50
	book 1
	book 2
	book 3
	book 4
etc etc

--Task 2 (reactjs)

The rules and tasks for the reactjs version are the same as the jquery version.
The file for task 2 is react/task2.html