Public Class MyTime
    Private intHour As Integer
    Private intMinute As Integer
    Private intSecond As Integer
    ' 物件屬性
    Property Hour() As Integer
        Get
            Return intHour
        End Get
        Set(ByVal Value As Integer)
            intHour = Value
        End Set
    End Property
    Property Minute() As Integer
        Get
            Return intMinute
        End Get
        Set(ByVal Value As Integer)
            intMinute = Value
        End Set
    End Property
    Property Second() As Integer
        Get
            Return intSecond
        End Get
        Set(ByVal Value As Integer)
            intSecond = Value
        End Set
    End Property
    ' 物件方法: 取得時間字串
    Public Function GetTime() As String
        Dim str As String
        str = intHour & ":" & intMinute & ":" & intSecond
        Return str
    End Function
    ' 物件方法: 設定時間
    Public Sub SetTime(ByVal h As Integer, ByVal m As Integer, ByVal s As Integer)
        intHour = h : intMinute = m : intSecond = s
    End Sub
End Class

