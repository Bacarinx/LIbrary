using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Book
    {
        private string Title;
        private string Author;
        private string PublicationYear;

        public Book(string title, string author, string publicationYear) {
            if (title != null) Title => title;
            if (author != null) Author => Author;
            if (publicationYear != null) PublicationYear => PublicationYear;
        }
    }
}