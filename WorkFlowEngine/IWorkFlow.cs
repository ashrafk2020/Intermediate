using System.Collections.Generic;
public interface IWorkFlow
{
   void AddActivities(IExcutable activity);
   IEnumerable<IExcutable> GetActivities();
}