

namespace CreationalDesignPatterns.src.AbstractFactory;

public class UserSetttingsForm
{
  public void Render(IUIComponentFactory uIComponentFactory)
  {
   uIComponentFactory.CreateButton().Render();
   uIComponentFactory.CreateCheckbox().Render();
  }
}
