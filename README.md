Search-String-Cleanup
=====================

Basic-Search-Cleanup is a vb class providing methods to cleans up a given string.   The class provides methods to - Returns only title when the search string contains a whole citation, Replaces &amp; with “%26”, strip ?,  strip " but not if the string has an ending ", strip special chars such as ). or .  or ,  if they appear at the beginning of the string.

### Usage

Include the class:

```vb
	Imports SearchStringCleanup

```

Instantiate the class:

```vb
     Dim cleanup As New SearchStringCleanup

```