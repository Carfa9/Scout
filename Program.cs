

class Program
{
    public static void Main(string[] args)
    {
        ScoutRepository repo = new ();

        repo.AddScout(new Scout("Emma Karlsson", "ekarlsson@gmail.com", "070111111", new DateOnly(2011,09,16)));
        repo.AddScout(new Scout("Eskil Bosson", "ebosson@gmail.com", "070222222", new DateOnly(2012,03,13)));
        repo.AddScout(new Scout("Ebba Eriksson", "eeriksson@gmail.com", "070333333", new DateOnly(2014,12,24)));
        repo.AddScout(new Scout("Peter Rosman", "prosman@gmail.com", "070444444", new DateOnly(2013,01,15)));
        repo.AddScout(new Scout("Henrik Robinsson", "hrobinsson@gmail.com", "070555555", new DateOnly(2012,07,18)));

        

        repo.AddActivities(new Activity("Läger", new DateTime(), "Mulleskogen"));
        
        
        repo.RegisterParticipantToActivity(3, 0);

        Activity theActivity = repo.GetActivityById(0);
        Console.WriteLine(theActivity.Info);
    }
     
}