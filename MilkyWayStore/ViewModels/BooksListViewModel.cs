﻿using MilkyWayStore.Data.Models;
using System.Collections.Generic;

namespace MilkyWayStore.ViewModels
{
    public class BooksListViewModel
    {

        public IEnumerable<Book> allBooks { get; set;  }

        public string currCategory { get; set; }
    }
}
