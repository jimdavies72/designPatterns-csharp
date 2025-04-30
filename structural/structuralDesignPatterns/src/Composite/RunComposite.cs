using System;

namespace structuralDesignPatterns.src.Composite;

public class RunComposite
{
  public static void RunCompositePattern()
  {
    // master package
    var package = new Box();

    // first small box contained in master box
    var box1 = new Box();
    box1.Add(new Microphone());

    // second small box contained in master box
    var box2 = new Box();

    // third small box contained in box 2
    var box3 = new Box();
    box3.Add(new Mouse());

    // fourth small box contained in box 2
    var box4 = new Box();
    box4.Add(new Keyboard());

    //add box 3 & 4 to box 2
    box2.Add(box3);
    box2.Add(box4);

    //add box 1 & 2 to master box
    package.Add(box1);
    package.Add(box2);


    
    Console.WriteLine("Box 1 price: {0}", box1.GetPrice());
    Console.WriteLine("Box 2 price: {0}", box2.GetPrice());
    Console.WriteLine("Total Package price: {0}", package.GetPrice());

  }
}
