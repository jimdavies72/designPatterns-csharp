namespace structuralDesignPatterns.src.Decorator.NaiveExample;

public class CompressedData : CloudData
{
  public CompressedData(string url) : base(url)
  {
  }

  public override void Save(string data)
  {
    var compressed = Compress(data);
    base.Save(compressed);
  }

  public string Compress(string data)
  {
    // simulating compression....
    return data.Substring(0, data.Length - 5);
  }
}
