using System;

namespace structuralDesignPatterns.src.Decorator;

public class EncryptionDecorator : DataDecorator
{
  public EncryptionDecorator(IData data) : base(data)
  {
  }

  public override void Save(string data)
  {
    var encrypted = Encrypt(data);
    base._data.Save(encrypted);
  }

  public string Encrypt(string data)
  {
    // simulating encryption.....
    return "skjewe&6med!eknd&en0934";
  }
}
