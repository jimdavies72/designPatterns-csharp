namespace CreationalDesignPatterns.src.Prototype;

public class RunProtoype
{
  public static void RunProtoypePattern()
  {
    var circle = new Circle();
    circle.Draw();
    //user clicks and drags to resize
    circle.Radius = 12;

    //user adds a new rectangle to the GUI
    var rectangle = new Rectangle();
    rectangle.Draw();
    // user resizes the rectangle
    rectangle.Width = 15;
    rectangle.Height = 10;

    //user right clicks and selects Duplicate
    var ShapeActions = new ShapeActions();
    IShape newCircle =ShapeActions.Duplicate(circle);
    newCircle.Draw();
    IShape newRectangle = ShapeActions.Duplicate(rectangle);
    newRectangle.Draw();
  }
}