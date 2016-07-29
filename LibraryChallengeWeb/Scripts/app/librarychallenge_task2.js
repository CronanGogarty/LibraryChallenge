$(document).ready(function () {
    //alert('library challenge task 2 ready');

    document.getElementById('btnShowAll').addEventListener('click', showAll, false);
    document.getElementById('selCategory').addEventListener('change', showByCategory, false);
    document.getElementById('btnSortBooks').addEventListener('click', sortBooks, false);
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
        var uri = 'api/library/books/sort';
        searchType.textContent = "Sort Books"
        $('#library-challenge-results').empty();
        $.getJSON(uri)
            .done(function (data) {
                $.each(data, function (key, item) {
                    $('<div>', { text: formatCategory(item) }).appendTo('#library-challenge-results').addClass("categoryContainer");

                });
            });
    }

    function formatCategory(item) {
        return "Category: " + item.categoryString;
    }

    function formatBook(item) {
        return "title: " + item.title + "; " + item.author + "; " + item.isbn + "; " + item.dueDate;
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