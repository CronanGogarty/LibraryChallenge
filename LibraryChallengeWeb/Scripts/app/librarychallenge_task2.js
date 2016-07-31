$(document).ready(function () {
    //alert('library challenge task 2 ready');
    document.getElementById('btnShowAll').addEventListener('click', showAll, false);
    document.getElementById('selCategory').addEventListener('change', showByCategory, false);
    $('#btnSortBooks').click(sortBooks);
    document.getElementById('btnCheckout').addEventListener('click', checkout, false);
    var searchType = document.getElementById('searchType');

    function toggleDetails(e) {
        var category = $(e);
        console.log(e);
    }

    function showAll() {
        var uri = 'api/library/books';
        searchType.textContent = "Show All Books"
        $('#library-challenge-results').empty();
        $.getJSON(uri)
            .done(function (data) {
                $.each(data, function (key, item) {
                    //$('<div>', { text: formatItem(item) }).appendTo('#library-challenge-results').addClass("bookDiv");
                    $('#library-challenge-results').append('<div class="bookDiv"><h3>Title:&nbsp;' + item.title + '</h3><div><strong>Author:</strong>&nbsp;' + item.author + '<div><div><strong>ISBN:</strong>&nbsp;' + item.isbn + '</div><div><strong>Category:</strong>&nbsp;' + item.category + '</div><div><strong>Published Date:</strong>&nbsp;' + item.publishedDate + '</div><div><strong>On Loan To:</strong>&nbsp;' + item.lentToCustomerId + '</div><div><strong>Due Date:</strong>&nbsp;' + item.dueDate + '</div><div><strong>Book GUID:</strong>&nbsp;' + item.bookId + '</div></div>');
                });
            });
    }

    function showByCategory() {

        var e = document.getElementById('selCategory');
        if (e.selectedIndex != 0) {

            var selectedCategory = e.options[e.selectedIndex].text;
            var uri = 'api/library/books/' + selectedCategory;
            searchType.textContent = "Show All " + selectedCategory + " Books";
            $('#library-challenge-results').empty();

            $.getJSON(uri)
                .done(function (data) {
                    $.each(data, function (key, item) {
                        //$('<div>', { text: formatItem(item) }).appendTo('#library-challenge-results').addClass("bookDiv");
                        $('#library-challenge-results').append('<div class="bookDiv"><h3>Title:&nbsp;' + item.title + '</h3><div><strong>Author:</strong>&nbsp;' + item.author + '<div><div><strong>ISBN:</strong>&nbsp;' + item.isbn + '</div><div><strong>Category:</strong>&nbsp;' + item.category + '</div><div><strong>Published Date:</strong>&nbsp;' + item.publishedDate + '</div><div><strong>On Loan To:</strong>&nbsp;' + item.lentToCustomerId + '</div><div><strong>Due Date:</strong>&nbsp;' + item.dueDate + '</div><div><strong>Book GUID:</strong>&nbsp;' + item.bookId + '</div></div>');
                    })
                });
        }

    }

    function sortBooks() {
        var uri = 'api/library/books/sort/';
        searchType.textContent = "Sort Books"
        $('#library-challenge-results').empty();

        $.getJSON(uri)
        
            .done(function (data) {
                $(data).each(function (index, catValue) {
                    //for each data object contained in the JSON payload
                    //1)create a category=container div with id="div"+Category
                    //2)add class to category-container
                    //3)append div to library-challenge-results div
                    //4)count the number of books in the category
                    
                    var bookCount = $(catValue.books).toArray().length;
                    var currentCategoryContainer = $('<div>').addClass('divCategoryContainer')
                        //.html("<summary><h2>" + catValue.category + "</h2><h3>Total Owed in Category: " + catValue.categoryTotalFine + "</h3><h4>Total Books: " + bookCount + "</h4></summary>")
                        .attr("id", function () {
                            return "div" + catValue.category;
                        })
                        .appendTo($('#library-challenge-results'))

                    var detailsWrapper = $('<details>').appendTo(currentCategoryContainer);

                    var currentSummary = $("<summary><h2>" + catValue.category + "</h2><h3>Total Owed in Category: " + catValue.categoryTotalFine + "</h3><h4>Total Books: " + bookCount + "</h4></summary>").on('click', toggleDetails)
                        .appendTo(detailsWrapper);

                    var bookPara = $('<p>').appendTo(detailsWrapper);
                    
                    //for each book within the category
                    $(catValue.books).each(function (index, bookValue) {
                        //set some variables to hold book data
                        var dateString = bookValue.dueDate;
                        var currentDueDate;
                        if (dateString != null && dateString != "") {
                            currentDueDate = new Date(dateString);
                        }
                        else
                            currentDueDate = null;

                        //instantiate a div for each book, add html to output book properties
                        //append this div to category container
                        var currentBook = $('<div>').addClass('divBookItem')
                            .html("<ul><li>" + bookValue.title + "</li><li>" + bookValue.author + "</li><li>" + bookValue.isbn + "</li><li>" + currentDueDate + "</li></ul>")
                            .attr("id", function () {
                                return "divBook" + bookValue.isbn
                            })
                        .appendTo(bookPara)

                        //add css class based on dueDate value
                        if (currentDueDate != null) {
                            if (currentDueDate < new Date(Date.now())) {
                                $(currentBook).addClass("dueDateOverdue");
                            }
                            else if (currentDueDate === new Date(Date.now())) {
                                $(currentBook).addClass("dueDateToday");
                            }
                            else {
                                $(currentBook).addClass("dueDateOK");
                            }
                        }
                        
                    })
                });
            });
    }



    //function formatCategory(item) {
    //    return "Category: " + item.categoryString + "; Total Due For Category: " + item.categoryTotalFine;
    //}

    //function formatBook(item) {
    //    return "Title: " + item.title + ";\nAuthor: " + item.author + ";\nISBN: " + item.isbn + ";\nDue Date: " + item.dueDate;
    //}

    function checkout() {
        var bookId = $('#txtBookId').val();
        var uri = 'api/library/books/' + bookId + '/checkout';
        searchType.textContent = "Checkout Book";
        $('#library-challenge-results').empty();
        $.post(uri)
            .done(function (data) {
                var bookId = data.bookId;
                var dueDate = new Date(data.dueDate);
                var outputString = "Book with ID = " + bookId + ";<br />has been checked out until " + dueDate.getDay() + "-" + (dueDate.getMonth() + 1) + "-" + dueDate.getFullYear();
                console.log(bookId + " " + dueDate);
                $('#library-challenge-results').html(outputString);
            });
    }

});