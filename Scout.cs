
public class Scout
{
    public string Name {get; set;}
    public string Email {get; set;}
    public string Phone {get; set;}
    public DateOnly BirthDate {get; set;}

    public Scout (string name, string email, string phone, DateOnly birthDate)
    {
            Name = name;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
    }

}
