// Context

namespace behaviouralDesignPatterns.src.Strategy;

public class VideoStorage
{

  private ICompressor _compressor;
  private IOverlay _overlay;

  public VideoStorage(ICompressor compressor, IOverlay overlay)
  {
    _compressor = compressor;
    _overlay = overlay;
  }

  public void SetCompressor(ICompressor compressor)
  {
    _compressor = compressor;
  }

  public void SetOverlay(IOverlay overlay)
  {
    _overlay = overlay;
  }

  public void Store(string filename)
  {
    _compressor.Compress();
    _overlay.Apply();

    System.Console.WriteLine("Storing video to {0}.{1}", filename, _compressor);
  }

}