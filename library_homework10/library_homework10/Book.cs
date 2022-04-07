using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_homework9
{
    class Book
    {
        public string Title { get; private set; }
        public DateOnly DateOfPublic { get; private set; }
        public string IndId { get; private set; }
        List<Author> _authors;
        public List<Author> Authors
        {
            get { return _authors; }
        }
        public Book(string title, DateOnly dateOfPublic,string indId, List<Author> authors)
        {
            Title = title;
            DateOfPublic = dateOfPublic;
            IndId = indId;
            _authors = authors;
        }
    }
}

