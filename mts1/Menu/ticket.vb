Imports System.Data.OleDb
Public Class ticket
    Dim myconnstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Insert INTO cust(sno,cname,cno,cost,mname,dname,showtime) VALUES (?,?,?,?,?,?,?)", myconnection)
        mycommand.Parameters.AddWithValue("@sno", TextBox6.Text)
        mycommand.Parameters.AddWithValue("@cname", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@cno", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@cost", TextBox5.Text)
        mycommand.Parameters.AddWithValue("@mname", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@dname", TextBox4.Text)
        mycommand.Parameters.AddWithValue("@showtime", TextBox7.Text)


        Try
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Saved")

            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""


            myconnection.Close()

        Catch ex As Exception
            MessageBox.Show("Unsaved")
        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Insert INTO cust(sno,cname,cno,cost,mname,dname,showtime) VALUES (?,?,?,?,?,?,?)", myconnection)
        mycommand.Parameters.AddWithValue("@sno", TextBox6.Text)
        mycommand.Parameters.AddWithValue("@cname", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@cno", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@cost", TextBox5.Text)
        mycommand.Parameters.AddWithValue("@mname", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@dname", TextBox4.Text)
        mycommand.Parameters.AddWithValue("@showtime", TextBox7.Text)


        Try
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Saved")
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""


            myconnection.Close()

        Catch ex As Exception
            MessageBox.Show("Unsaved")
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        seatbooking.Show()
        Me.Hide()
    End Sub
End Class