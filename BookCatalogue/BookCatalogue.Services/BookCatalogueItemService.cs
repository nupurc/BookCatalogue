using BookCatalogue.Model;
using BookCatalogue.Repository.Interface;
using BookCatalogue.Services.Interface;
using System;
using System.Collections.Generic;

namespace BookCatalogue.Services
{
    public class BookCatalogueItemService : IBookCatalogueItemService
    {
        private IBookCatalogueItemRepository _iBookCatalogueItemRepository;
        public BookCatalogueItemService(IBookCatalogueItemRepository ibookCatalogueItemReporsitory)
        {
            _iBookCatalogueItemRepository = ibookCatalogueItemReporsitory;
        }
        public void CreateBook(BookItemModel bookItem)
        {
            _iBookCatalogueItemRepository.CreateBook(bookItem);
        }

        public void DeleteBook(int bookId)
        {
            _iBookCatalogueItemRepository.DeleteBook(bookId);
        }

        public List<BookItemModel> GetAllBooks()
        {
            return _iBookCatalogueItemRepository.GetAllBooks();
        }

        public BookItemModel GetBooksByAuthor(string author)
        {
            return _iBookCatalogueItemRepository.GetBooksByAuthor(author);
        }

        public BookItemModel GetBooksByISBN(string isbn)
        {
            return _iBookCatalogueItemRepository.GetBooksByISBN(isbn);
        }

        public BookItemModel GetBooksByTitle(string title)
        {
            return _iBookCatalogueItemRepository.GetBooksByTitle(title);
        }

        public void UpdateBook(BookItemModel bookItem)
        {
            _iBookCatalogueItemRepository.UpdateBook(bookItem);
        }
    }
}
