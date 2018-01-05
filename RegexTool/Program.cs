using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTool
{

//========================================================================================
// class Program
//========================================================================================


  class RegexTool
  {
    public string Input = null;
    public List <string> Search = null;
    private List <string> replace = null;
    private StringBuilder output = new StringBuilder (String.Empty);
    private string NewLine = Environment.NewLine;

    public List <string> Replace 
    {
      set
      {
        replace = value;
        UnescapeReplaceStrings ();
      }
    }
    public string Output {get {return output.ToString ();}}


    // Methods

    public void ClearOutput ()
    {
      output.Clear ();
    }


    public void SearchAndLog ()
    {
      if (Input == null || Search == null || replace == null)
        return; // exit if required strings do not exist.
      int max = Math.Min (Search.Count, replace.Count);
      Regex r;
      for (int i = 0; i < max; i++)
      {
        try
        {
          r = new Regex (Search [i]);
          MatchCollection matches = r.Matches (Input);
          foreach (Match m in matches)
          {
            output.Append (m.Result (replace [i]));
          }
        }
        catch (ArgumentException ex)
        {
          MessageBox.Show ("Error parsing regex: " +
                           Environment.NewLine + ex.Message);
          return;
        }
      }
    }


    public void SearchAndLog (List <string> fileNames, string path)
    {
      string newSource = null;
      foreach (string fileName in fileNames)
      {
        try
        {
          newSource = System.IO.File.ReadAllText (path + fileName);
          if (newSource != null)
          {
            Input = newSource;
            SearchAndLog ();
          }
        }
        catch
        {
          // do error handling here.
        }
      }
    }


    public void SearchAndReplace ()
    {
      if (Input == null || Search == null || replace == null)
        return; // exit if required strings do not exist.
      int max = Math.Min (Search.Count, replace.Count);
      Regex r;
      string temp = Input;
      for (int i = 0; i < max; i++)
      {
        try
        {
          r = new Regex (Search [i]);
          temp = r.Replace (temp, replace [i]);
        }
        catch (ArgumentException ex)
        {
          MessageBox.Show ("Error parsing regex: " +
                           Environment.NewLine + ex.Message);
          return;
        }
      }
      output = new StringBuilder (temp);
    }


    public void SearchAndReplace (List <string> fileNames, string path)
    {
      string newSource = null;
      foreach (string fileName in fileNames)
      {
        try
        {
          newSource = System.IO.File.ReadAllText (path + fileName);
          if (newSource != null)
          {
            Input = newSource;
            SearchAndReplace ();
          }
        }
        catch
        {
          // do error handling here.
        }
      }
    }


    private void UnescapeReplaceStrings ()
    {
      Regex newline = new Regex ("\\\\n");
      Regex tab = new Regex ("\\\\t");
      Regex backslash = new Regex ("\\\\\\\\");
      string temp;

      for (int i = 0; i < replace.Count; i++)
      {
        temp = newline.Replace (replace [i], NewLine);
        temp = tab.Replace (temp, "\t");
        replace [i] = backslash.Replace (temp, "\\");
      }
    }
  }


//========================================================================================
// class Program
//========================================================================================


  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main ()
    {
      Application.EnableVisualStyles ();
      Application.SetCompatibleTextRenderingDefault (false);
      Application.Run (new Form1 ());
    }
  }
}
