namespace behaviouralDesignPatterns.src.CommandUndoable;

public interface IUndoableCommand: ICommand
{
  void Unexectute();
}