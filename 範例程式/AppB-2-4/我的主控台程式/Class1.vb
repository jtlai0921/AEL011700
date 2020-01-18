Public Class Student
    Private Name As String
    Private Shared Count As Integer
    ' 建構子
    Public Sub New(ByVal Name As String)
        Me.Name = Name
        Count += 1
    End Sub
    ' 成員方法
    Public Function GetStudentName() As String
        Return Name
    End Function
    ' 靜態成員方法，也稱為類別方法
    Public Shared Function NumOfStudents() As Integer
        Return Count
    End Function
End Class


