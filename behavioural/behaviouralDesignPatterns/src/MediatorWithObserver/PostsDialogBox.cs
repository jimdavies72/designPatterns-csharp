// Mediator AND Observer
using behaviouralDesignPatterns.src.MediatorWithObserver.UIFrameWork;

namespace behaviouralDesignPatterns.src.MediatorWithObserver;

public class PostsDialogBox
{
  private ListBox _postsListBox;
  private TextBox _titleTextBox;
  private Button _saveButton;

  public PostsDialogBox()
  {
    _postsListBox = new ListBox();
    _titleTextBox = new TextBox();
    _saveButton = new Button();

    _postsListBox.AddEventHandler(PostSelected);
    _titleTextBox.AddEventHandler(TitleChanged);
  }

  // Test where the user selects a value in the List Box
  public void SimulateUserInteraction()
  {
    _postsListBox.SetSelection("Mediator with Observer Post");
    //_titleTextBox.SetText("");

    Console.WriteLine("Title Text Box: {0}", _titleTextBox.GetText());
    Console.WriteLine("Save Button Enabled: {0}", _saveButton.isEnabled());
  }

  private void PostSelected()
  {
    _titleTextBox.SetText(_postsListBox.GetSelection());
    _saveButton.SetEnabled(true);
  }

  private void TitleChanged()
  {
    bool isTitleEmpty = _titleTextBox.GetText() == string.Empty;
    _saveButton.SetEnabled(!isTitleEmpty);
  }

}
