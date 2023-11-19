using Task.Interfaaces;
using Utils.Exceptions;

namespace Task;

internal class Library : IEntity
{
    public int BookLimit { get; set; } = 5;
    private Book[] books = new Book[0];
    private static int id = 1;
    public int Id => id;
    public Library()
    {
        id++;        
    }
    public void AddBook(Book book)
    {
        bool isSameName = false;      
        if (books.Length > BookLimit)
        {
            throw new CapacityLimitException("CapacityLimit");
        }
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i].IsDeleted)
            {
                return;
            }
            if (books[i].Name == book.Name)
            {
                throw new AlreadyExistsException("AlreadyExists");
            }
        }
        if (!isSameName)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            return;
        }

    }
    public Book GetBookById(int id)
    {
        for (int i = 0;i < books.Length;i++)
        {           
            if (books[i].Id == id && books[i].IsDeleted == false)
            {
                return books[i];
            }
        }

        throw new NotFoundException("NotFound");
    }

}
