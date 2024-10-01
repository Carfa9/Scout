

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
        List<Activity> comingActivities = [];           //Ny lista som samlar kommande aktiviteter.
        foreach(var activity in Activities)
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
         List<Activity> pastActivities = [];        //Ny lista som samlar gamla aktiviteter.

            foreach(var activity in Activities)
            {
             if (activity.Date < DateTime.Today)
                {
                pastActivities.Add(activity); 
                }  
            }
            return pastActivities;
        }

    public void GetReminder(Activity activity)
    {

    }
}
