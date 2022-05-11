using MilkyWayStore.Data.Interfaces;
using MilkyWayStore.Data.Models;
using System.Collections.Generic;

namespace MilkyWayStore.Data.Repository
{
    public class CategoryRepository : IBooksCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
