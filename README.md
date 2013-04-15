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

strippedStr = cleanup.StripQuestionMark(unstripped)
```

To strip off " (but not if it has matching ending ") ocurring at the begining of the search string


```vb
'For example passing "somestring will return somestring 

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.StripQuotes(unstripped)
```

To strip off special characters such as ). or . or , ocurring at the begining of the search string

```vb
'For example passing ).somestring or .somestring or ,somestring will return somestring 

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.StripSpecialCharAtBegining(unstripped)
```

To replace & with %26 in the search string

```vb
'For example passing &somestring will return %26somestring.  This is especially useful when passing the search string as a query string in an URL.   

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.ReplaceAmbersand(unstripped)
```

Some times the user may just enter an entire citation and try to search.  But this will not return the expected result and may cause the page to break.  To strip off just the title from the citation

```vb
'For example passing 
'Harlow, H. F. (1983). Fundamentals for preparing psychology 'journal articles. Journal of Comparative and Physiological 'Psychology, 55, 893-896.

'will return 'Fundamentals for preparing psychology journal 'articles'

Dim unstripped As string ' this is the raw search string
Dim strippedStr As string

strippedStr = cleanup.CleanUpCitationSearch(unstripped)
```




