using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BookCatalogue.Model;
using BookCatalogue.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookCatalogueApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookCatalogueController : ControllerBase
    {
        private readonly IBookCatalogueItemService _iBookCatalogueItemService;

        private readonly ILogger<BookCatalogueController> _logger;

        public BookCatalogueController(ILogger<BookCatalogueController> logger, IBookCatalogueItemService bookCatalogueItemService)
        {
            _logger = logger;
            _iBookCatalogueItemService = bookCatalogueItemService;
        }

        [HttpPost]
        public void Create(BookItemModel bookItemModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iBookCatalogueItemService.CreateBook(bookItemModel);
                }
            }
            catch (DataException)
            {
                _logger.LogError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            
        }


        [HttpPost]
        public void Edit(BookItemModel book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iBookCatalogueItemService.UpdateBook(book);
                }
            }
            catch (DataException)
            {
                _logger.LogError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
        }        

        [HttpPost, ActionName("Delete")]
        public void DeleteConfirmed(int id)
        {
            try
            {
                _iBookCatalogueItemService.DeleteBook(id);
            }
            catch (DataException)
            {
                _logger.LogError("", "Unable delete. Try again, and if the problem persists see your system administrator.");
            }
            
        }
    }
}
