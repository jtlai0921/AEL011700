Public Class MyLine
    Inherits TextLine
    ' 建構子
    Public Sub New()
        MyBase.New()
    End Sub
    ' 新增屬性
    ReadOnly Property Length() As Long
        Get
            Return Len(MyBase.Line)
        End Get
    End Property
    ' 新增方法
    Public Function InStr(ByVal str As String) As Integer
        Dim arrWords() As String = Split(MyBase.Line, " ")
        Dim i As Integer
        For i = 0 To UBound(arrWords)
            If arrWords(i) = str Then
                Exit For
            End If
        Next i
        If i < UBound(arrWords) Then
            Return i + 1
        End If
        Return -1
    End Function
    ' 覆寫方法
    Public NotOverridable Overrides Function GetText() As String
        Return MyBase.Line
    End Function
End Class

