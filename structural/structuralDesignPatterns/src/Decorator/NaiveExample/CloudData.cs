// base class
namespace structuralDesignPatterns.src.Decorator.NaiveExample;

public class CloudData
{
  // protected field to be access by sub classes 
  protected string _url;

  public CloudData(string url)
  {
    _url = url;
  }

  // virtual menthod to allow accessability from sub classes
  public virtual void Save(string data)
  {
    Console.WriteLine($"Saving {data} to cloud at {_url}");
  }
}
