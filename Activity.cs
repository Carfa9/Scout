


public class Activity
{
public string ActivityName {get; set;}
public DateTime Date;
public string Locations;
private List<Scout>Participants{get; } = new List<Scout>();
private string Notes;

public Activity(string activityName)
{
    ActivityName = activityName;
}


public void AddParticipant(Scout scout)
{

    Participants.Add(scout);

}

}
