namespace structuralDesignPatterns.src.Facade;

public class OrderRequest
{
  // This is the Request object containg the user submitted data 

  public string Name {get;} = "james";
  public string CardNumber {get;} = "1234";
  public float Amount {get;} = 20.99f;
  public string Address {get;} = "123 Main St, Liverpool";
  public string[] ItemIds {get;} = { "123", "456", "789", "777" };
}
