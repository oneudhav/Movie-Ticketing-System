Imports System.Data.OleDb
Public Class login
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pass
        Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"
        Dim sqlstring As String = "select * from login"
        Dim con As New OleDbConnection

        Dim cmd As New OleDb.OleDbCommand(sqlstring, con)
        cmd.CommandType = CommandType.Text
        con.ConnectionString = constring
        con.Open()
        Dim readers As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While readers.Read
            user = readers("username").ToString
            pass = readers("password").ToString
            If (TextBox1.Text = user And TextBox2.Text = pass) Then
                menu1.Show()
                Me.Hide()
                Return
            Else
                Continue While
            End If
        End While
        MsgBox("Incorrect Username or Password.Please Enter Correct Username or Password", MsgBoxStyle.Exclamation, "Warning")
        Me.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If TextBox2.UseSystemPasswordChar Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        changepassword.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class