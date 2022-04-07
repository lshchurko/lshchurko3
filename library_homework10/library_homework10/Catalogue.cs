using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace library_homework9
{
    class Catalogue
    {
        List<Book> _books;
        public List<Book> Books
            { 
            get 
            { 
                return _books; 
            } 
        }
        public Catalogue()
        {
            _books = new List<Book>();
        }
        public void AuthorsFromCatalogue()
        {
            var results1 = Books.SelectMany(x => x.Authors).Distinct().ToList();
            Console.WriteLine("Authors from Catalogue");
            results1.ForEach(x => Console.WriteLine(x.Name+' '+x.Surname));
        }

        public void SortByTitle()
        {
            var results = Books.OrderBy(x => x.Title).ToList();
            Console.WriteLine("Sort by Book Title");
            results.ForEach(x => Console.WriteLine(x.Title));
        }
        public void BooksByAuthors(string authorsurname, DateOnly publicationyear)
        {
            var results2 = Books.Where(f => f.DateOfPublic >= publicationyear && f.Authors.Exists(q => q.Surname == authorsurname)).ToList();
            Console.WriteLine("Books by Author "+ authorsurname+ " published after "+ publicationyear);
            results2.ForEach(d => Console.WriteLine(d.Title));
        }

        public void SortAuthorsbyBirth()
        {
            var results3 = Books.SelectMany(x => x.Authors).Distinct().OrderBy(x => x.Birthdate).ToList();
            Console.WriteLine("Sort Authors by Birhtdate");
            results3.ForEach(x => Console.WriteLine(x.Name + ' ' + x.Surname+ ' '+x.Birthdate));
        }
    }
    }
