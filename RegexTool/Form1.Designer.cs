namespace RegexTool
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
    protected override void Dispose (bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose ();
      }
      base.Dispose (disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent ()
    {
      this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
      this.labelInput = new System.Windows.Forms.Label();
      this.radioButtonText = new System.Windows.Forms.RadioButton();
      this.radioButtonFileList = new System.Windows.Forms.RadioButton();
      this.textBoxPath = new System.Windows.Forms.TextBox();
      this.labelPath = new System.Windows.Forms.Label();
      this.richTextBoxSearch = new System.Windows.Forms.RichTextBox();
      this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
      this.labelSearch = new System.Windows.Forms.Label();
      this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
      this.labelOutput = new System.Windows.Forms.Label();
      this.buttonLog = new System.Windows.Forms.Button();
      this.buttonReplace = new System.Windows.Forms.Button();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.SuspendLayout();
      // 
      // richTextBoxInput
      // 
      this.richTextBoxInput.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.richTextBoxInput.Location = new System.Drawing.Point(12, 37);
      this.richTextBoxInput.Name = "richTextBoxInput";
      this.richTextBoxInput.Size = new System.Drawing.Size(723, 179);
      this.richTextBoxInput.TabIndex = 0;
      this.richTextBoxInput.Text = "";
      // 
      // labelInput
      // 
      this.labelInput.AutoSize = true;
      this.labelInput.Location = new System.Drawing.Point(12, 14);
      this.labelInput.Name = "labelInput";
      this.labelInput.Size = new System.Drawing.Size(39, 17);
      this.labelInput.TabIndex = 1;
      this.labelInput.Text = "Input";
      // 
      // radioButtonText
      // 
      this.radioButtonText.AutoSize = true;
      this.radioButtonText.Location = new System.Drawing.Point(76, 12);
      this.radioButtonText.Name = "radioButtonText";
      this.radioButtonText.Size = new System.Drawing.Size(56, 21);
      this.radioButtonText.TabIndex = 2;
      this.radioButtonText.TabStop = true;
      this.radioButtonText.Text = "Text";
      this.radioButtonText.UseVisualStyleBackColor = true;
      // 
      // radioButtonFileList
      // 
      this.radioButtonFileList.AutoSize = true;
      this.radioButtonFileList.Location = new System.Drawing.Point(138, 12);
      this.radioButtonFileList.Name = "radioButtonFileList";
      this.radioButtonFileList.Size = new System.Drawing.Size(72, 21);
      this.radioButtonFileList.TabIndex = 3;
      this.radioButtonFileList.TabStop = true;
      this.radioButtonFileList.Text = "File list";
      this.radioButtonFileList.UseVisualStyleBackColor = true;
      // 
      // textBoxPath
      // 
      this.textBoxPath.Location = new System.Drawing.Point(284, 10);
      this.textBoxPath.Name = "textBoxPath";
      this.textBoxPath.Size = new System.Drawing.Size(353, 22);
      this.textBoxPath.TabIndex = 4;
      // 
      // labelPath
      // 
      this.labelPath.AutoSize = true;
      this.labelPath.Location = new System.Drawing.Point(241, 14);
      this.labelPath.Name = "labelPath";
      this.labelPath.Size = new System.Drawing.Size(37, 17);
      this.labelPath.TabIndex = 5;
      this.labelPath.Text = "Path";
      // 
      // richTextBoxSearch
      // 
      this.richTextBoxSearch.Font = new System.Drawing.Font("Courier New", 10.2F);
      this.richTextBoxSearch.Location = new System.Drawing.Point(12, 250);
      this.richTextBoxSearch.Name = "richTextBoxSearch";
      this.richTextBoxSearch.Size = new System.Drawing.Size(365, 67);
      this.richTextBoxSearch.TabIndex = 6;
      this.richTextBoxSearch.Text = "";
      // 
      // richTextBoxLog
      // 
      this.richTextBoxLog.Font = new System.Drawing.Font("Courier New", 10.2F);
      this.richTextBoxLog.Location = new System.Drawing.Point(383, 250);
      this.richTextBoxLog.Name = "richTextBoxLog";
      this.richTextBoxLog.Size = new System.Drawing.Size(352, 67);
      this.richTextBoxLog.TabIndex = 7;
      this.richTextBoxLog.Text = "";
      // 
      // labelSearch
      // 
      this.labelSearch.AutoSize = true;
      this.labelSearch.Location = new System.Drawing.Point(12, 225);
      this.labelSearch.Name = "labelSearch";
      this.labelSearch.Size = new System.Drawing.Size(53, 17);
      this.labelSearch.TabIndex = 8;
      this.labelSearch.Text = "Search";
      // 
      // richTextBoxOutput
      // 
      this.richTextBoxOutput.Font = new System.Drawing.Font("Courier New", 10.2F);
      this.richTextBoxOutput.Location = new System.Drawing.Point(12, 350);
      this.richTextBoxOutput.Name = "richTextBoxOutput";
      this.richTextBoxOutput.Size = new System.Drawing.Size(723, 179);
      this.richTextBoxOutput.TabIndex = 10;
      this.richTextBoxOutput.Text = "";
      // 
      // labelOutput
      // 
      this.labelOutput.AutoSize = true;
      this.labelOutput.Location = new System.Drawing.Point(9, 325);
      this.labelOutput.Name = "labelOutput";
      this.labelOutput.Size = new System.Drawing.Size(51, 17);
      this.labelOutput.TabIndex = 11;
      this.labelOutput.Text = "Output";
      // 
      // buttonLog
      // 
      this.buttonLog.Location = new System.Drawing.Point(383, 221);
      this.buttonLog.Name = "buttonLog";
      this.buttonLog.Size = new System.Drawing.Size(75, 23);
      this.buttonLog.TabIndex = 12;
      this.buttonLog.Text = "Log";
      this.buttonLog.UseVisualStyleBackColor = true;
      this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
      // 
      // buttonReplace
      // 
      this.buttonReplace.Location = new System.Drawing.Point(485, 221);
      this.buttonReplace.Name = "buttonReplace";
      this.buttonReplace.Size = new System.Drawing.Size(75, 23);
      this.buttonReplace.TabIndex = 13;
      this.buttonReplace.Text = "Replace";
      this.buttonReplace.UseVisualStyleBackColor = true;
      this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(660, 10);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(75, 23);
      this.buttonLoad.TabIndex = 14;
      this.buttonLoad.Text = "Load";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(660, 323);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 15;
      this.buttonSave.Text = "Save";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(746, 541);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.buttonReplace);
      this.Controls.Add(this.buttonLog);
      this.Controls.Add(this.labelOutput);
      this.Controls.Add(this.richTextBoxOutput);
      this.Controls.Add(this.labelSearch);
      this.Controls.Add(this.richTextBoxLog);
      this.Controls.Add(this.richTextBoxSearch);
      this.Controls.Add(this.labelPath);
      this.Controls.Add(this.textBoxPath);
      this.Controls.Add(this.radioButtonFileList);
      this.Controls.Add(this.radioButtonText);
      this.Controls.Add(this.labelInput);
      this.Controls.Add(this.richTextBoxInput);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox richTextBoxInput;
    private System.Windows.Forms.Label labelInput;
    private System.Windows.Forms.RadioButton radioButtonText;
    private System.Windows.Forms.RadioButton radioButtonFileList;
    private System.Windows.Forms.TextBox textBoxPath;
    private System.Windows.Forms.Label labelPath;
    private System.Windows.Forms.RichTextBox richTextBoxSearch;
    private System.Windows.Forms.RichTextBox richTextBoxLog;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.RichTextBox richTextBoxOutput;
    private System.Windows.Forms.Label labelOutput;
    private System.Windows.Forms.Button buttonLog;
    private System.Windows.Forms.Button buttonReplace;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}

