namespace behaviouralDesignPatterns.src.Iterator;

public interface IIterator<T>
{
  void Next();
  T Current();
  bool HasNext();
}