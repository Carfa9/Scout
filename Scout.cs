
public class Scout
    {
        public string Name{get; private set;}
        public string Email{get; private set;}
        public string Phone{get; private set;}
        public DateOnly BirthDate{get; private set;}

        public Scout(string name, string email, string phone,DateOnly birthDate)
        {
            Name = name;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
        }

    }
