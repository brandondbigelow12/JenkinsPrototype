using System;

namespace MathCore
{
  public class CalculatorCore : ICalculatorCore
  {
    public CalculatorCore()
    {

    }
    double ICalculatorCore.AdditionOperation(double firstNumber, double secondNumber)
    {
      return firstNumber + secondNumber;
    }

    double ICalculatorCore.SubtractionOperation(double firstNumber, double secondNumber)
    {
      return firstNumber - secondNumber;
    }

    double ICalculatorCore.MultiplicationOperation(double firstNumber, double secondNumber)
    {
      return firstNumber * secondNumber;
    }

    double ICalculatorCore.DivisionOperation(double firstNumber, double secondNumber)
    {
      return firstNumber / secondNumber;
    }
  }
}
