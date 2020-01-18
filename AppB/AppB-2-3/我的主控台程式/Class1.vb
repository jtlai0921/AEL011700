Public Class MyTime
    Public Hour As Integer
    Public Minute As Integer
    Public Second As Integer
    ' 建構子(1)
    Public Sub New()
        Hour = 0 : Minute = 0 : Second = 0
    End Sub
    ' 建構子(2)
    Public Sub New(ByVal h As Integer,
                   ByVal m As Integer)
        Hour = h : Minute = m : Second = 0
    End Sub
    ' 建構子(3)
    Public Sub New(ByVal h As Integer,
              ByVal m As Integer, ByVal s As Integer)
        Hour = h : Minute = m : Second = s
    End Sub
    ' 物件方法: 取得時間字串
    Public Function GetTime() As String
        Dim str As String
        str = Hour & ":" & Minute & ":" & Second
        Return str
    End Function
End Class

