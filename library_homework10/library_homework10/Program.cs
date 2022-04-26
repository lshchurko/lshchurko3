using System.Linq;
using System.Collections.Generic;
namespace library_homework9
{
    class Program
    {
        static void Main(string[] vs)
        {
            var catalogue1 = new Catalogue();
            var author1 = new Author("Aname", "Asurname",new (1900,01,12));
            var author2 = new Author("Bname", "Bsurname",new (1564,10,10));
            var author3 = new Author("Sname", "Ssurname",new(2000,01,01));
            var author4 = new Author("Rname", "Rsurname",new(1976,3,15));
            var author5 = new Author("Fname", "Fsurname",new(1986,5,25));
            var author6 = new Author("Ename", "Esurname",new(1965,1,5));
            var author7 = new Author("Kname", "Ksurname",new(1675,11,30));
            var author8 = new Author("Nobooks", "Nsurma",new(2010,6,7));
            var authorsList1 = new List<Author>() { author1, author2 };
            var authorsList2 = new List<Author>() { author3 };
            var authorsList3 = new List<Author>() { author4, author7 };
            var authorsList4 = new List<Author>() { author5, author6 };
            var authorsList5 = new List<Author>() { author2, author3 , author4 };
            var authorsList6 = new List<Author>() { author7 };
            catalogue1.Books.Add(new Book("Book1", new(2000,10,27), "abc123", authorsList1));
            catalogue1.Books.Add(new Book("Book2", new(2001,3,14), "dfe123", authorsList2));
            catalogue1.Books.Add(new Book("Book3", new(1987,3,19), "sdf34", authorsList3));
            catalogue1.Books.Add(new Book("Book4", new(1987,8,14), "srt54", authorsList4));
            catalogue1.Books.Add(new Book("Book5", new(2001,4,12), "qwe32", authorsList5));
            catalogue1.Books.Add(new Book("Book6", new(987,1,5), "ert43", authorsList6));
            catalogue1.Books.Add(new Book("Book7", new(2019,12,12), "qwe35", authorsList2));
            catalogue1.SortByTitle();
            catalogue1.AuthorsFromCatalogue();
            catalogue1.BooksByAuthors("Ksurname", new(1980,1,1));
            catalogue1.SortAuthorsbyBirth();
        }
    }
}
