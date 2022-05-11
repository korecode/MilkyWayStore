using System.Collections.Generic;

namespace MilkyWayStore.Data.Models
{
    public class Category
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string desc { get; set; }

        public List<Book> books { get; set; }

    }
}
