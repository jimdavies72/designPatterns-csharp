// The Concrete Mediator Class

namespace behaviouralDesignPatterns.src.Mediator;

public class PostsDialogBox : DialogBox
{
  //fields for all ui compoents
  private ListBox _postsListBox;
  private TextBox _titleTextBox;
  private Button _saveButton;

  public PostsDialogBox()
  {
    _postsListBox = new ListBox(this);
    _titleTextBox = new TextBox(this);
    _saveButton = new Button(this);

    // set this initial state of the button
    _saveButton.SetEnabled(false);
  }

  // Test where the user selects a value in the List Box
  public void SimulateUserInteraction()
  {
    // ListBox.SetSelection is called and then the _owner.Changed method is called 
    _postsListBox.SetSelection("Post 2");

    // if TextBox contains an empty string then the save button is disabled
    _titleTextBox.SetText("");

    Console.WriteLine("Title Text Box: {0}", _titleTextBox.GetText());
    Console.WriteLine("Save Button Enabled: {0}", _saveButton.isEnabled());
  }

  public override void Changed(UIControl uiControl)
  {
    // this can get bulky as we add controls. The Observer design pattern can be used to solve this.
    if (uiControl == _postsListBox)
    {
      HandlePostChanged();
    }
    else if (uiControl == _titleTextBox)
    {
      HandleTitleChanged();
    }
  }

  private void HandlePostChanged()
  {
    _titleTextBox.SetText(_postsListBox.GetSelection());
    _saveButton.SetEnabled(true);
  }

  private void HandleTitleChanged()
  {
    bool isTitleEmpty = _titleTextBox.GetText() == string.Empty;
    _saveButton.SetEnabled(!isTitleEmpty);
  }
}
