

public class ScoutRepository
{
    private List<Scout> Scouts = [];
    private List<Activity> Activities = [];

    
    public void AddScout(Scout scout)
    {
        Scouts.Add(scout);
    }

    public void AddActivities(Activity activity)
    {
        Activities.Add(activity);
    }

    public List<Activity> GetComingActivities()
    {
        List<Activity> comingActivities = [];
        foreach (var activity in Activities)
        {
            if (activity.Date >= DateTime.Now)
            {
              comingActivities.Add(activity);  
            }
        }
        return comingActivities;
    }

    public List<Activity> GetPastActivities()
    {
        List<Activity> pastActivities = [];
        foreach (var activity in Activities)
        {
            if (activity.Date < DateTime.Now)
            {
                pastActivities.Add(activity);
            }
        }
        return pastActivities;
    }  

    public void SendReminder( Activity activity)
    {

    }  
   
}
