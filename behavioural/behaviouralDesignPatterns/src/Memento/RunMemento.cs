
namespace behaviouralDesignPatterns.src.Memento;

public class RunMemento
{
  public static void RunMementoPattern()
  {
    var editor = new Editor();
    var history = new History(editor);

    history.Backup();
    editor.Title = "Draft Title";
    history.Backup();
    editor.Title = "Document Actual Title";
    history.Backup();
    editor.Content = "The first content";
    history.Backup();
    editor.Content = "This is more new content";

    history.ShowHistory();

    Console.WriteLine("\nTitle: {0}", editor.Title);
    Console.WriteLine("Content: {0}\n", editor.Content);

    history.Undo();
    Console.WriteLine("Title: {0}", editor.Title);
    Console.WriteLine("Content: {0}\n", editor.Content);

    history.Undo();
    Console.WriteLine("Title: {0}", editor.Title);
    Console.WriteLine("Content: {0}\n", editor.Content);

    history.Undo();
    Console.WriteLine("Title: {0}", editor.Title);
    Console.WriteLine("Content: {0}\n", editor.Content);

    history.Undo();
    Console.WriteLine("Title: {0}", editor.Title);
    Console.WriteLine("Content: {0}\n", editor.Content);
  }
}