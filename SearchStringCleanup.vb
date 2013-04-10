'==========================================================================================
'Asset Name: Search-String-Cleanup
'Purpose: Asset code that cleans up the search string before passing it on to (any database for searching) xerxes at www.library.fullerton.edu.
'Created by: Latha Ramnath lramnath@fullerton.edu (on behalf of the Pollak LIbrary)
'Created: 4/10/13
'Last Modified:
'Code Reuse: Must attribute Latha Ramnath (lramnath@fullerton.edu) in your actual code when using it.
'=========================================================================================== 
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions

Public Class SearchStringCleanup

    ' strips question mark from the search string
    Function StripQuestionMark(ByVal strSearch As String) As String
        Dim strStriped As String = strSearch

        If strSearch.IndexOf("?") >= 0 Then
            strStriped = Replace(strSearch, "?", "")
        End If

        Return strStriped
    End Function

    ' strip " (but not if it has an ending ")
    Function StripQuotes(ByVal strSearch As String) As String
        Dim strStriped As String = strSearch

        If strSearch.Contains("""") Then

            If Not Regex.Matches(strSearch, """").Count > 1 Then
                strStriped = Replace(strSearch, """", "")
            End If
        End If

        Return strStriped
    End Function

    Function StripSpecialCharAtBeging(ByVal strSearch As String) As String
        Dim strStriped As String = strSearch

        ' if search string begins with ). strip it
        If strSearch.Contains(").") Then
            Dim strIndex1 As Integer
            Dim strIndex2 As Integer
            strIndex1 = strSearch.IndexOf(")")
            strIndex2 = strSearch.IndexOf(".")

            If strIndex1 = 0 And strIndex2 = 1 Then
                strStriped = strSearch.Substring(2)
            End If
        End If

        ' if search string begins with . strip it
        If strSearch.Contains(".") Then
            Dim strIndex1 As Integer
            strIndex1 = strSearch.IndexOf(".")

            If strIndex1 = 0 Then
                strStriped = strSearch.Substring(1)
            End If
        End If

        ' if search string begins with , strip it
        If strSearch.Contains(",") Then
            Dim strIndex1 As Integer
            strIndex1 = strSearch.IndexOf(",")

            If strIndex1 = 0 Then
                strStriped = strSearch.Substring(1)
            End If
        End If

        Return strStriped
    End Function

    ' replace & with %26
    Function ReplaceAmbersand(ByVal strSearch As String) As String
        Dim strStriped As String = strSearch

        If strSearch.Contains("&") Then
            strStriped = Replace(strSearch, "&", "%26")
        End If

        Return strStriped
    End Function

    ' cleans up citation - returns only title
    Function CleanUpCitationSearch(ByVal strSearch As String) As String
        Dim strStriped As String = strSearch
        Dim matchValue As String = "\(\d{4}\)\." ' eg: (1997).

        If Regex.IsMatch(strSearch, matchValue) Then

            Dim arrStr() As String = Regex.Split(strSearch, matchValue)

            strStriped = arrStr(1) ' this removes everything before the pattern

            ' we still have to strip everything after the first . in the string
            If strStriped.Contains(".") Then
                Dim strIndex1 As Integer
                strIndex1 = strSearch.IndexOf(".")

                Dim arrStr1() As String = strStriped.Split(".")
                strStriped = arrStr1(0) ' just the title

            End If

        End If

        Return strStriped
    End Function

End Class
