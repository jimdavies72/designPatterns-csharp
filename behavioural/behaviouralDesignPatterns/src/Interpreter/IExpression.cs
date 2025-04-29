using System;

namespace behaviouralDesignPatterns.src.Interpreter;

public interface IExpression
{
  int Interpret(Context context);
}
