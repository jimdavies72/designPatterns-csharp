using System;

namespace behaviouralDesignPatterns.src.Interpreter;

public class Interpreter
{
  private Context _context;

  public Interpreter(Context context)
  {
    _context = context;
  }

  public int Interpret(string expression)
  {
    IExpression expressionTree = BuildExpressionTree(expression);
    return expressionTree.Interpret(_context);
  }

  private IExpression BuildExpressionTree(string input)
  {
    //hard coded expression tree for simplicity
    input = "1 + 2 + 3";

    IExpression expressionTree = new AdditionExpression(
      new MultiplicationExpression(
        new NumberExpression("2"),
        new NumberExpression("3")
      ),
      new NumberExpression("1")
    );

    return expressionTree;
  }
}
