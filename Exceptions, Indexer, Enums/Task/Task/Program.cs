using Task.Exceptions;
try
{
    User user1 = new User("yahya", "yahya.com", "Yahya12312");
    User user2 = new User("yahya", "yahya.com", "Yahya1234234");   
    User user3 = new User("yahya", "yahya.com", "Yahya12312");
    user1.ShowInfo();
    user2.ShowInfo();
    user3.ShowInfo();
}
catch (IncorrectPasswordException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}