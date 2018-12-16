using System;
using System.Linq;
using System.Windows.Forms;
using MathCore;

namespace JenkinsMathLib
{

  public partial class Form1 : Form
  {

    public delegate object MathOperationPtr();
    private string mSelectedMathOperation;
    private string mInputFieldOne, mInputFieldTwo;
    public Form1()
    {
      InitializeComponent();
    }
    private void CalculateBtn_Click(object sender, EventArgs e)
    {
      mInputFieldOne = inputOneTxtFld.Text.TrimStart().TrimEnd();
      mInputFieldTwo = inputTwoTxtFld.Text.TrimStart().TrimEnd();
      MathController controller = new MathController();
      bool returnValueInputFields = controller.SetMathControllerInputFields(ref mInputFieldOne,
                                                                            ref mInputFieldTwo);
      bool returnValueMathOperation = controller.SetMathControllerMathOperator(ref mSelectedMathOperation);
      if (returnValueInputFields
         && returnValueMathOperation)
      {
        double answer = controller.PreformCalculation();
        MessageBox.Show("Calculated Value: " + answer,
          "Successful Calculation", MessageBoxButtons.OK);
        ClearCalculatorBtn_Click(null, null);
      }
      else if (!returnValueInputFields)
      {
        MessageBox.Show("Invalid Input Fields!",
          "Warning", MessageBoxButtons.OK);
        ClearCalculatorBtn_Click(null, null);
      }
      else if (!returnValueMathOperation)
      {
        MessageBox.Show("Select Math Operation!",
          "Warning", MessageBoxButtons.OK);
        ClearCalculatorBtn_Click(null, null);
      }
    }

    private void ClearCalculatorBtn_Click(object sender, EventArgs e)
    {
      inputOneTxtFld.Text = string.Empty;
      inputTwoTxtFld.Text = string.Empty;
      addRadioBtn.Checked = false;
      subtractRadioBtn.Checked = false;
      multiplyRadioBtn.Checked = false;
      divideRadioBtn.Checked = false;
      mSelectedMathOperation = string.Empty;
    }

    private void addRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton selection = (RadioButton)sender;
      mSelectedMathOperation = selection.Text;
    }

    private void subtractRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton selection = (RadioButton)sender;
      mSelectedMathOperation = selection.Text;
    }

    private void multiplyRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton selection = (RadioButton)sender;
      mSelectedMathOperation = selection.Text;
    }


    private void divideRadioBtn_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton selection = (RadioButton)sender;
      mSelectedMathOperation = selection.Text;
    }

    public string GetSelectedMathOperation()
    {
      if (mSelectedMathOperation != string.Empty)
        return mSelectedMathOperation;
      return string.Empty;
    }
  }
}
