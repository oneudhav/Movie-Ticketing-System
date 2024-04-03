Imports System.Data.OleDb
Public Class search
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM cust", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        ListView1.Items.Clear()
        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            newlistviewitem.SubItems.Add(myreader.GetString(7))

            ListView1.Items.Add(newlistviewitem)

        End While


        myconnection.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM cust Where mname LIKE @mname", myconnection)
        mycommand.Parameters.AddWithValue("@mname", TextBox1.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            newlistviewitem.SubItems.Add(myreader.GetString(7))


            ListView1.Items.Add(newlistviewitem)


        End While


        myconnection.Close()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM cust Where tno  LIKE @tno", myconnection)
        mycommand.Parameters.AddWithValue("@tno", TextBox2.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            newlistviewitem.SubItems.Add(myreader.GetString(7))


            ListView1.Items.Add(newlistviewitem)


        End While


        myconnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class