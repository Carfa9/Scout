


public class Activity
{
    public string ActivityName {get; set;}
    public DateTime Date {get; set;}
    public string Location {get; set;}
    public List<Scout> Participants {get;}= new List<Scout>();
    public string Note {get; set;}

    public string Info
    {
        get
        {
            return "Aktivitet: " + ActivityName + "Datum: " + Date.ToShortDateString();
        
        }
    }
    
    public Activity(string activityName, DateTime date, string location)
    {
        ActivityName = activityName;
        Date = date;
        Location = location;
    }
    
    public void AddParticipant(Scout participant)
    {
        Participants.Add(participant);
    }
}
