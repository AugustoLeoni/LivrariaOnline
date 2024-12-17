using LivrariaOnline.Entities;

namespace LivrariaOnline.DataBase;

public static class DataBaseBook
{
    private static List<Book> Books {  get; set; } = new List<Book>();

    private static int LastId = 0;

    public static void AddBook(Book book)
    {
        LastId++;
        var newBook = new Book()
        {
            Id   = LastId,
            Title = book.Title,
            Author = book.Author,
            Gender = book.Gender,
            Price = book.Price,
            QtdStock = book.QtdStock
        };

        Books.Add(newBook);
    }

    public static List<Book> GetAllBooks()
    {
        return Books;
    }

    public static void Update(int id, Book infoBookUpdate)
    {
        int index = Books.FindIndex(book => book.Id == id);

        Books[index] = new Book
        {
            Id = id,
            Title = infoBookUpdate.Title,
            Author = infoBookUpdate.Author,
            Gender = infoBookUpdate.Gender,
            Price = infoBookUpdate.Price,
            QtdStock = infoBookUpdate.QtdStock
        };
    }

    public static void Delete(int id)
    {
        int index = Books.FindIndex(Book => Book.Id == id);

        Books.RemoveAt(index);
    }

}
