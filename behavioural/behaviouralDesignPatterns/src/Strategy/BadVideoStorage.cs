
namespace behaviouralDesignPatterns.src.Strategy;

public class BadVideoStorage
{
  private Compressors _compressor;
  private Overlays _overlay;

  public BadVideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
  {
    _compressor = compressor;
    _overlay = overlay;
  }

  public void SetCompressor(Compressors compressor) 
  {
    _compressor = compressor;
  }

  public void SetOverlay(Overlays overlay)
  {
    _overlay = overlay;
  }

  public void Store(string filename)
  {
    if (_compressor == Compressors.MOV)
    {
      Console.WriteLine("Storing video in MOV format with overlay {0}", _overlay);
    } else if (_compressor == Compressors.MP4)
    {
      Console.WriteLine("Storing video in MP4 format with overlay {0}", _overlay);
    } else if (_compressor == Compressors.WEBM)
    {
      Console.WriteLine("Storing video in WEBM format with overlay {0}", _overlay);
    }

    // Overlay logic..
    if (_overlay == Overlays.BlackAndWhite)
    { 
      Console.WriteLine("Applying black and white overlay");
    } else if (_overlay == Overlays.Blur)
    {
      Console.WriteLine("Applying blue overlay");
    } else if (_overlay == Overlays.None)
    {
      Console.WriteLine("Applying no overlay");
    }

    Console.WriteLine("Storing video to {0}.{1}", filename, _compressor);
  }
}