namespace JenkinsMathLib
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.CalculateBtn = new System.Windows.Forms.Button();
      this.addRadioBtn = new System.Windows.Forms.RadioButton();
      this.subtractRadioBtn = new System.Windows.Forms.RadioButton();
      this.multiplyRadioBtn = new System.Windows.Forms.RadioButton();
      this.divideRadioBtn = new System.Windows.Forms.RadioButton();
      this.inputOneTxtFld = new System.Windows.Forms.TextBox();
      this.inputTwoTxtFld = new System.Windows.Forms.TextBox();
      this.InputsBox = new System.Windows.Forms.GroupBox();
      this.ClearCalculatorBtn = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.InputsBox.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // CalculateBtn
      // 
      this.CalculateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.CalculateBtn.Location = new System.Drawing.Point(192, 178);
      this.CalculateBtn.Name = "CalculateBtn";
      this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
      this.CalculateBtn.TabIndex = 0;
      this.CalculateBtn.Text = "Calculate";
      this.CalculateBtn.UseVisualStyleBackColor = true;
      this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
      // 
      // addRadioBtn
      // 
      this.addRadioBtn.AllowDrop = true;
      this.addRadioBtn.AutoSize = true;
      this.addRadioBtn.Location = new System.Drawing.Point(15, 22);
      this.addRadioBtn.Name = "addRadioBtn";
      this.addRadioBtn.Size = new System.Drawing.Size(44, 17);
      this.addRadioBtn.TabIndex = 1;
      this.addRadioBtn.TabStop = true;
      this.addRadioBtn.Tag = "Add";
      this.addRadioBtn.Text = "Add";
      this.addRadioBtn.UseVisualStyleBackColor = true;
      this.addRadioBtn.CheckedChanged += new System.EventHandler(this.addRadioBtn_CheckedChanged);
      // 
      // subtractRadioBtn
      // 
      this.subtractRadioBtn.AutoSize = true;
      this.subtractRadioBtn.Location = new System.Drawing.Point(15, 46);
      this.subtractRadioBtn.Name = "subtractRadioBtn";
      this.subtractRadioBtn.Size = new System.Drawing.Size(65, 17);
      this.subtractRadioBtn.TabIndex = 2;
      this.subtractRadioBtn.TabStop = true;
      this.subtractRadioBtn.Tag = "Subtract";
      this.subtractRadioBtn.Text = "Subtract";
      this.subtractRadioBtn.UseVisualStyleBackColor = true;
      this.subtractRadioBtn.CheckedChanged += new System.EventHandler(this.subtractRadioBtn_CheckedChanged);
      // 
      // multiplyRadioBtn
      // 
      this.multiplyRadioBtn.AutoSize = true;
      this.multiplyRadioBtn.Location = new System.Drawing.Point(15, 70);
      this.multiplyRadioBtn.Name = "multiplyRadioBtn";
      this.multiplyRadioBtn.Size = new System.Drawing.Size(60, 17);
      this.multiplyRadioBtn.TabIndex = 3;
      this.multiplyRadioBtn.TabStop = true;
      this.multiplyRadioBtn.Tag = "Multiply";
      this.multiplyRadioBtn.Text = "Multiply";
      this.multiplyRadioBtn.UseVisualStyleBackColor = true;
      this.multiplyRadioBtn.CheckedChanged += new System.EventHandler(this.multiplyRadioBtn_CheckedChanged);
      // 
      // divideRadioBtn
      // 
      this.divideRadioBtn.AutoSize = true;
      this.divideRadioBtn.Location = new System.Drawing.Point(15, 93);
      this.divideRadioBtn.Name = "divideRadioBtn";
      this.divideRadioBtn.Size = new System.Drawing.Size(55, 17);
      this.divideRadioBtn.TabIndex = 4;
      this.divideRadioBtn.TabStop = true;
      this.divideRadioBtn.Tag = "Divide";
      this.divideRadioBtn.Text = "Divide";
      this.divideRadioBtn.UseVisualStyleBackColor = true;
      this.divideRadioBtn.CheckedChanged += new System.EventHandler(this.divideRadioBtn_CheckedChanged);
      // 
      // inputOneTxtFld
      // 
      this.inputOneTxtFld.Location = new System.Drawing.Point(9, 34);
      this.inputOneTxtFld.Name = "inputOneTxtFld";
      this.inputOneTxtFld.Size = new System.Drawing.Size(100, 20);
      this.inputOneTxtFld.TabIndex = 6;
    
      // 
      // inputTwoTxtFld
      // 
      this.inputTwoTxtFld.Location = new System.Drawing.Point(9, 79);
      this.inputTwoTxtFld.Name = "inputTwoTxtFld";
      this.inputTwoTxtFld.Size = new System.Drawing.Size(100, 20);
      this.inputTwoTxtFld.TabIndex = 7;
      
      // 
      // InputsBox
      // 
      this.InputsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.InputsBox.Controls.Add(this.inputTwoTxtFld);
      this.InputsBox.Controls.Add(this.inputOneTxtFld);
      this.InputsBox.Location = new System.Drawing.Point(169, 33);
      this.InputsBox.Name = "InputsBox";
      this.InputsBox.Size = new System.Drawing.Size(115, 121);
      this.InputsBox.TabIndex = 8;
      this.InputsBox.TabStop = false;
      this.InputsBox.Text = "Calculator Inputs";
      // 
      // ClearCalculatorBtn
      // 
      this.ClearCalculatorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClearCalculatorBtn.Location = new System.Drawing.Point(44, 178);
      this.ClearCalculatorBtn.Name = "ClearCalculatorBtn";
      this.ClearCalculatorBtn.Size = new System.Drawing.Size(75, 23);
      this.ClearCalculatorBtn.TabIndex = 9;
      this.ClearCalculatorBtn.Text = "Clear";
      this.ClearCalculatorBtn.UseVisualStyleBackColor = true;
      this.ClearCalculatorBtn.Click += new System.EventHandler(this.ClearCalculatorBtn_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add(this.subtractRadioBtn);
      this.groupBox1.Controls.Add(this.divideRadioBtn);
      this.groupBox1.Controls.Add(this.addRadioBtn);
      this.groupBox1.Controls.Add(this.multiplyRadioBtn);
      this.groupBox1.Location = new System.Drawing.Point(29, 29);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(100, 133);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Math Operations";
      // 
      // Form1
      // 
      this.AllowDrop = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(313, 221);
      this.Controls.Add(this.ClearCalculatorBtn);
      this.Controls.Add(this.InputsBox);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.CalculateBtn);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Jenkins Calculator";
      this.InputsBox.ResumeLayout(false);
      this.InputsBox.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CalculateBtn;
    private System.Windows.Forms.RadioButton addRadioBtn;
    private System.Windows.Forms.RadioButton subtractRadioBtn;
    private System.Windows.Forms.RadioButton multiplyRadioBtn;
    private System.Windows.Forms.RadioButton divideRadioBtn;
    private System.Windows.Forms.TextBox inputOneTxtFld;
    private System.Windows.Forms.TextBox inputTwoTxtFld;
    private System.Windows.Forms.GroupBox InputsBox;
    private System.Windows.Forms.Button ClearCalculatorBtn;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

