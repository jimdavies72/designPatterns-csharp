// Strategy

namespace behaviouralDesignPatterns.src.Strategy;

public class CompressorWEBM : ICompressor
{

  public void Compress()
  {
    Console.WriteLine("Compressing video in WEBM format");
  }
}
