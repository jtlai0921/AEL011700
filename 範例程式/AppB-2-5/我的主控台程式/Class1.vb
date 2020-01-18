Public Class MyName
    Private FirstName, LastName As String
    Public Sub New(ByVal f As String, ByVal l As String)
        FirstName = f : LastName = l
    End Sub
    Public Function GetName() As String
        Return "姓名： " & LastName & FirstName
    End Function
End Class

Partial Class MyName
    Public Function GetFirstName() As String
        Return "名： " & FirstName
    End Function
End Class

