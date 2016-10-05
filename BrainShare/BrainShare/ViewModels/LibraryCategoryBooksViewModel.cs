﻿using System.Collections.Generic;
using BrainShare.Models;

namespace BrainShare.ViewModels
{
    class LibraryCategoryBooksViewModel
    {
        private List<BookModel> _books;
        public List<BookModel> BookList
        {
            get { return _books; }           
            set { _books = value; }
        }
        private string _categoryname;
        public string CategoryName
        {
            get
            {
                return _categoryname;
            }
            set
            {
                _categoryname = value;
            }
        }
        public LibraryCategoryBooksViewModel(LibCategoryModel category)
        {
            BookList = category.category_books;
            CategoryName = category.category_name;
        }
    }
}
