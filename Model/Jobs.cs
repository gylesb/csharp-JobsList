using System.Collections.Generic;

namespace JobsList.Models
{
  public class Job
  {
    private string _title;
    private string _description;
    private string _dates;

    private static List<string> _instances = new List<string> {};

    //this is the constructor
    public Job (string title, string description, string dates)
    {
      _title = title;
      _description = description;
      _dates = dates;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public string GetDates()
    {
      return _dates;
    }
    public void SetDates(string newDates)
    {
      _dates = newDates;
    }

    public static List<string> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add((_title + " " + _description + " " + _dates));
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
