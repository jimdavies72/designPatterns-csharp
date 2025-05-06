using System;

namespace structuralDesignPatterns.src.Decorator;

public class CloudData : IData
{
  // protected field to be access by sub classes 
  private string _url;

  public CloudData(string url)
  {
    _url = url;
  }

  // virtual menthod to allow accessability from sub classes
  public void Save(string data)
  {
    Console.WriteLine($"Saving {data} to cloud at {_url}");
  }
}
