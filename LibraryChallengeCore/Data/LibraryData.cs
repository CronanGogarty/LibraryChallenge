using System;
using System.Collections.Generic;

namespace LibraryChallengeCore.Data
{
    public class LibraryData
    {
        private const string Customer1 = "CUST001";
        private const string Customer2 = "CUST002";
        private const string Customer3 = "CUST003";
        private const string Customer4 = "CUST004";
        private const string Customer5 = "CUST005";
        private const string Customer6 = "CUST006";

        public IList<ILibraryBook> Books
        {
            get
            {
                var books = new List<ILibraryBook>();

                books.Add(new LibraryBook
                {
                    Title = "The Diving Bell and the Butterfly",
                    Author = "Jean-Dominique Bauby",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-816-8",
                    PublishedDate = DateTime.Parse("1909-02-11"),

                    DueDate = DateTime.Now.AddDays(5),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "All Over But the Shoutin'",
                    Author = "Rick Bragg",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-802-1",
                    PublishedDate = DateTime.Parse("1911-11-20"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,

                    BookId = new Guid("9D2B0228-4D0D-4C23-8B49-01A698857709"),
                });
                books.Add(new LibraryBook
                {
                    Title = "The Long Season",
                    Author = "Jim Brosnan",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-811-3",
                    PublishedDate = DateTime.Parse("1924-09-29"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Night of the Gun",
                    Author = "David Carr",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-699-7",
                    PublishedDate = DateTime.Parse("1930-05-07"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Short and Tragic Life of Robert Peace",
                    Author = "Jeff Hobbs",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-797-0",
                    PublishedDate = DateTime.Parse("1934-10-31"),

                    DueDate = DateTime.Now.AddDays(-2),
                    LentToCustomerId = Customer3,
                });
                books.Add(new LibraryBook
                {
                    Title = "How to Be a Woman",
                    Author = "Caitlin Moran",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-762-8",
                    PublishedDate = DateTime.Parse("1940-07-04"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "John Lennon: The Life",
                    Author = "Philip Norman",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-803-8",
                    PublishedDate = DateTime.Parse("1940-09-16"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Twelve Years a Slave",
                    Author = "Solomon Northup",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-810-6",
                    PublishedDate = DateTime.Parse("1944-10-26"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "You'll Never Eat Lunch in This Town Again",
                    Author = "Julia Phillips",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-794-9",
                    PublishedDate = DateTime.Parse("1951-05-11"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Samuel Pepys: The Unequaled Self",
                    Author = "Claire Tomalin",
                    Category = LibraryBookCategory.Biography,
                    Isbn = "978-962-217-782-6",
                    PublishedDate = DateTime.Parse("1952-07-22"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Modern Romance",
                    Author = "Aziz Ansari",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-804-5",
                    PublishedDate = DateTime.Parse("1954-11-11"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Yes Please",
                    Author = "Amy Poehler",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-489-4",
                    PublishedDate = DateTime.Parse("1955-05-18"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Fahrenheit 451: A Novel",
                    Author = "Ray Bradbury",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-718-5",
                    PublishedDate = DateTime.Parse("1957-12-27"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "1984 (Signet Classics)",
                    Author = "George Orwell",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-701-7",
                    PublishedDate = DateTime.Parse("1960-08-23"),

                    DueDate = DateTime.Now.AddDays(31),
                    LentToCustomerId = Customer6,
                });
                books.Add(new LibraryBook
                {
                    Title = "Sick in the Head: Conversations About...",
                    Author = "Judd Apatow",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-805-2",
                    PublishedDate = DateTime.Parse("1962-03-13"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Primates of Park Avenue: A Memoir",
                    Author = "Wednesday Martin",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-783-3",
                    PublishedDate = DateTime.Parse("1969-07-14"),

                    DueDate = DateTime.Now,
                    LentToCustomerId = Customer3,
                });
                books.Add(new LibraryBook
                {
                    Title = "What If?: Serious Scientific Answers...",
                    Author = "Randall Munroe",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-659-1",
                    PublishedDate = DateTime.Parse("1977-12-07"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Mother Tongue: English and How it...",
                    Author = "Bill Bryson",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-714-7",
                    PublishedDate = DateTime.Parse("1977-12-14"),

                    DueDate = DateTime.Now.AddDays(1),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "Bossypants",
                    Author = "Tina Fey",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-792-5",
                    PublishedDate = DateTime.Parse("1978-09-11"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Breakfast of Champions",
                    Author = "Kurt Vonnegut",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-766-6",
                    PublishedDate = DateTime.Parse("1979-12-10"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Red vs. Blue",
                    Author = "Rooster Teeth",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-835-9",
                    PublishedDate = DateTime.Parse("1994-01-27"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Selp-Helf",
                    Author = "Miranda Sings",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-748-2",
                    PublishedDate = DateTime.Parse("2003-09-08"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Slaughterhouse-Five",
                    Author = "Kurt Vonnegut",
                    Category = LibraryBookCategory.Humour,
                    Isbn = "978-962-217-674-7",
                    PublishedDate = DateTime.Parse("2004-12-21"),

                    DueDate = DateTime.Now.AddDays(30),
                    LentToCustomerId = Customer4,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Girl with the Dragon Tattoo (Millennium)",
                    Author = "Stieg Larsson",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-754-3",
                    PublishedDate = DateTime.Parse("2007-10-15"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "And Then There Were None",
                    Author = "Agatha Christie",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-763-5",
                    PublishedDate = DateTime.Parse("2011-03-31"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Angels & Demons (Robert Langdon)",
                    Author = "Dan Brown",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-812-0",
                    PublishedDate = DateTime.Parse("1909-08-31"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Rebecca",
                    Author = "Daphne du Maurier",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-780-2",
                    PublishedDate = DateTime.Parse("1910-11-23"),

                    DueDate = DateTime.Now.AddDays(6),
                    LentToCustomerId = Customer4,
                });
                books.Add(new LibraryBook
                {
                    Title = "In Cold Blood",
                    Author = "Truman Capote",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-814-4",
                    PublishedDate = DateTime.Parse("1912-03-20"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Godfather",
                    Author = "Mario Puzo",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-791-8",
                    PublishedDate = DateTime.Parse("1916-07-13"),

                    DueDate = DateTime.Now.AddDays(-101),
                    LentToCustomerId = Customer6,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Lovely Bones",
                    Author = "Alice Sebold",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-786-4",
                    PublishedDate = DateTime.Parse("1927-10-28"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Shutter Island",
                    Author = "Dennis Lehane",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-710-9",
                    PublishedDate = DateTime.Parse("1931-04-06"),

                    DueDate = DateTime.Now.AddDays(-17),
                    LentToCustomerId = Customer2,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Firm",
                    Author = "John Grisham",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-767-3",
                    PublishedDate = DateTime.Parse("1934-01-12"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Name of the Rose",
                    Author = "Umberto Eco",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-827-4",
                    PublishedDate = DateTime.Parse("1935-02-11"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Mystic River",
                    Author = "Dennis Lehane",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-831-1",
                    PublishedDate = DateTime.Parse("1937-04-16"),

                    DueDate = DateTime.Now.AddDays(2),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Alienist (Dr. Laszlo Kreizler)",
                    Author = "Caleb Carr",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-808-3",
                    PublishedDate = DateTime.Parse("1937-07-29"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Shadow of the Wind (The Cemetery of Forgotten Books)",
                    Author = "Carlos Ruiz Zafón",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-855-7",
                    PublishedDate = DateTime.Parse("1937-11-30"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Big Sleep",
                    Author = "Raymond Chandler",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-832-8",
                    PublishedDate = DateTime.Parse("1942-01-28"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "One for the Money (Stephanie Plum)",
                    Author = "Janet Evanovich",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-758-1",
                    PublishedDate = DateTime.Parse("1944-04-20"),

                    DueDate = DateTime.Now.AddDays(-45),
                    LentToCustomerId = Customer4,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Maltese Falcon",
                    Author = "Dashiell Hammett",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-813-7",
                    PublishedDate = DateTime.Parse("1944-11-08"),

                    DueDate = DateTime.Now,
                    LentToCustomerId = Customer2,
                });
                books.Add(new LibraryBook
                {
                    Title = "Presumed Innocent (Kindle County Legal Thriller)",
                    Author = "Scott Turow",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-834-2",
                    PublishedDate = DateTime.Parse("1949-05-31"),

                    DueDate = DateTime.Now.AddDays(5),
                    LentToCustomerId = Customer2,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Thirteenth Tale",
                    Author = "Diane Setterfield",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-785-7",
                    PublishedDate = DateTime.Parse("1955-01-24"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Complete Stories and Poems",
                    Author = "Edgar Allan Poe",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-752-9",
                    PublishedDate = DateTime.Parse("1955-02-16"),

                    DueDate = DateTime.Now.AddDays(-83),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "In the Woods (Dublin Murder Squad)",
                    Author = "Tana French",
                    Category = LibraryBookCategory.Mystery,
                    Isbn = "978-962-217-772-7",
                    PublishedDate = DateTime.Parse("1956-04-18"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Beautiful Disaster (Beautiful)",
                    Author = "Jamie McGuire",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-761-1",
                    PublishedDate = DateTime.Parse("1967-05-23"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-824-3",
                    PublishedDate = DateTime.Parse("1986-07-24"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Twilight (Twilight)",
                    Author = "Stephenie Meyer",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-820-5",
                    PublishedDate = DateTime.Parse("1986-07-28"),

                    DueDate = DateTime.Now.AddDays(-12),
                    LentToCustomerId = Customer2,
                });
                books.Add(new LibraryBook
                {
                    Title = "Perfect Chemistry (Perfect Chemistry)",
                    Author = "Simone Elkeles",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-770-3",
                    PublishedDate = DateTime.Parse("1986-11-27"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Notebook (The Notebook)",
                    Author = "Nicholas Sparks",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-818-2",
                    PublishedDate = DateTime.Parse("1999-12-10"),

                    DueDate = DateTime.Now.AddDays(7),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "Thoughtless (Thoughtless)",
                    Author = "S.C. Stephens",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-822-9",
                    PublishedDate = DateTime.Parse("2005-01-07"),

                    DueDate = DateTime.Now.AddDays(7),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "Bared to You (Crossfire)",
                    Author = "Sylvia Day",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-796-3",
                    PublishedDate = DateTime.Parse("2007-06-22"),

                    DueDate = DateTime.Now.AddDays(-7),
                    LentToCustomerId = Customer5,
                });
                books.Add(new LibraryBook
                {
                    Title = "Jane Eyre",
                    Author = "Charlotte Brontë",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-801-4",
                    PublishedDate = DateTime.Parse("1907-11-26"),

                    DueDate = DateTime.Now.AddDays(3),
                    LentToCustomerId = Customer6,
                });
                books.Add(new LibraryBook
                {
                    Title = "Outlander (Outlander)",
                    Author = "Diana Gabaldon",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-823-6",
                    PublishedDate = DateTime.Parse("1915-06-22"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Easy (Contours of the Heart)",
                    Author = "Tammara Webber",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-837-3",
                    PublishedDate = DateTime.Parse("1923-08-22"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Gabriel's Inferno (Gabriel's Inferno)",
                    Author = "Sylvain Reynard",
                    Category = LibraryBookCategory.Romance,
                    Isbn = "978-962-217-677-5",
                    PublishedDate = DateTime.Parse("1930-12-29"),

                    DueDate = DateTime.Now.AddDays(13),
                    LentToCustomerId = Customer6,
                });
                books.Add(new LibraryBook
                {
                    Title = "Dune",
                    Author = "Frank Herbert",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-644-7",
                    PublishedDate = DateTime.Parse("1932-04-22"),

                    DueDate = DateTime.Now.AddDays(-22),
                    LentToCustomerId = Customer5,
                });
                books.Add(new LibraryBook
                {
                    Title = "Ender’s Game (Ender Quartet)",
                    Author = "Orson Scott Card",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-800-7",
                    PublishedDate = DateTime.Parse("1934-01-15"),

                    DueDate = DateTime.Now.AddDays(-34),
                    LentToCustomerId = Customer3,
                });
                books.Add(new LibraryBook
                {
                    Title = "Starship Troopers",
                    Author = "Robert Heinlein",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-790-1",
                    PublishedDate = DateTime.Parse("1939-07-13"),

                    DueDate = DateTime.Now.AddDays(9),
                    LentToCustomerId = Customer6,
                });
                books.Add(new LibraryBook
                {
                    Title = "Foundation (Foundation Series)",
                    Author = "Issac Asimov",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-715-4",
                    PublishedDate = DateTime.Parse("1939-11-07"),

                    DueDate = DateTime.Now.AddDays(-9),
                    LentToCustomerId = Customer3,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Stars My Destination",
                    Author = "Alfred Bester",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-715-8",
                    PublishedDate = DateTime.Parse("1941-02-18"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "2001: A Space Odyssey",
                    Author = "Author C. Clarke",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-763-1",
                    PublishedDate = DateTime.Parse("1943-11-02"),

                    DueDate = DateTime.Now.AddDays(-1),
                    LentToCustomerId = Customer1,
                });
                books.Add(new LibraryBook
                {
                    Title = "Hyperion Cantos",
                    Author = "Dan Simmons",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-812-2",
                    PublishedDate = DateTime.Parse("1945-03-19"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Neuromancer",
                    Author = "William Gibson",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-780-5",
                    PublishedDate = DateTime.Parse("1946-01-28"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Hitchhiker’s Guide to The Galaxy",
                    Author = "Douglas Adams",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-814-6",
                    PublishedDate = DateTime.Parse("1946-02-25"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Ubik",
                    Author = "Philip K. Dick",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-791-8",
                    PublishedDate = DateTime.Parse("1946-05-29"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "The Forever War",
                    Author = "Joe Haldman",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-786-9",
                    PublishedDate = DateTime.Parse("1952-01-02"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Snow Crash",
                    Author = "Neal Stephenson",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-711-9",
                    PublishedDate = DateTime.Parse("1953-09-02"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "A Fire Upon the Deep (Zones of Thought)",
                    Author = "Vernor Vinge",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-727-3",
                    PublishedDate = DateTime.Parse("1955-11-10"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Old Man's War (Cold Fire Trilogy)",
                    Author = "John Scalzi",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-827-2",
                    PublishedDate = DateTime.Parse("1957-04-16"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Altered Carbon (Takeshi Kovacs Novels)",
                    Author = "Richard Morgan",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-831-1",
                    PublishedDate = DateTime.Parse("1964-07-13"),

                    DueDate = DateTime.Now.AddDays(6),
                    LentToCustomerId = Customer3,
                });
                books.Add(new LibraryBook
                {
                    Title = "Book of the New Sun",
                    Author = "Gene Wolfe",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-808-3",
                    PublishedDate = DateTime.Parse("1965-08-13"),

                    DueDate = null,
                    LentToCustomerId = string.Empty,
                });
                books.Add(new LibraryBook
                {
                    Title = "Player of Games (Culture)",
                    Author = "Iain M. Banks",
                    Category = LibraryBookCategory.Scifi,
                    Isbn = "978-962-217-855-7",
                    PublishedDate = DateTime.Parse("1970-01-21"),

                    DueDate = DateTime.Now,
                    LentToCustomerId = Customer1,
                });


                return books;
            }
        }
    }
}
