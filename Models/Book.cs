using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _PublicationYear;

        public string Title 
        { 
            get => _Title;
            set => _Title = value; 
        }

        public string Author 
        { 
            get => _Author;
            set => _Author = value;
        }

        public int PublicationYear 
        {
            get => _PublicationYear;
            set => _PublicationYear = value;
        }

        public Book(string title, string author, int publicationYear) {
            if (title != null) _Title = title;
            if (author != null) _Author = author;
            if (publicationYear > 0) _PublicationYear = publicationYear;
        }
    }
}