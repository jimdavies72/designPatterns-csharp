// Concrete Subject
// Manages only the values and not the observers
namespace behaviouralDesignPatterns.src.Observer;

public class DataSource : Subject
{
  private List<int> _values = new List<int>();

  public List<int> GetValues()
  {
    return _values;
  }

  public void SetValues(List<int> values)
  {
    _values = values;

    NotifyObservers();
  }
}