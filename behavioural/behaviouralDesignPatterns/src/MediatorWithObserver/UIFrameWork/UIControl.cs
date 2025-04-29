//(Observer pattern) Subject Class

namespace behaviouralDesignPatterns.src.MediatorWithObserver.UIFrameWork;

// manages the event handlers
public class UIControl
{
  private List<EventHandler> _eventHandlers = new List<EventHandler>();

  public void AddEventHandler(EventHandler eventHandler)
  {
    _eventHandlers.Add(eventHandler);
  }

  public void NotifyEventHandlers()
  {
    foreach (var handler in _eventHandlers)
    {
      handler();
    }
  }
}
