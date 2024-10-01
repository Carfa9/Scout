

class Program
{
    public static void Main(string[] args)
    {
        var scoutRepository = new ScoutRepository();


        Scout scout1 = new Scout("Kalle", "kalle@hotmail.com", "070112233", new DateOnly(2014, 12, 13));
        Scout scout2 = new Scout("Bosse", "bosse@hotmail.com", "070112244", new DateOnly(2015, 10, 30));
        Scout scout3 = new Scout("Karin", "karin@hotmail.com", "070223355", new DateOnly(2016, 09, 22));
        Scout scout4 = new Scout("Ida", "ida@hotmail.com", "070221100", new DateOnly(2014, 02, 19));
        Scout scout5 = new Scout("Maryam", "maryam@hotmail.com", "070332211", new DateOnly(2012, 06, 06));
        Scout scout6 = new Scout("Filip", "filip@hotmail.com", "070443322", new DateOnly(2012, 04, 14));

        scoutRepository.AddScout(scout1);
        scoutRepository.AddScout(scout2);
        scoutRepository.AddScout(scout3);
        scoutRepository.AddScout(scout4);
        scoutRepository.AddScout(scout5);
        scoutRepository.AddScout(scout6);


        Activity activity1 = new Activity("Första hjälpen", new DateTime(2024, 03, 02), "Scouthuset", "Bekväma kläder, vi bjuder på fika!");
        Activity activity2 = new Activity("Läger", new DateTime(2024, 07, 25), "Skogen", "Ta med ryggsäck med sovsäck, liggunderlag och nödvändiga saker. Vi tar med maten, anmäl allergi till oss senast 2024-07-01");
        Activity activity3 = new Activity("Eldhantering", new DateTime(2024, 11, 22), "Skogen", "Ta med ombyte och oömma kläder!");


        scoutRepository.AddActivity(activity1);
        scoutRepository.AddActivity(activity2);
        scoutRepository.AddActivity(activity3);

        activity1.AddParticipant(scout1);
        activity1.AddParticipant(scout4);
        activity1.AddParticipant(scout6);

        activity2.AddParticipant(scout1);
        activity2.AddParticipant(scout2);
        activity2.AddParticipant(scout3);
        activity2.AddParticipant(scout4);
        activity2.AddParticipant(scout5);
        activity2.AddParticipant(scout6);

        activity3.AddParticipant(scout2);
        activity3.AddParticipant(scout5);
        activity3.AddParticipant(scout6);

        List<Activity> pastActivities = scoutRepository.GetPastActivities();

        foreach (var activity in pastActivities)
        {
            Console.WriteLine($"{activity.ActivityName} - {activity.Date} - {activity.Location}");
            Console.WriteLine($"Anteckningar: {activity.Notes}");
            Console.WriteLine($"Deltagare: ");

            foreach (var scout in activity.Participants)
            {
                Console.Write($"{scout.Name}, ");
            }
        }
        Console.ReadLine();
    }
}