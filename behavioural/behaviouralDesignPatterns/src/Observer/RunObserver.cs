namespace behaviouralDesignPatterns.src.Observer;

public class RunObserver
{
  public static void RunObserverPattern()
  {
    

    // Naive example
    // DataSource dataSource= new DataSource();
    // Spreadsheet2 sheet2 = new Spreadsheet2();
    // BarChart barChart= new BarChart();

    // dataSource.AddDependent(sheet2);
    // dataSource.AddDependent(barChart);
    
    // dataSource.SetValues([5, 5, 1, 10]);
    // dataSource.SetValues([1, 2, 3]);

    DataSource dataSource = new DataSource();
    Spreadsheet2 sheet2 = new Spreadsheet2(dataSource);
    BarChart barChart = new BarChart(dataSource);

    dataSource.AddObserver(sheet2);
    dataSource.AddObserver(barChart);

    dataSource.SetValues([5, 5, 1, 10]);
    dataSource.SetValues([3, 3, 3]);

  }
}