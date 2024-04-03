Imports System.Data.OleDb

Public Class seat
    Dim myConnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"

    Private Sub Button3_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As New OleDbConnection(myConnString)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM movie1", myconnection)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        bookedticket.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)
     








    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        Dim myconnection As New OleDbConnection(myConnString)
      

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button1.Click
        ticket.TextBox3.Text = TextBox13.Text
        ticket.TextBox4.Text = TextBox14.Text
        ticket.TextBox7.Text = TextBox11.Text
        ticket.TextBox5.Text = TextBox15.Text
        If (ListView2.SelectedItems.Count > 0) Then
            Dim bookin As New seatbooking
            bookin.showname = ListView2.SelectedItems(0).SubItems(0).Text
            bookin.ShowDialog()

        Else
            MsgBox("please Select a show")
        End If
        Me.Close()


    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

   
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub

    Private Sub ListView2_MouseClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseClick
        Dim mname As String = ListView2.SelectedItems(0).SubItems(0).Text
        Dim stime As String = ListView2.SelectedItems(0).SubItems(1).Text
        Dim dname As String = ListView2.SelectedItems(0).SubItems(2).Text
        Dim trate As String = ListView2.SelectedItems(0).SubItems(3).Text
        TextBox13.Text = mname
        TextBox14.Text = dname
        TextBox11.Text = stime
        TextBox15.Text = trate



    End Sub
End Class


