using Task.Interfaaces;

namespace Task;

internal class Book : IEntity
{   
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public bool IsDeleted { get; set; } = false;
    private static int _id;
    private int id;
    public int Id {  get; }
     

    public Book(string name, string authorName, int pageCount)
    {
        id = ++_id;
        Id = id;
        Name = name;
        AuthorName = authorName;
        PageCount = pageCount;
    }
    public string ShowInfo()
    {
        return $"Id:{Id} - Name:{Name} - AuthorName:{AuthorName} - PageCount:{PageCount} ";
    }
    public static bool operator <(Book book1, Book book2)
    {
        return book1.PageCount < book2.PageCount;
    }
    public static bool operator >(Book book1, Book book2)
    {
        return book1.PageCount > book2.PageCount;
    }

}   
