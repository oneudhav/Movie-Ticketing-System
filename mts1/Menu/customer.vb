Imports System.Data.OleDb
Public Class bookedticket
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"
    Private Sub bookedticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (ListView1.SelectedItems.Count > 0) Then
            For Each i As ListViewItem In ListView1.SelectedItems
                'Select each of the selected items
                ListView1.Items.Remove(i)

                'from database
                Dim myconnection As New OleDbConnection(myConnString)
                myconnection.Open()
                Dim mycommand As New OleDbCommand("DELETE FROM  cust WHERE tno=@tno", myconnection)
                mycommand.Parameters.AddWithValue("@tno", i.Text)
                mycommand.ExecuteNonQuery()
                myconnection.Close()
            Next
        Else
            MessageBox.Show("Please Select an Item to delete")
        End If

    End Sub
End Class