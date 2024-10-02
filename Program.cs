

class Program
{
    public static void Main(string[] args)
    {
        var scoutRepository = new ScoutRepository();

        Scout scout1 = new Scout("Emma Karlsson", "ekarlsson@gmail.com", "070111111", new DateOnly(2011,09,16));
        Scout scout2 = new Scout("Eskil Bosson", "ebosson@gmail.com", "070222222", new DateOnly(2012,03,13));
        Scout scout3 = new Scout("Ebba Eriksson", "eeriksson@gmail.com", "070333333", new DateOnly(2014,12,24));
        Scout scout4 = new Scout("Peter Rosman", "prosman@gmail.com", "070444444", new DateOnly(2013,01,15));
        Scout scout5 = new Scout("Henrik Robinsson", "hrobinsson@gmail.com", "070555555", new DateOnly(2012,07,18));

        scoutRepository.AddScout(scout1);
        scoutRepository.AddScout(scout2);
        scoutRepository.AddScout(scout3);
        scoutRepository.AddScout(scout4);
        scoutRepository.AddScout(scout5);

        Activity activity1 = new Activity("Läger", new DateTime(2024,06,15), "Mulleskogen", "");
        Activity activity2 = new Activity("Eldövning", new DateTime(2024,08,20), "Mulleskogen", "");
        Activity activity3 = new Activity("Första hjälpen", new DateTime(2024,10,02), "Scouthuset", "");
        Activity activity4 = new Activity("Bygga koja", new DateTime(2024,10,15), "Mulleskogen", "");

        scoutRepository.AddActivities(activity1);
        scoutRepository.AddActivities(activity2);
        scoutRepository.AddActivities(activity3);
        scoutRepository.AddActivities(activity4);
        
        
        activity1.AddParticipant(scout1);
        activity1.AddParticipant(scout2);
        activity1.AddParticipant(scout3);
        activity1.AddParticipant(scout4);
        activity1.AddParticipant(scout5);

        activity2.AddParticipant(scout1);
        activity2.AddParticipant(scout3);
        activity2.AddParticipant(scout5);

        activity3.AddParticipant(scout1);
        activity3.AddParticipant(scout2);
        activity3.AddParticipant(scout3);
        activity3.AddParticipant(scout4);
        activity3.AddParticipant(scout5);

        activity4.AddParticipant(scout2);

    }
     
}