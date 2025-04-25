// Concrete Observer
namespace behaviouralDesignPatterns.src.Observer;

public class BarChart : IObserver
{
  private DataSource _dataSource;

  public BarChart(DataSource dataSource)
  {
    _dataSource = dataSource;
  }

  public void Update()
  {
    Console.WriteLine("Rendering Bar Chart with new values");
  }
}