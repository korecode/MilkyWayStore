using Microsoft.AspNetCore.Mvc;
using MilkyWayStore.Data.Interfaces;
using MilkyWayStore.ViewModels;

namespace MilkyWayStore.Controllers
{
    public class BooksController : Controller
    {

        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Все книги";
            BooksListViewModel obj = new BooksListViewModel();
            obj.allBooks = _allBooks.Books;
            obj.currCategory = "Книги";
            return View(obj);
        }
    }
}
