using behaviouralDesignPatterns.src.Observer.NaiveExample;

namespace behaviouralDesignPatterns.src.Observer.NaiveExample;

public class DataSource
{
  private List<int> _values = new List<int>();
  private List<object> _dependents = new List<object>();

  public List<int> GetValues()
  {
    return _values;
  }

  public void SetValues(List<int> values)
  {
    _values = values;

    foreach (var dependent in _dependents)
    {
      if (dependent is Spreadsheet2)
      {
        (dependent as Spreadsheet2)?.CalculateTotal(_values);
      }
      else if (dependent is BarChart)
      {
        (dependent as BarChart)?.Render(_values);
      }
    
    }
  }

  public void AddDependent(Object dependent)
  {
    _dependents.Add(dependent);
  }

  public void RemoveDepenent(Object dependent)
  {
    _dependents.Remove(dependent);
  }
}