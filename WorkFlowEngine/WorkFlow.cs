using System.Collections.Generic;
using System.Collections;
class WorkFlow:IWorkFlow
{
    private readonly List<IExcutable> activityList ;
    
    public WorkFlow()
    {
        activityList = new List<IExcutable>();
        
    }

    public void AddActivities(IExcutable activity)
    {
        activityList.Add(activity);
    }

   
    public IEnumerable<IExcutable> GetActivities()
    {
        return activityList;
    }
}