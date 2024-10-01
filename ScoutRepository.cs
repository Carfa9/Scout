

public class ScoutRepository
{
    private List<Scout> Scouts { get; } = new List<Scout>();
    public List<Activity> Activities { get; } = new List<Activity>();

    public void AddScout(Scout scouts)
    {
        Scouts.Add(scouts);
    }

    public void AddActivity(Activity activity)
    {
        Activities.Add(activity);
    }

    public List<Activity> GetComingActivities()
    {
        foreach(var activity in Activities)
        {
            if (activity.Date > DateTime.Now)
            {
               return ; 
            }
        }
         
    }

    public List<Activity> GetPastActivities()
    {
        foreach(Activity activity in Activities)
        {
            if (activity.Date < DateTime.Today)
            {
            return Console.WriteLine(activity.ActivityName, activity.Date, activity.Locations. activity.Notes); 
            }
            
    }
    }

    public void GetReminder(Activity activity)
    {

    }
}
