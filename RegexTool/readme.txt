﻿﻿==========================================================================================
RegexTool by Daan Juttmann
Created: 2017-11-08
License: GNU General Public License 3.0 (https://www.gnu.org/licenses/gpl-3.0.en.html).
==========================================================================================

-- DESCRIPTION --
A quick and dirty regex tool for logging and replacing text in multiple files.

-- USAGE --
- At the top select whether the 'Input' text box is the input text, or a list of files.
- Either load your file(s) by selecting the load button, or paste the text/file list in
  the input box. Note that when 'File list' is selected, you may load multiple files at
  once, or add files multiple times: file names are appended at the bottom of the list.
- Enter one or more regex patterns in the 'Search' box, one regex per line, empty lines
  are ignored.
- Enter one or more replace strings in the 'Replace' box, one string per line. You can
  use \n for newlines within the string, as wel as \t and \\. The first string replaces
  the first search, the second replaces the second search, etc.
- Press 'Log' if you wish to search for all occurrences and log the replacement strings
  in the output field. Press 'Replace' for substituting them in the input text.

==========================================================================================