


public class Activity
{
    public string ActivityName { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public string Notes { get; private set; }
    public List<Scout> Participants { get; } = new List<Scout>();


    public Activity(string activityName, DateTime date, string location, string notes)
    {
        ActivityName = activityName;
        Date = date;
        Location = location;
        Notes = notes;
    }


    public void AddParticipant(Scout participant)
    {
        Participants.Add(participant);
    }

}
