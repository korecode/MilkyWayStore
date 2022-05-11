using MilkyWayStore.Data.Models;
using System.Collections.Generic;

namespace MilkyWayStore.Data.Interfaces
{
    public interface IAllBooks
    {

        IEnumerable<Book> Books { get; }
        IEnumerable<Book> getFavBooks { get;}

        Book getObjectBook (int bookId);
    }
}
