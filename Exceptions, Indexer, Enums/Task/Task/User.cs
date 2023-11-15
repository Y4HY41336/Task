using Task;
using Task.Exceptions;

public class User : Account
{
    private static int _id;
    public int Id {get;}
    public string Fullname { get; set; }
    public string Email { get; set; }
    private string password;
    public string Password
    {
        get => password;
        set
        {
            if (Passwordchecker(value))
            {
                password = value;
            }
            else
            {
                throw new IncorrectPasswordException("Wrong password");
            }
        }
    }
    public User(string email, string password)
    {
        Id = ++_id;       
        Email = email;
        Password = password;
    }
    public User(string fullname, string email, string password)
    {
        Id = ++_id;
        Fullname = fullname;
        Email = email;
        Password = password;
    }
    public override bool Passwordchecker(string password)
    {
        bool isUpper = false;
        bool isLower = false;
        bool isDigit = false;
        if (password.Length < 8)
        {
            return false;
        }


        for (int i = 0; i < password.Length; i++)
        {
            if (Char.IsUpper(password[i])) { isUpper = true; }
            if (Char.IsLower(password[i])) { isLower = true; }
            if (Char.IsDigit(password[i])) { isDigit = true; }
            if (isUpper && isLower && isDigit)
            {
                return true;
            }
            
        }
        return false;
    }
  public override void ShowInfo()
  {
    Console.WriteLine($"Id:{Id} - Fullname:{Fullname} - Email:{Email}");
  }
}