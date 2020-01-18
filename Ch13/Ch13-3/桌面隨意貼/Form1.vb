Imports System.IO

Public Class Form1

    Dim path As String = "NotePad.txt"

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' 開啟二進位檔案
        Dim fs As FileStream = New FileStream(path,
                            FileMode.OpenOrCreate)
        ' 從二進位檔案讀取字串
        Dim br As BinaryReader = New BinaryReader(fs)
        txtOutput.Text = br.ReadString()
        br.Close()   ' 關閉BinaryReader
        fs.Close()   ' 關閉FileStream
        txtOutput.SelectionStart = 0
        txtOutput.SelectionLength = 0
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' 開啟二進位檔案
        Dim fs As FileStream = New FileStream(path,
                             FileMode.OpenOrCreate)
        ' 將字串資料寫入二進位檔
        Dim bw As BinaryWriter = New BinaryWriter(fs)
        bw.Write(txtOutput.Text)
        bw.Flush()
        bw.Close()   ' 關閉BinaryWriter
        fs.Close()   ' 關閉FileStream
    End Sub
End Class
