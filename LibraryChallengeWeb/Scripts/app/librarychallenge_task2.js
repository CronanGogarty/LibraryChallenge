$(document).ready(function () {

    $('#btnShowAll').on('click', showAll);
    $('#selCategory').on('click', selCategory);
    $('#btnSortBooks').click(sortBooks);
    $('#btnCheckout').on('click', checkout);
    var searchType = $('#searchType');

    //toggle display of books
    function close_accordion_section() {
        $('.accordion .accordion-section-title').removeClass('active');
        $('.accordion .accordion-section-content').slideUp(300).removeClass('open');
    }

    function showAll() {
        var uri = 'api/library/books';
        searchType.textContent = "Show All Books"
        $('#library-challenge-results').empty();
        $.getJSON(uri)
            .done(function (data) {
                $.each(data, function (key, item) {
                    /*
                     * for each book object within the json payload...
                     * create a new div in jquery that contains the data for that book, then append that div to the container div
                     */
                    $('#library-challenge-results').append('<div class="bookDiv"><h3>Title:&nbsp;' + item.title + '</h3><div><strong>Author:</strong>&nbsp;' + item.author + '<div><div><strong>ISBN:</strong>&nbsp;' + item.isbn + '</div><div><strong>Category:</strong>&nbsp;' + item.category + '</div><div><strong>Published Date:</strong>&nbsp;' + item.publishedDate + '</div><div><strong>On Loan To:</strong>&nbsp;' + item.lentToCustomerId + '</div><div><strong>Due Date:</strong>&nbsp;' + item.dueDate + '</div><div><strong>Book GUID:</strong>&nbsp;' + item.bookId + '</div></div>');
                });
            });
    }

    function showByCategory() {

        var e = document.getElementById('selCategory');
        if (e.selectedIndex != 0) {

            /*
             * determine the selected category
             * create the uri and the output message
             * clear the existing contents of the container div
             */
            var selectedCategory = e.options[e.selectedIndex].text;
            var uri = 'api/library/books/' + selectedCategory;
            searchType.textContent = "Show All " + selectedCategory + " Books";
            $('#library-challenge-results').empty();

            /*
             * execute the REST request and execute a callback function passing it the json response
             */
            $.getJSON(uri)
                .done(function (data) {
                    $.each(data, function (key, item) {
                        /*
                         * for each book object in the json payload..
                         * create a div that displays the data for that book item
                         */
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
                    /*
                     * for each category object contained in the JSON payload
                     *      1)create a category-container div with id="div"+Category
                     *      2)add classes to category-container
                     *      3)append div to library-challenge-results div
                     *      4)count the number of books in the category      
                     *      5)add accordion class to container div              
                     */
                    
                    
                    var bookCount = $(catValue.books).toArray().length;
                    var currentCategoryContainer = $('<div>').addClass('divCategoryContainer accordion-section')
                        .attr("id", function () {
                            return "div" + catValue.category;
                        })
                        .appendTo($('#library-challenge-results').addClass('accordion'));

                    //add a div wrapper to group the category header info and the array of books contained within
                    var detailsWrapper = $('<div>').appendTo(currentCategoryContainer);

                    //create the category header displaying category name, total fines owing for that category and count of books in category
                    //add href attribute to the div and add an anonymous function to the click event
                    var currentSummary = $("<div><h2>" + catValue.category + "</h2><h3>Total Owed in Category: $" + catValue.categoryTotalFine + "</h3><h4>Total Books: " + bookCount + "</h4></a></div>").attr('href', '#accordion-'+ catValue.category).on('click', function (e) {

                        //toggle view of books in category
                        var currentAttrValue = $(this).attr('href');
                        var targetDiv = $(this);

                        if ($(targetDiv).is('.active')) {
                            close_accordion_section();
                        } else {

                            // Add active class to section title
                            $(this).addClass('active');
                            // Open up the hidden content panel
                            $('.accordion ' + currentAttrValue).slideDown(300).addClass('open');
                        }
                        e.preventDefault();
                    })
                        //add class to the category header div and append to the wrapper grouping the category contents
                        .addClass('accordion-section-title')
                        .appendTo(detailsWrapper);

                    //create a div to wrap the books
                    var bookPara = $('<div>').addClass('accordion-section-content ').attr('id', 'accordion-' + catValue.category).appendTo(detailsWrapper);
                    
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
                        //append this div to books wrapper 
                        var currentBook = $('<div>').addClass('divBookItem')
                            .html("<ul><li>Title: " + bookValue.title + "</li><li>Author: " + bookValue.author + "</li><li>ISBN: " + bookValue.isbn + "</li><li>Due Date: " + currentDueDate + "</li></ul>")
                            .attr("id", function () {
                                //setting a unique id for each book based on isbn
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