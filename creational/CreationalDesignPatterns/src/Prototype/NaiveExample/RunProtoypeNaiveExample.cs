using System;

namespace CreationalDesignPatterns.src.Prototype.NaiveExample;

public class RunProtoypeNaiveExample
{
  public static void RunProtoypeNaiveExampleCode()
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
    ShapeActions.Duplicate(circle);
    ShapeActions.Duplicate(rectangle);

  }
}