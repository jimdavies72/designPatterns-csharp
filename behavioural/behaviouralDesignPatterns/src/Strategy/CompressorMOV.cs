// Strategy

namespace behaviouralDesignPatterns.src.Strategy;

public class CompressorMOV : ICompressor
{
  public void Compress()
  {
    Console.WriteLine("Compressing video in MOV format");
  }
}
