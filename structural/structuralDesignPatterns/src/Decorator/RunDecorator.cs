
namespace structuralDesignPatterns.src.Decorator;

public class RunDecorator
{
  public static void RunDecoratorPattern()
  {
    // simulate user input data
    var url = "https://google.cloud.com";
    var data = "This is my data that I will save to the cloud!";
    var compress = true;
    var encrypt = true;

    IData cloudData = new CloudData(url);
    if (encrypt)
    {
      cloudData = new EncryptionDecorator(cloudData);
    }
    if (compress)
    {
      cloudData = new CompressionDecorator(cloudData);
    }

    cloudData.Save(data);
  }
}
