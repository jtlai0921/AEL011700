Public Class MyTime
    Public Hour As Integer
    Public Minute As Integer
    Public Second As Integer
    ' 物件方法: 取得時間字串
    Public Function GetTime() As String
        Dim str As String
        str = Hour & ":" & Minute & ":" & Second
        Return str
    End Function
    ' 物件方法: 設定時間(1)
    Public Overloads Sub SetTime(ByVal h As Integer, ByVal m As Integer, ByVal s As Integer)
        Hour = h : Minute = m : Second = s
    End Sub
    ' 物件方法: 設定時間(2)
    Public Overloads Sub SetTime(ByVal h As Integer, ByVal m As Integer)
        Hour = h : Minute = m : Second = 0
    End Sub
End Class

