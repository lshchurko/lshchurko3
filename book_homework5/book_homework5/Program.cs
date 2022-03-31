using book_homework5;

public class Program
{
    static void Main(string[] args)
    {
        Book book1 = new() { Title = "Neznajka", Pages = 167, Indentificator = "123ADF125av4" };
        Book book2 = new() { Title = "Vij", Pages = 58, Indentificator = "dvdffv12ds" };
        Book book3 = new() { Title = "Tom Sojer", Pages = 132, Indentificator = "987654dvd" };
        Book book4 = new() { Title = "Dinka", Pages = 334, Indentificator = "85jfuie45" };
        Book book5 = new() { Title = "ABC", Pages = 88, Indentificator = "09dneuie34" };

        Book[] books = { book1, book2, book3, book4, book5 };

        foreach (Book item in books)
        {
            item.DisplayBook();
        }
    }
}
