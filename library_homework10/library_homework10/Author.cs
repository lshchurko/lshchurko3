using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_homework9
{
    class Author
    {
        public string Name { get;private set; }
        public string Surname { get; private set; }
        public DateOnly Birthdate { get; private set; }

        public Author(string name, string surname, DateOnly birthdate)
        {
            Name = name;
            Surname = surname;
            Birthdate=birthdate;
        }
    }
}
