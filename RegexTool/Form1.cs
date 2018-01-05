using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace RegexTool
{
  public partial class Form1: Form
  {
    private RegexTool R;


    public Form1 ()
    {
      InitializeComponent ();

      R = new RegexTool ();
      radioButtonText.Checked = true;
    }


    private void PrepareSearch ()
    {
      R.ClearOutput ();
      List <string> search = richTextBoxSearch.Lines.ToList ();
      List <string> replace = richTextBoxLog.Lines.ToList ();
      while (search.Remove ("")) {}
      while (replace.Remove ("")) {}
      R.Search = search;
      R.Replace = replace;
    }


    private void buttonLog_Click (object sender, EventArgs e)
    {
      PrepareSearch ();
      if (radioButtonText.Checked)
      {
        R.Input = richTextBoxInput.Text;
        R.SearchAndLog ();
      }
      else
      {
        R.SearchAndLog (richTextBoxInput.Lines.ToList (), FormatPath ());
      }
      richTextBoxOutput.Text = R.Output;
    }


    private void buttonReplace_Click (object sender, EventArgs e)
    {
      PrepareSearch ();
      if (radioButtonText.Checked)
      {
        R.Input = richTextBoxInput.Text;
        R.SearchAndReplace ();
      }
      else
      {
        R.SearchAndReplace (richTextBoxInput.Lines.ToList (), FormatPath ());
      }
      richTextBoxOutput.Text = R.Output;
    }
    

    private string FormatPath ()
    {
      string text = textBoxPath.Text;
      if (text.Length > 0 && text [text.Length - 1] != '\\' && 
                             text [text.Length - 1] != '/')
        return text + "\\";
      return text;
    }


    private void buttonLoad_Click (object sender, EventArgs e)
    {
      openFileDialog1.Multiselect = radioButtonFileList.Checked;
      if (openFileDialog1.ShowDialog () == DialogResult.OK)
      {
        if (radioButtonText.Checked)
          richTextBoxInput.Text = File.ReadAllText (openFileDialog1.FileName);
        else
        {
          richTextBoxInput.Lines = richTextBoxInput.Lines.
                                   Concat (openFileDialog1.FileNames).ToArray ();
        }
      }
    }


    private void buttonSave_Click (object sender, EventArgs e)
    {
      if (saveFileDialog1.ShowDialog () == DialogResult.OK)
      {
        try
        {
          File.WriteAllText (saveFileDialog1.FileName, richTextBoxOutput.Text);
        }
        catch (Exception ex)
        {
          MessageBox.Show (ex.Message);
          return;
        }
      }
    }
  }
}
