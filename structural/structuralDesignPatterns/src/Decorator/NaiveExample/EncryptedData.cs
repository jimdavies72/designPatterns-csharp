namespace structuralDesignPatterns.src.Decorator.NaiveExample;

public class EncryptedData : CloudData
{
  public EncryptedData(string url) : base(url)
  {
  }

  public override void Save(string data)
  {
    var encrypted = Encrypt(data);
    base.Save(encrypted);
  }

  public string Encrypt(string data)
  {
    // simulating encryption.....
    return "skjewe&6med!eknd&en0934";
  }
}
