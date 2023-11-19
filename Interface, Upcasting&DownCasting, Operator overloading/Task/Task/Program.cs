using Task;
using Utils.Exceptions;

Book book1 = new Book("kitab1","yahya",200);
Book book2 = new Book("kitab2","yahya",300);
Book book3 = new Book("kitab3","yahya",400);
Book book4 = new Book("kitab4","yahya",500);
Library library = new Library();
//Console.WriteLine(book1 > book2);
try
{
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);
    //library.AddBook(book4);
    int i = int.Parse(Console.ReadLine());
    Console.WriteLine(library.GetBookById(i).ShowInfo());  
}
catch (CapacityLimitException ex)
{
    Console.WriteLine(ex.Message);
}
catch (AlreadyExistsException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

