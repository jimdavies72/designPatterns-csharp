using System;
using structuralDesignPatterns.src.Adapter.ColourLibrary;

namespace structuralDesignPatterns.src.Adapter;

public class RunAdapter
{
  public static void RunAdapterPattern()
  {
    // instance the video editor and pass it a new video to work with
    var videoEditor = new VideoEditor(new Video());

// apply a standard color to the video....
    videoEditor.ApplyColor(new BlackAndWhiteColor());
    
    // now apply the adpated color to the video
    videoEditor.ApplyColor(new RainbowColor(new Rainbow()));
  }
}
