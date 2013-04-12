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

To strip off ? from the begining of the search string

```vb
'For example passing '?somestring' will return 'somestring'

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.StripQuestionMark(unstripped )
```

To strip off " (but not if it has an ending ")

```vb
'For example passing "somestring will return somestring 

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.StripQuotes(unstripped )
```

To strip off special characters such as ). or . or , ocurring at the begining of the search string

```vb
'For example passing ).somestring or .somestring or ,somestring will return somestring 

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.StripSpecialCharAtBegining(unstripped )
```





