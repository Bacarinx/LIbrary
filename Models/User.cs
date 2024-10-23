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
        private int BorowBooks;

        public string Nome{
            get => _Nome;
            set => _Nome = value;
        }

        public string ID {
            get => _ID;
            set => _ID = value;
        }

        public string BorrowBooks{
            get => BorrowBooks;
        }

        // public bool UserCanGetBook() {

        // }
    }
}