namespace behaviouralDesignPatterns.src.CommandUndoable;

public class RunCommandUndoable
{
  public static void RunCommandUndoablePattern()
  {
    var htmlDoc = new HtmlDocument();
   var history = new History();
   htmlDoc.Content = "Hello World";
   Console.WriteLine(htmlDoc.Content);

   var italicCommand = new ItalicCommand(htmlDoc, history);
   italicCommand.Execute();
   Console.WriteLine(htmlDoc.Content);
   var undoCommand = new UndoCommand(history);
   undoCommand.Execute();
   Console.WriteLine(htmlDoc.Content);
  }
}