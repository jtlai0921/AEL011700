Public Class TextLine
    Public Line As String
    ' 建構子(1)
    Public Sub New()
        Line = ""
    End Sub
    ' 建構子(2)
    Public Sub New(ByVal text As String)
        Line = text
    End Sub
    ' 物件方法
    Public Function GetWord() As String
        Dim arrWords() As String = Split(Line, " ")
        Return (arrWords(0))
    End Function
    ' 可覆寫的方法
    Public Overridable Function GetText() As String
        Return LCase(Line)
    End Function
End Class

