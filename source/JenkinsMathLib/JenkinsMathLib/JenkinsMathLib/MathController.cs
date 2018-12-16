using MathCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsMathLib
{
  public class MathController : EventArgs
  {
    public double mNumber1, mNumber2;
    public string mSelectedMathOperation;

    public enum MathOperation
    {
      Add,
      Subtract,
      Multiply,
      Divide
    };

    public MathController()
    {
    }

    public bool SetMathControllerInputFields(ref string number1,
                                            ref string number2)
    {
      return ValidateInput(ref number1, ref number2);
    }

    public bool SetMathControllerMathOperator(ref string mathOperator)
    {
      return GetSelectedMathOperation(ref mathOperator);
    }

    public double PreformCalculation()
    {
      ICalculatorCore calculatorCore = new CalculatorCore();

      if (mSelectedMathOperation == MathOperation.Add.ToString())
      {
        return calculatorCore.AdditionOperation(mNumber1, mNumber2);
      }
      else if (mSelectedMathOperation == MathOperation.Subtract.ToString())
      {
        return calculatorCore.SubtractionOperation(mNumber1, mNumber2);
      }
      else if (mSelectedMathOperation == MathOperation.Multiply.ToString())
      {
        return calculatorCore.MultiplicationOperation(mNumber1, mNumber2);
      }
      else if (mSelectedMathOperation == MathOperation.Divide.ToString())
      {
        return calculatorCore.DivisionOperation(mNumber1, mNumber2);
      }
      return double.NaN;
    }
    public bool GetSelectedMathOperation(ref string mathType)
    {
      if (mathType == string.Empty 
          || mathType == null)
      {
        return false;
      }
      else
      {
        mSelectedMathOperation = mathType.ToString();
        return true;
      }
    }
    public bool ValidateInput(ref string number1, ref string number2)
    {
      if (number1 == string.Empty 
        || number2 == string.Empty)
      {
        return false;
      }
      else if (number1 == string.Empty
        && number2 == string.Empty)
      {
        return false;
      }
      else
      {
        try
        {
          bool num1 = double.TryParse(number1.Replace(" ", ""), out mNumber1);
          bool num2 = double.TryParse(number2.Replace(" ", ""), out mNumber2);
          //Check for divide by Zero
          if (Math.Abs(mNumber2) <= 0.00000)
          {
            num2 = false;
          }
          //If both return false, we want to return false. 
          if(!num1 && !num2 )
          {
            return false;
          }
          else
          {
            return (num1.Equals(num2));
          }
        }
        catch (Exception exception)
        {
          throw new Exception(exception.Message);
        }
      }
    }

  }
}
