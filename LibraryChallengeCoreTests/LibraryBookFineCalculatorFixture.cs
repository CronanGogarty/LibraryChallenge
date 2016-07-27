using System;
using System.Collections.Generic;
using LibraryChallengeCore;
using NUnit.Framework;

namespace LibraryChallengeCoreTests
{
    [TestFixture]
    public class LibraryBookFineCalculatorFixture
    {
        [Test]
        public void NoBooks_ShouldBeZero()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook>();
            
            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 0M, "The total fine should be 0");
        }

        [Test]
        public void OneBookNoDueDate_ShouldBeZero()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook> {new LibraryBook {Title = "Book1", Category = LibraryBookCategory.Humour, DueDate = null}};

            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 0M, "The total fine should be 0");
        }
        
        [Test]
        public void OneBookFiveDaysOver_IncludesASunday()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook> { new LibraryBook { Title = "Book1", Category = LibraryBookCategory.Mystery, DueDate = new DateTime(2015, 06, 24) } };

            //should 0.40, 28th is a Sunday

            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 0.4M, "The total fine should be 0.40");
        }

        [Test]
        public void OneBookFifteenDaysOver_IncludesASundayAndAWednesday()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook> { new LibraryBook { Title = "Book1", Category = LibraryBookCategory.Romance, DueDate = new DateTime(2015, 06, 14) } };

            //17 is a wednesday
            //21 is a sunday
            //24 is a wednesday
            //28 is a sunday
            //should be 1.62

            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 1.62M, "The total fine should be 1.62");
        }

        [Test]
        public void OneBookNotOverdue()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook> { new LibraryBook { Title = "Book1", Category = LibraryBookCategory.Biography, DueDate = new DateTime(2015, 07, 01) } };
            
            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 0M, "The total fine should be 0");
        }

        [Test]
        public void OneBookSixtyDaysOver()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook> { new LibraryBook { Title = "Book1", Category = LibraryBookCategory.Scifi, DueDate = new DateTime(2015, 04, 30) } };

            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 8.94M, "The total fine should be 8.94");
        }

        [Test]
        public void OneBookTwentyTwoDaysOver_NonFiction()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook> { new LibraryBook { Title = "Book1", Category = LibraryBookCategory.Biography, DueDate = new DateTime(2015, 06, 07) } };

            decimal totalFine = calculator.CalculateTotalFine(date, books);

            Assert.That(totalFine == 1.92M, "The total fine should be 1.92");
        }

        [Test]
        public void MultipleBooks()
        {
            var calculator = new LibraryBookFineCalculator();

            var date = new DateTime(2015, 06, 29);

            var books = new List<ILibraryBook>
            {
                new LibraryBook
                {
                    Title = "Book1",
                    Category = LibraryBookCategory.Biography,
                    DueDate = new DateTime(2015, 06, 07)
                },
                new LibraryBook
                {
                    Title = "Book2",
                    Category = LibraryBookCategory.Scifi,
                    DueDate = new DateTime(2015, 04, 30)
                },
                new LibraryBook
                {
                    Title = "Book3",
                    Category = LibraryBookCategory.Romance,
                    DueDate = new DateTime(2015, 06, 14)
                },
                new LibraryBook {Title = "Book4", Category = LibraryBookCategory.Humour, DueDate = null}
            };

            decimal totalFine = calculator.CalculateTotalFine(date, books);
            
            Assert.That(totalFine == 12.49M, "The total fine should be 12.49");
        }
    }
}
