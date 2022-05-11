using MilkyWayStore.Data.Models;
using System.Collections.Generic;

namespace MilkyWayStore.Data.Interfaces
{
    public interface IBooksCategory
    {

        IEnumerable<Category> AllCategories { get; }
    }
}
