namespace behaviouralDesignPatterns.src.Strategy;

public class RunStrategy()
{
  public static void RunStrategyPattern()
  {
    var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
    videoStorage.Store("/videos/movie");
    videoStorage.SetCompressor(new CompressorMP4());
    videoStorage.SetOverlay(new OverlayNone());
    videoStorage.Store("/videos/movie");
  }
}