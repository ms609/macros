Sub Italicize()

' Italicize Macro
'
'
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    Selection.Find.Replacement.Font.Italic = True
    With Selection.Find
        .Text = "~<(*?)>~"
        .Replacement.Text = "\1"
        .Forward = True
        .Wrap = wdFindContinue
        .Format = True
        .MatchCase = False
        .MatchWholeWord = False
        .MatchAllWordForms = False
        .MatchSoundsLike = False
        .MatchWildcards = True
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
End Sub
Sub NercReferences()
'
' NercReferences Macro
' Format references for NERC
'
    Selection.Find.ClearFormatting
    Selection.Find.Replacement.ClearFormatting
    With Selection.Find
        .Text = "^p"
        .Replacement.Text = "  "
        .Forward = True
        .Wrap = False
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    With Selection.Find
        .Text = "^t"
        .Replacement.Text = " "
        .Forward = True
        .Wrap = False
        .Format = False
        .MatchCase = False
        .MatchWholeWord = False
        .MatchWildcards = False
        .MatchSoundsLike = False
        .MatchAllWordForms = False
    End With
    Selection.Find.Execute Replace:=wdReplaceAll
    Selection.Style = ActiveDocument.Styles("References")
End Sub
