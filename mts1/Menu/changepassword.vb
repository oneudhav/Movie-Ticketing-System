Imports System.Data.OleDb
Public Class changepassword
    Public con As New OleDbConnection
    Dim cmd1 As New OleDbCommand
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"
        con.Open()
        Dim sql As String
        sql = "UPDATE [login] SET [password]='" & TextBox5.Text & "' where [password]='" & TextBox4.Text & "'"
        Dim cmd2 As OleDbCommand = New OleDbCommand(sql, con)
        Try
            cmd2.ExecuteNonQuery()
            MsgBox("Password Change Sucessfully", MsgBoxStyle.Exclamation, "changed")
            login.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Incorrect Old Password", MsgBoxStyle.Exclamation, "Warning")
            Me.Show()

        End Try
    End Sub

    Private Sub changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class