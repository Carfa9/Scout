


using System.Dynamic;

public class Activity
{
    public string ActivityName {get; set;}
    public DateTime Date {get; set;}
    public string Location {get; set;}
    public List<Scout> Participants {get;}= new List<Scout>();
    public string Note {get; set;}
    
    public Activity(string activityName, DateTime date, string location, string note)
    {
        ActivityName = activityName;
        Date = date;
        Location = location;
        Note = note;
    }
    
    public void AddParticipant(Scout participant)
    {
        Participants.Add(participant);
    }
}
