namespace behaviouralDesignPatterns.src.Iterator;

public class RunIterator
{
  public static void RunIteratorPattern()
  {
    ShoppingList list = new ShoppingList();
    list.Push("Milk");
    list.Push("Bread");
    list.Push("Cheese");

    // allows for the internal data structures to change without affecting its consumer(s)
    var iterator = list.CreateIterator();
    while (iterator.HasNext())
    {
      Console.WriteLine(iterator.Current());
      iterator.Next();
    }
  }

}