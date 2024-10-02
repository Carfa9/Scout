
public class Scout
{
    public string Name {get; set;}
    public string Email {get; set;}
    public string Phone {get; set;}
    public DateOnly BirthDate {get; set;}

    public Scout (string name, string email, string phone, DateOnly birthDate)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Måste vara namn och email!");
        }
            Name = name;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
    }

}
