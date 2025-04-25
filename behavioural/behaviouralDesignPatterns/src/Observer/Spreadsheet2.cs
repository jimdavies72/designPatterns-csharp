//Concrete Observer

namespace behaviouralDesignPatterns.src.Observer;

public class Spreadsheet2 : IObserver
{
  private int _total;
  private DataSource _dataSource;

  public Spreadsheet2(DataSource dataSource)
  {
    _dataSource = dataSource;
  }

  public void Update()
  {
    _total = CalculateTotal(_dataSource.GetValues());
  }

  public int GetTotal()
  {
    return _total;
  }


  public int CalculateTotal(List<int> values)
  {
    var sum = 0;
    foreach (var value in values)
    {
      sum += value;
    }
    
    Console.WriteLine("Total: {0}", sum);
    return sum;
  }

}