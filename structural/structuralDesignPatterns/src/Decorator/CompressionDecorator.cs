using System;

namespace structuralDesignPatterns.src.Decorator;

public class CompressionDecorator : DataDecorator
{
  public CompressionDecorator(IData data) : base(data)
  {
  }

  public override void Save(string data)
  {
    Console.WriteLine("Compressing data");
    var compressed = Compress(data);
    base._data.Save(compressed);
  }

  public string Compress(string data)
  {
    // simulating compression....
    return data.Substring(0, data.Length - 5);
  }
}
