


public class Activity
{
    public string ActivityName { get; set; }
    public DateTime Date { get; set; }
    public string Locations { get; set; }
    public string Notes { get; private set; }
    private List<Scout> Participants { get; } = new List<Scout>();


    public Activity(string activityName, DateTime date, string locations, string notes)
    {
        ActivityName = activityName;
        Date = date;
        Locations = locations;
        Notes = notes;
    }


    public void AddParticipant(Scout participant)
    {
        Participants.Add(participant);
    }

}
