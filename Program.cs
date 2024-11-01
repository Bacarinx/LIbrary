using Biblioteca.Models;

Book b1 = new Book("Pássaro de Fogo", "Henrique Bacarin", 2019);
Book b2 = new Book("Harry Potter", "Thayna Araújo", 2005);
Book b3 = new Book("Codigo DaVinci", "Tiago Almeida", 2009);
Book b4 = new Book("Assim que acaba", "Beatriz Mendes", 1998);

User u1 = new User("Henrique Bacarin", "0030482413007");
User u2 = new User("Pedro de Almeida", "0030482413089");
User u3 = new User("Raquel Litoldo", "0030482413045");
User u4 = new User("Igor Zucolloto", "0030482413012");

u1.AddBorowBoook(b1);
u1.AddBorowBoook(b2);
u1.AddBorowBoook(b3);
u1.AddBorowBoook(b4);

foreach(string book in u1.BorrowBooks) {
  Console.WriteLine(book);
}
