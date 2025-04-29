using System;

namespace behaviouralDesignPatterns.src.Interpreter;

public class RunInterpreter
{
  public static void RunInterpreterPatter()
  {
    // this example is hard coded in the interpreter
    string input = "1 + 2 + 3";

    Context context = new Context();
    Interpreter interpreter = new Interpreter(context);
    int result = interpreter.Interpret(input);

    Console.WriteLine("Result: {0}", result);
  }
}
