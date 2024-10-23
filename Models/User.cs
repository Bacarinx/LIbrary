using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class User
    {
        public User(string nome, string id) {
            _Nome = nome;
            _ID = id;
        }

        private string _Nome;
        private string _ID;
        private List<string> BorowBooks = new List<string>();

        public string Nome {
            get => _Nome;
            set => _Nome = value;
        }

        public string ID {
            get => _ID;
            set => _ID = value;
        }

        public string BorrowBooks {
            get => BorrowBooks;
        }

        public void AddBorowBoook(Book book)
        {
            if (BorowBooks.Count() > 2)
            {
                BorowBooks.Add(book.Title);
            }
            else
            {
                Console.WriteLine("Leitor alcançou o número máxima de 3 livros emprestados, devolva um para poder emprestar outro.");
            }
        }

        public void ReturnBook(Book book) {
            if(BorowBooks.Contains(book.Title)){
                BorowBooks.Remove(book.Title);
                Console.WriteLine("Livro devolvido com sucesso!");
            } else {
                Console.WriteLine("Esse livro não está com você.");
            }
        
        }

        // public bool UserCanGetBook() {

        // }
    }
}