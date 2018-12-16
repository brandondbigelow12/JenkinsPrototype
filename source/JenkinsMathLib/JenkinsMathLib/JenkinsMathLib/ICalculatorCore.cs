using System;
using System.Collections.Generic;
using System.Text;

namespace MathCore
{
  public interface ICalculatorCore
  {
    double AdditionOperation(double firstNumber, double secondNumber);
    double SubtractionOperation(double firstNumber, double secondNumber);
    double MultiplicationOperation(double firstNumber, double secondNumber);
    double DivisionOperation(double firstNumber, double secondNumber);

  }
}
