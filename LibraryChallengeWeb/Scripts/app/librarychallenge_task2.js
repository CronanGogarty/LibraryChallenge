$(document).ready(function () {
    //alert('library challenge task 2 ready');

    document.getElementById('btnShowAll').addEventListener('click', showAll, false);
    document.getElementById('selCategory').addEventListener('change', showByCategory, false);
    $('#btnSortBooks').click(sortBooks);
    document.getElementById('btnCheckout').addEventListener('click', checkout, false);
    var searchType = document.getElementById('searchType');

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

        //$.ajax({
        //    url: uri,
        //    method: 'get',
        //    dataType: 'json',
        //    cache: false,
        //    success: function (data) {
        //        console.log(data);
        //    }
        //});

        $.getJSON(uri)
            .done(function (data) {
                $(data).each(function (index, value) {
                    console.log(value.categoryTotalFine);
                    console.log(value.category);
                    $(value.books).each(function (index, value) {
                        console.log("books[" + index + "].title= " + value.title);
                        console.log("\t.author = " + value.author);
                        console.log("\t.isbn = " + value.isbn);
                        if (value.dueDate != null) {
                            
                            var dueDate = new Date(value.dueDate);
                            console.log("\t.dueDate = " + dueDate.toDateString());
                            if (dueDate < new Date(Date.now())) {
                                console.log("\t\tOverdue!!!");
                            }
                            else if (dueDate === new Date(Date.now())) {
                                console.log("\t\tDue today!");

                            }
                            else {
                                console.log("\tNot due...");
                            }
                        }
                        
                    })
                });
            });
    }



    function formatCategory(item) {
        return "Category: " + item.categoryString + "; Total Due For Category: " + item.categoryTotalFine;
    }

    function formatBook(item) {
        return "Title: " + item.title + ";\nAuthor: " + item.author + ";\nISBN: " + item.isbn + ";\nDue Date: " + item.dueDate;
    }

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