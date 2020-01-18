Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 宣告Student類別的物件變數
        Dim joe, jane, jason As Student
        ' 建立物件實例
        joe = New Student("陳會安")
        jane = New Student("江小魚")
        jason = New Student("陳允傑")
        ' 呼叫物件方法
        txtOutput.Text = "姓名: " & joe.GetStudentName() & vbNewLine
        txtOutput.Text &= "姓名: " & jane.GetStudentName() & vbNewLine
        txtOutput.Text &= "姓名: " & jason.GetStudentName() & vbNewLine
        txtOutput.Text &= "學生數: " & Student.NumOfStudents()
        txtOutput.SelectionStart = 0
    End Sub
End Class
