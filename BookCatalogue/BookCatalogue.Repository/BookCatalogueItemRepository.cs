using BookCatalogue.Model;
using BookCatalogue.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalogue.Repository
{
    public class BookCatalogueItemRepository : IBookCatalogueItemRepository
    {
        private BookCatalogueContext _bookCatalogueContext;
        private bool disposed = false;
        public BookCatalogueItemRepository(BookCatalogueContext bookContext) => _bookCatalogueContext = bookContext;
        public void CreateBook(BookItemModel bookItem)
        {
            _bookCatalogueContext.Books.Add(bookItem); Save();
        }
            

        public void DeleteBook(int bookId)
        {
            BookItemModel book = _bookCatalogueContext.Books.Find(bookId);
            _bookCatalogueContext.Books.Remove(book); Save();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _bookCatalogueContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Save()
        {
            _bookCatalogueContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public List<BookItemModel> GetAllBooks()
        {
            return _bookCatalogueContext.Books.ToList();
        }

        public BookItemModel GetBooksByAuthor(string author)
        {
            return _bookCatalogueContext.Books.Find(author);
        }

        public BookItemModel GetBooksByISBN(string isbn)
        {
            return _bookCatalogueContext.Books.Find(isbn);
        }

        public BookItemModel GetBooksByTitle(string title)
        {
            return _bookCatalogueContext.Books.Find(title);
        }

        public void UpdateBook(BookItemModel bookItem)
        {
            _bookCatalogueContext.Entry(bookItem).State = EntityState.Modified; Save();
        }
    }
}
