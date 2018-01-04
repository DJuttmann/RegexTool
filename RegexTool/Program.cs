using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTool
{
  class RegexTool
  {
    public string Input = null;
    public string Search = null;
    public string Replace = null;
    private StringBuilder output = new StringBuilder (String.Empty);
    public string Output {get {return output.ToString ();}}


    public void ClearOutput ()
    {
      output.Clear ();
    }


    public void SearchAndLog ()
    {
      if (Input == null || Search == null || Replace == null)
        return; // exit if required strings do not exist.
      Regex r = new Regex (Search);
      MatchCollection matches = r.Matches (Input);
      foreach (Match m in matches)
      {
        output.Append (m.Result (Replace));
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
      if (Input == null || Search == null || Replace == null)
        return; // exit if required strings do not exist.
      Regex r = new Regex (Search);
      output = new StringBuilder (r.Replace (Input, Replace));
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
  }



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
