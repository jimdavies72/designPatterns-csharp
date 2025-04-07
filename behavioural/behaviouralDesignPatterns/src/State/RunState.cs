
namespace behaviouralDesignPatterns.src.State;

public class RunState
{
  public static void RunStatePattern()
  {
    var doc = new Document(UserRoles.Admin);
    Console.WriteLine("Document state: {0}", doc.State); 

    doc.Publish();
    Console.WriteLine("Document state: {0}", doc.State);

    doc.Publish();
    Console.WriteLine("Document state: {0}", doc.State);

    doc.State = new DraftState(doc);
    Console.WriteLine("Document state: {0}", doc.State);
  }
}