namespace Api.Models;

public class UserEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsVerified { get; set; }

    public UserEntity(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }
}
