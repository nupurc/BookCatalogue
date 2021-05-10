

using BookCatalogue.Model;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogue.Repository
{
    public class BookCatalogueContext : DbContext
    {
        private const string connStr = "name=BookStoreConnectionString";

        public BookCatalogueContext()
           : base()
        {
        }

        public DbSet<BookItemModel> Books { get; set; }
    }
}