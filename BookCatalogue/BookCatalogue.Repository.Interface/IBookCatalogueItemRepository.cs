using BookCatalogue.Model;
using System;
using System.Collections.Generic;

namespace BookCatalogue.Repository.Interface
{
    public interface IBookCatalogueItemRepository : IDisposable
    {
        List<BookItemModel> GetAllBooks();
        BookItemModel GetBooksByTitle(string title);
        BookItemModel GetBooksByAuthor(string author);
        BookItemModel GetBooksByISBN(string isbn);
        void CreateBook(BookItemModel bookItem);
        void UpdateBook(BookItemModel bookItem);
        void DeleteBook(int bookId);
    }
}
