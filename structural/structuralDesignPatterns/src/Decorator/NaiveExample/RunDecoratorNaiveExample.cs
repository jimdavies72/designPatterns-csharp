namespace structuralDesignPatterns.src.Decorator.NaiveExample;

public class RunDecoratorNaiveExample
{
  public static void RunDecoratorNaiveExampleCode()
  {
    // simulate user input data
    var url = "https://google.cloud.com";
    var data = "This is my data that I will save to the cloud!";
    var compress = true;
    var encrypt = true;

    var cloudData = new CloudData(url);
    if (compress && encrypt)
    {
      cloudData = new CompressedAndEncryptedData(url);
    }
    else if (compress)
    {
      cloudData = new CompressedData(url);
    }
    else if (encrypt)
    {
      cloudData = new EncryptedData(url);
    }

    cloudData.Save(data);
  }
}