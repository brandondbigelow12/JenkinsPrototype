using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsMathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsMathLib.Tests
{
  [TestClass()]
  public class MathControllerTests
  {
    [TestMethod()]
    public void MathControllerUIInputFields()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "4.4", y = "9.9";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(true, answer);
    }
    [TestMethod()]
    public void MathControllerUIFieldOne_Fail()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "", y = "8.9";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldTwo_Fail()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "3.2", y = "";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldsContainLetters_Pass()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "AAAA", y = "BBBB";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldOneContainLetters_Pass()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "AAAA", y = "54";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldTwoContainLetters_Pass()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "543", y = "AAA";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldOneContainsSpaces_Pass()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "   ", y = "5.5";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldTwoContainsSpaces_Pass()
    {
      //Arrange
      MathController controller = new MathController();
      string x = "55", y = "   ";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(false, answer);
    }

    [TestMethod()]
    public void MathControllerUIFieldOneContainsValidInputWithSpaces_Pass()
    {
      //Arrange
      MathController controller = new MathController();
      string x = " 5 5 ", y = "3.2";
      //Act
      bool answer = controller.ValidateInput(ref x, ref y);
      //Assert - expected, actual
      Assert.AreEqual(true, answer);
    }

  }
}