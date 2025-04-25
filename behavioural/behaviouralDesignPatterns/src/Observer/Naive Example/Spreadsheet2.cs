namespace behaviouralDesignPatterns.src.Observer.NaiveExample;

public class Spreadsheet2
{
  private int _total;

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