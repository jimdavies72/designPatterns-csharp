// Strategy

namespace behaviouralDesignPatterns.src.Strategy;

public class CompressorMP4 : ICompressor
{
  public void Compress()
  {
    Console.WriteLine("Compressing video in MP4 format");
  }
}
