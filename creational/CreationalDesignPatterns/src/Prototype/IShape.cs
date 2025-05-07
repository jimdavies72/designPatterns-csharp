using System;

namespace CreationalDesignPatterns.src.Prototype;

public interface IShape
{
  void Draw();
  IShape Duplicate();
}
