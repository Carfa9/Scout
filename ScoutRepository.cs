

public class ScoutRepository
{
    private List<Scout> _scouts = [];
    private List<Activity> _activities = [];

    
    public void AddScout(Scout scout)
    {
        _scouts.Add(scout);
    }

    public void AddActivities(Activity activity)
    {
        _activities.Add(activity);
    }

    public List<Activity> GetComingActivities()
    {
        List<Activity> comingActivities = [];
        foreach (var activity in _activities)
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
        foreach (var activity in _activities)
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
