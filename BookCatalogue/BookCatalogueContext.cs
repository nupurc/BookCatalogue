using System.Data.Entity;
using BookCatalogue.Model;

namespace BookCatalogue.Repository
{
    public class BookCatalogueContext : DbContext
    {
        public BookCatalogueContext()
            : base("name=BookStoreConnectionString")
        {
        }

        public DbSet<BookItemModel> BookItemModels { get; set; }
    }
}