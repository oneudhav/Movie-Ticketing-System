Imports System.Data.OleDb
Public Class moviereg
    Dim constring As String
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"





    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Label8.Click

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sqlstring As String = "select * from movie1"
        Dim st As String
        Dim myconnection As New OleDbConnection(myConnString)

        Dim cmd As New OleDbCommand(sqlstring, myconnection)
        cmd.CommandType = CommandType.Text

        myconnection.ConnectionString = myConnString


        myconnection.Open()
        Dim readers As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While readers.Read

            st = readers("stime").ToString
        End While
        If ComboBox1.Text = st Then
            MsgBox("Already Booked")
        Else
            Dim mycommand As New OleDbCommand("Insert INTO movie1(mname,stime,dname,trate) VALUES (?,?,?,?)", myconnection)
            mycommand.Parameters.AddWithValue("@mname", TextBox2.Text)
            mycommand.Parameters.AddWithValue("@stime", ComboBox1.Text)
            mycommand.Parameters.AddWithValue("@dname", TextBox1.Text)
            mycommand.Parameters.AddWithValue("@trate", TextBox4.Text)


            Try
                mycommand.ExecuteNonQuery()
                MessageBox.Show("Saved")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox4.Text = ""
                ComboBox1.Text = ""

                myconnection.Close()

            Catch ex As Exception
                MessageBox.Show("Movie is Same Enter New One")
            End Try
        End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("UPDATE movie1 SET mname=@mname,stime=@stime,dname =@dname,trate=@trate WHERE stime=@stime", myconnection)
        mycommand.Parameters.AddWithValue("@mname", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@stime", ComboBox2.Text)
        mycommand.Parameters.AddWithValue("@dname", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@trate", TextBox4.Text)
        Try
            mycommand.ExecuteNonQuery()
            MessageBox.Show("Updated")
        Catch ex As Exception
            MessageBox.Show("Not Updated,Fill the items")

            myconnection.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListView1.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView1.SelectedItems
                'Select each of the selected items
                ListView1.Items.Remove(i)

                'from database
                Dim myconnection As New OleDbConnection(myConnString)
                myconnection.Open()
                Dim mycommand As New OleDbCommand("DELETE FROM  movie1 WHERE mname=@mname", myconnection)
                mycommand.Parameters.AddWithValue("@mname", i.Text)
                mycommand.ExecuteNonQuery()
                Dim mycommand1 As New OleDbCommand("DELETE FROM  cust WHERE mname=@mname", myconnection)
                mycommand1.Parameters.AddWithValue("@mname", i.Text)
                mycommand1.ExecuteNonQuery()
                myconnection.Close()
            Next
        Else
            MessageBox.Show("Please Select an Item to delete")
        End If


    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ListView2.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM movie1 Where mname LIKE @mname", myconnection)
        mycommand.Parameters.AddWithValue("@mname", TextBox3.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetInt32(3))

            ListView2.Items.Add(newlistviewitem)


        End While


        myconnection.Close()

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM movie1", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView1.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetInt32(3))

            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        moviedetails.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ListView2.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM movie1 WHERE stime LIKE @stime", myconnection)
        mycommand.Parameters.AddWithValue("@stime", ComboBox2.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView2.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetString(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetInt32(3))

            ListView2.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub moviereg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class