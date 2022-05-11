using MilkyWayStore.Data.Interfaces;
using MilkyWayStore.Data.Models;
using System.Collections.Generic;

namespace MilkyWayStore.Data.Mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Художественная", desc = "Описание"},
                    new Category { categoryName = "Нехудожественная", desc = "Описание"},
                    new Category { categoryName = "Новеллы", desc = "Описание"}
                };
            }
        }
    }
}
