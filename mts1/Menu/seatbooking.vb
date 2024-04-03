Imports System.Data.OleDb
Public Class seatbooking
    Public showname As String
    Dim provider As String
    Dim datafile As String
    Dim connstring As String
    Dim statu As String
    Dim mn As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox75.Click, PictureBox73.Click

    End Sub
    Private Sub seatbooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\College\full final wala\movie.accdb"

        Dim sqlstring As String = "select * from cust  where mname='" & showname & "'"

        Dim con As New OleDb.OleDbConnection

        Dim cmd As New OleDb.OleDbCommand(sqlstring, con)
        cmd.CommandType = CommandType.Text
        con.ConnectionString = constring
        con.Open()
        Dim readers As OleDb.OleDbDataReader = cmd.ExecuteReader()
        While readers.Read
            statu = readers("sno").ToString
            ' mn = readers("mname").ToString


            If statu = "A1" Then
                a1.BackColor = Color.Red
            ElseIf statu = "A2" Then
                a2.BackColor = Color.Red
            ElseIf statu = "A3" Then
                a3.BackColor = Color.Red
            ElseIf statu = "A4" Then
                a4.BackColor = Color.Red
            ElseIf statu = "A5" Then
                a5.BackColor = Color.Red
            ElseIf statu = "A6" Then
                a6.BackColor = Color.Red
            ElseIf statu = "A7" Then
                a7.BackColor = Color.Red
            ElseIf statu = "A8" Then
                a8.BackColor = Color.Red
            ElseIf statu = "A9" Then
                a9.BackColor = Color.Red
            ElseIf statu = "A10" Then
                a10.BackColor = Color.Red
            ElseIf statu = "A11" Then
                a11.BackColor = Color.Red
            ElseIf statu = "A12" Then
                a12.BackColor = Color.Red
            ElseIf statu = "A13" Then
                a13.BackColor = Color.Red
            ElseIf statu = "A14" Then
                a14.BackColor = Color.Red
            ElseIf statu = "A15" Then
                a15.BackColor = Color.Red
            ElseIf statu = "A16" Then
                a16.BackColor = Color.Red

            ElseIf statu = "B1" Then
                b1.BackColor = Color.Red
            ElseIf statu = "B2" Then
                b2.BackColor = Color.Red
            ElseIf statu = "B3" Then
                b3.BackColor = Color.Red
            ElseIf statu = "B4" Then
                b4.BackColor = Color.Red
            ElseIf statu = "B5" Then
                b5.BackColor = Color.Red
            ElseIf statu = "B6" Then
                b6.BackColor = Color.Red
            ElseIf statu = "B7" Then
                b7.BackColor = Color.Red
            ElseIf statu = "B8" Then
                b8.BackColor = Color.Red
            ElseIf statu = "B9" Then
                b9.BackColor = Color.Red
            ElseIf statu = "B10" Then
                b10.BackColor = Color.Red
            ElseIf statu = "B11" Then
                b11.BackColor = Color.Red
            ElseIf statu = "B12" Then
                b12.BackColor = Color.Red
            ElseIf statu = "B13" Then
                b13.BackColor = Color.Red
            ElseIf statu = "B14" Then
                b14.BackColor = Color.Red
            ElseIf statu = "B15" Then
                b15.BackColor = Color.Red
            ElseIf statu = "B16" Then
                b16.BackColor = Color.Red

            ElseIf statu = "C1" Then
                c1.BackColor = Color.Red
            ElseIf statu = "C2" Then
                c2.BackColor = Color.Red
            ElseIf statu = "C3" Then
                c3.BackColor = Color.Red
            ElseIf statu = "C4" Then
                c4.BackColor = Color.Red
            ElseIf statu = "C5" Then
                c5.BackColor = Color.Red
            ElseIf statu = "C6" Then
                c6.BackColor = Color.Red
            ElseIf statu = "C7" Then
                c7.BackColor = Color.Red
            ElseIf statu = "C8" Then
                c8.BackColor = Color.Red
            ElseIf statu = "C9" Then
                c9.BackColor = Color.Red
            ElseIf statu = "C10" Then
                c10.BackColor = Color.Red
            ElseIf statu = "C11" Then
                c11.BackColor = Color.Red
            ElseIf statu = "C12" Then
                c12.BackColor = Color.Red
            ElseIf statu = "C13" Then
                c13.BackColor = Color.Red
            ElseIf statu = "C14" Then
                c14.BackColor = Color.Red
            ElseIf statu = "C15" Then
                c15.BackColor = Color.Red
            ElseIf statu = "C16" Then
                c16.BackColor = Color.Red

            ElseIf statu = "D1" Then
                d1.BackColor = Color.Red
            ElseIf statu = "D2" Then
                d2.BackColor = Color.Red
            ElseIf statu = "D3" Then
                d3.BackColor = Color.Red
            ElseIf statu = "D4" Then
                d4.BackColor = Color.Red
            ElseIf statu = "D5" Then
                d5.BackColor = Color.Red
            ElseIf statu = "D6" Then
                d6.BackColor = Color.Red
            ElseIf statu = "D7" Then
                d7.BackColor = Color.Red
            ElseIf statu = "D8" Then
                d8.BackColor = Color.Red
            ElseIf statu = "D9" Then
                d9.BackColor = Color.Red
            ElseIf statu = "D10" Then
                d10.BackColor = Color.Red
            ElseIf statu = "D11" Then
                d11.BackColor = Color.Red
            ElseIf statu = "D12" Then
                d12.BackColor = Color.Red
            ElseIf statu = "D13" Then
                d13.BackColor = Color.Red
            ElseIf statu = "D14" Then
                d14.BackColor = Color.Red
            ElseIf statu = "D15" Then
                d15.BackColor = Color.Red
            ElseIf statu = "D16" Then
                d16.BackColor = Color.Red

            ElseIf statu = "E1" Then
                e1.BackColor = Color.Red
            ElseIf statu = "E2" Then
                e2.BackColor = Color.Red
            ElseIf statu = "E3" Then
                e3.BackColor = Color.Red
            ElseIf statu = "E4" Then
                e4.BackColor = Color.Red
            ElseIf statu = "E5" Then
                e5.BackColor = Color.Red
            ElseIf statu = "E6" Then
                e6.BackColor = Color.Red
            ElseIf statu = "E7" Then
                e7.BackColor = Color.Red
            ElseIf statu = "E8" Then
                e8.BackColor = Color.Red
            ElseIf statu = "E9" Then
                e9.BackColor = Color.Red
            ElseIf statu = "E10" Then
                e10.BackColor = Color.Red
            ElseIf statu = "E11" Then
                e11.BackColor = Color.Red
            ElseIf statu = "E12" Then
                e12.BackColor = Color.Red
            ElseIf statu = "E13" Then
                e13.BackColor = Color.Red
            ElseIf statu = "E14" Then
                e14.BackColor = Color.Red
            ElseIf statu = "E15" Then
                e15.BackColor = Color.Red
            ElseIf statu = "E16" Then
                e16.BackColor = Color.Red


            ElseIf statu = "F1" Then
                f1.BackColor = Color.Red
            ElseIf statu = "F2" Then
                f2.BackColor = Color.Red
            ElseIf statu = "F3" Then
                f3.BackColor = Color.Red
            ElseIf statu = "F4" Then
                f4.BackColor = Color.Red
            ElseIf statu = "F5" Then
                f5.BackColor = Color.Red
            ElseIf statu = "F6" Then
                f6.BackColor = Color.Red
            ElseIf statu = "F7" Then
                f7.BackColor = Color.Red
            ElseIf statu = "F8" Then
                f8.BackColor = Color.Red
            ElseIf statu = "F9" Then
                f9.BackColor = Color.Red
            ElseIf statu = "F10" Then
                f10.BackColor = Color.Red
            ElseIf statu = "F11" Then
                f11.BackColor = Color.Red
            ElseIf statu = "F12" Then
                f12.BackColor = Color.Red
            ElseIf statu = "F13" Then
                f13.BackColor = Color.Red
            ElseIf statu = "F14" Then
                f14.BackColor = Color.Red
            ElseIf statu = "F15" Then
                f15.BackColor = Color.Red
            ElseIf statu = "F16" Then
                f16.BackColor = Color.Red

            ElseIf statu = "G1" Then
                g1.BackColor = Color.Red
            ElseIf statu = "G2" Then
                g2.BackColor = Color.Red
            ElseIf statu = "G3" Then
                g3.BackColor = Color.Red
            ElseIf statu = "G4" Then
                g4.BackColor = Color.Red
            ElseIf statu = "G5" Then
                g5.BackColor = Color.Red
            ElseIf statu = "G6" Then
                g6.BackColor = Color.Red
            ElseIf statu = "G7" Then
                g7.BackColor = Color.Red
            ElseIf statu = "G8" Then
                g8.BackColor = Color.Red
            ElseIf statu = "G9" Then
                g9.BackColor = Color.Red
            ElseIf statu = "G10" Then
                g10.BackColor = Color.Red
            ElseIf statu = "G11" Then
                g11.BackColor = Color.Red
            ElseIf statu = "G12" Then
                g12.BackColor = Color.Red
            ElseIf statu = "G13" Then
                g13.BackColor = Color.Red
            ElseIf statu = "G14" Then
                g14.BackColor = Color.Red
            ElseIf statu = "G15" Then
                g15.BackColor = Color.Red
            ElseIf statu = "G16" Then
                g16.BackColor = Color.Red

            ElseIf statu = "H1" Then
                h1.BackColor = Color.Red
            ElseIf statu = "H2" Then
                h2.BackColor = Color.Red
            ElseIf statu = "H3" Then
                h3.BackColor = Color.Red
            ElseIf statu = "H4" Then
                h4.BackColor = Color.Red
            ElseIf statu = "H5" Then
                h5.BackColor = Color.Red
            ElseIf statu = "H6" Then
                h6.BackColor = Color.Red
            ElseIf statu = "H7" Then
                h7.BackColor = Color.Red
            ElseIf statu = "H8" Then
                h8.BackColor = Color.Red
            ElseIf statu = "H9" Then
                h9.BackColor = Color.Red
            ElseIf statu = "H10" Then
                h10.BackColor = Color.Red
            ElseIf statu = "H11" Then
                h11.BackColor = Color.Red
            ElseIf statu = "H12" Then
                h12.BackColor = Color.Red
            ElseIf statu = "H13" Then
                h13.BackColor = Color.Red
            ElseIf statu = "H14" Then
                h14.BackColor = Color.Red
            ElseIf statu = "H15" Then
                h15.BackColor = Color.Red
            ElseIf statu = "H16" Then
                h16.BackColor = Color.Red
            Else
                Continue While


            End If

        End While
        myconnection.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ticket.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        seat.Show()
        Me.Hide()
    End Sub

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        If a1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a1.Text
            Me.Close()
        End If
    End Sub

    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        If a2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a2.Text
            Me.Close()
        End If
    End Sub

    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        If a3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a3.Text
            Me.Close()
        End If
        Me.Close()
    End Sub

    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        If a4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a4.Text
            Me.Close()
        End If
    End Sub

    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        If a5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a5.Text
            Me.Close()
        End If
    End Sub

    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        If a6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a6.Text
            Me.Close()
        End If
    End Sub

    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        If a7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a7.Text
            Me.Close()
        End If
    End Sub

    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        If a8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a8.Text
            Me.Close()
        End If
    End Sub

    Private Sub a9_Click(sender As Object, e As EventArgs) Handles a9.Click
        If a9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a9.Text
            Me.Close()
        End If
    End Sub

    Private Sub a10_Click(sender As Object, e As EventArgs) Handles a10.Click
        If a10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a10.Text
            Me.Close()
        End If
    End Sub

    Private Sub a11_Click(sender As Object, e As EventArgs) Handles a11.Click
        If a11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a11.Text
            Me.Close()
        End If
    End Sub

    Private Sub a12_Click(sender As Object, e As EventArgs) Handles a12.Click
        If a12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a12.Text
            Me.Close()
        End If
    End Sub

    Private Sub a13_Click(sender As Object, e As EventArgs) Handles a13.Click
        If a13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a13.Text
            Me.Close()
        End If
    End Sub

    Private Sub a14_Click(sender As Object, e As EventArgs) Handles a14.Click
        If a14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a14.Text
            Me.Close()
        End If
    End Sub

    Private Sub a15_Click(sender As Object, e As EventArgs) Handles a15.Click
        If a15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a15.Text
            Me.Close()
        End If
    End Sub

    Private Sub a16_Click(sender As Object, e As EventArgs) Handles a16.Click
        If a16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = a16.Text
            Me.Close()
        End If
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        If b1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b1.Text
            Me.Close()
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        If b2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b2.Text
            Me.Close()
        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If b3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b3.Text
            Me.Close()
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If b4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b4.Text
            Me.Close()
        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        If b5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b5.Text
            Me.Close()
        End If
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        If b6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b6.Text
            Me.Close()
        End If
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        If b7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b7.Text
            Me.Close()
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        If b8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b8.Text
            Me.Close()
        End If
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        If b9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b9.Text
            Me.Close()
        End If
    End Sub

    Private Sub b10_Click(sender As Object, e As EventArgs) Handles b10.Click
        If b10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b10.Text
            Me.Close()
        End If
    End Sub

    Private Sub b11_Click(sender As Object, e As EventArgs) Handles b11.Click
        If b11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b11.Text
            Me.Close()
        End If
    End Sub

    Private Sub b12_Click(sender As Object, e As EventArgs) Handles b12.Click
        If b12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b12.Text
            Me.Close()
        End If
    End Sub

    Private Sub b13_Click(sender As Object, e As EventArgs) Handles b13.Click
        If b13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b13.Text
            Me.Close()
        End If
    End Sub

    Private Sub b14_Click(sender As Object, e As EventArgs) Handles b14.Click
        If b14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b14.Text
            Me.Close()
        End If
    End Sub

    Private Sub b15_Click(sender As Object, e As EventArgs) Handles b15.Click
        If b15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b15.Text
            Me.Close()
        End If
    End Sub

    Private Sub b16_Click(sender As Object, e As EventArgs) Handles b16.Click
        If b16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = b16.Text
            Me.Close()
        End If
    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        If c1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c1.Text
            Me.Close()
        End If
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        If c2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c2.Text
            Me.Close()
        End If
    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click
        If c3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c3.Text
            Me.Close()
        End If
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        If c4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c4.Text
            Me.Close()
        End If
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        If c5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c5.Text
            Me.Close()
        End If
    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click
        If c6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c6.Text
            Me.Close()
        End If
    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click
        If c7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c7.Text
            Me.Close()
        End If
    End Sub

    Private Sub c8_Click(sender As Object, e As EventArgs) Handles c8.Click
        If c8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c8.Text
            Me.Close()
        End If
    End Sub

    Private Sub c9_Click(sender As Object, e As EventArgs) Handles c9.Click
        If c9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c9.Text
            Me.Close()
        End If
    End Sub

    Private Sub c10_Click(sender As Object, e As EventArgs) Handles c10.Click
        If c10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c10.Text
            Me.Close()
        End If
    End Sub

    Private Sub c11_Click(sender As Object, e As EventArgs) Handles c11.Click
        If c11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c11.Text
            Me.Close()
        End If
    End Sub

    Private Sub c12_Click(sender As Object, e As EventArgs) Handles c12.Click
        If c12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c12.Text
            Me.Close()
        End If
    End Sub

    Private Sub c13_Click(sender As Object, e As EventArgs) Handles c13.Click
        If c13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c13.Text
            Me.Close()
        End If
    End Sub

    Private Sub c14_Click(sender As Object, e As EventArgs) Handles c14.Click
        If c14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c14.Text
            Me.Close()
        End If
    End Sub

    Private Sub c15_Click(sender As Object, e As EventArgs) Handles c15.Click
        If c15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c15.Text
            Me.Close()
        End If
    End Sub

    Private Sub c16_Click(sender As Object, e As EventArgs) Handles c16.Click
        If c16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = c16.Text
            Me.Close()
        End If
    End Sub

    Private Sub d1_Click(sender As Object, e As EventArgs) Handles d1.Click
        If d1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d1.Text
            Me.Close()
        End If
    End Sub

    Private Sub d2_Click(sender As Object, e As EventArgs) Handles d2.Click
        If d2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d2.Text
            Me.Close()
        End If
    End Sub

    Private Sub d3_Click(sender As Object, e As EventArgs) Handles d3.Click
        If d3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d3.Text
            Me.Close()
        End If
    End Sub

    Private Sub d4_Click(sender As Object, e As EventArgs) Handles d4.Click
        If d4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d4.Text
            Me.Close()
        End If
    End Sub

    Private Sub d5_Click(sender As Object, e As EventArgs) Handles d5.Click
        If d5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d5.Text
            Me.Close()
        End If
    End Sub

    Private Sub d6_Click(sender As Object, e As EventArgs) Handles d6.Click
        If d6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d6.Text
            Me.Close()
        End If
    End Sub

    Private Sub d7_Click(sender As Object, e As EventArgs) Handles d7.Click
        If d7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d7.Text
            Me.Close()
        End If
    End Sub

    Private Sub d8_Click(sender As Object, e As EventArgs) Handles d8.Click
        If d8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d8.Text
            Me.Close()
        End If
    End Sub

    Private Sub d9_Click(sender As Object, e As EventArgs) Handles d9.Click
        If d9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d9.Text
            Me.Close()
        End If
    End Sub

    Private Sub d10_Click(sender As Object, e As EventArgs) Handles d10.Click
        If d10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d10.Text
            Me.Close()
        End If
    End Sub

    Private Sub d11_Click(sender As Object, e As EventArgs) Handles d11.Click
        If d11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d11.Text
            Me.Close()
        End If
    End Sub

    Private Sub d12_Click(sender As Object, e As EventArgs) Handles d12.Click
        If d12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d12.Text
            Me.Close()
        End If
    End Sub

    Private Sub d13_Click(sender As Object, e As EventArgs) Handles d13.Click
        If d13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d13.Text
            Me.Close()
        End If
    End Sub

    Private Sub d14_Click(sender As Object, e As EventArgs) Handles d14.Click
        If d14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d14.Text
            Me.Close()
        End If
    End Sub

    Private Sub d15_Click(sender As Object, e As EventArgs) Handles d15.Click
        If d15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d15.Text
            Me.Close()
        End If
    End Sub

    Private Sub d16_Click(sender As Object, e As EventArgs) Handles d16.Click
        If d16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = d16.Text
            Me.Close()
        End If
    End Sub

    Private Sub e1_Click(sender As Object, e As EventArgs) Handles e1.Click
        If e1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e1.Text
            Me.Close()
        End If
    End Sub

    Private Sub e2_Click(sender As Object, e As EventArgs) Handles e2.Click
        If e2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e2.Text
            Me.Close()
        End If
    End Sub

    Private Sub e3_Click(sender As Object, e As EventArgs) Handles e3.Click
        If e3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e3.Text
            Me.Close()
        End If
    End Sub

    Private Sub e4_Click(sender As Object, e As EventArgs) Handles e4.Click
        If e4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e4.Text
            Me.Close()
        End If
    End Sub

    Private Sub e5_Click(sender As Object, e As EventArgs) Handles e5.Click
        If e5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e5.Text
            Me.Close()
        End If
    End Sub

    Private Sub e6_Click(sender As Object, e As EventArgs) Handles e6.Click
        If e6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e6.Text
            Me.Close()
        End If
    End Sub

    Private Sub e7_Click(sender As Object, e As EventArgs) Handles e7.Click
        If e7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e7.Text
            Me.Close()
        End If
    End Sub

    Private Sub e8_Click(sender As Object, e As EventArgs) Handles e8.Click
        If e8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e8.Text
            Me.Close()
        End If
    End Sub

    Private Sub e9_Click(sender As Object, e As EventArgs) Handles e9.Click
        If e9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e9.Text
            Me.Close()
        End If
    End Sub

    Private Sub e10_Click(sender As Object, e As EventArgs) Handles e10.Click
        If e10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e10.Text
            Me.Close()
        End If
    End Sub

    Private Sub e11_Click(sender As Object, e As EventArgs) Handles e11.Click
        If e11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e11.Text
            Me.Close()
        End If
    End Sub

    Private Sub e12_Click(sender As Object, e As EventArgs) Handles e12.Click
        If e12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e12.Text
            Me.Close()
        End If
    End Sub

    Private Sub e13_Click(sender As Object, e As EventArgs) Handles e13.Click
        If e13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e13.Text
            Me.Close()
        End If
    End Sub

    Private Sub e14_Click(sender As Object, e As EventArgs) Handles e14.Click
        If e14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e14.Text
            Me.Close()
        End If
    End Sub

    Private Sub e15_Click(sender As Object, e As EventArgs) Handles e15.Click
        If e15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e15.Text
            Me.Close()
        End If
    End Sub

    Private Sub e16_Click(sender As Object, e As EventArgs) Handles e16.Click
        If e16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = e16.Text
            Me.Close()
        End If
    End Sub

    Private Sub f1_Click(sender As Object, e As EventArgs) Handles f1.Click
        If f1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f1.Text
            Me.Close()
        End If
    End Sub

    Private Sub f2_Click(sender As Object, e As EventArgs) Handles f2.Click
        If f2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f2.Text
            Me.Close()
        End If
    End Sub

    Private Sub f3_Click(sender As Object, e As EventArgs) Handles f3.Click
        If f3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f3.Text
            Me.Close()
        End If
    End Sub

    Private Sub f4_Click(sender As Object, e As EventArgs) Handles f4.Click
        If f4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f4.Text
            Me.Close()
        End If
    End Sub

    Private Sub f5_Click(sender As Object, e As EventArgs) Handles f5.Click
        If f5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f5.Text
            Me.Close()
        End If
    End Sub

    Private Sub f6_Click(sender As Object, e As EventArgs) Handles f6.Click
        If f6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f6.Text
            Me.Close()
        End If
    End Sub

    Private Sub f7_Click(sender As Object, e As EventArgs) Handles f7.Click
        If f7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f7.Text
            Me.Close()
        End If
    End Sub

    Private Sub f8_Click(sender As Object, e As EventArgs) Handles f8.Click

        If f8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f8.Text
            Me.Close()
        End If
    End Sub

    Private Sub f9_Click(sender As Object, e As EventArgs) Handles f9.Click
        If f9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f9.Text
            Me.Close()
        End If
    End Sub

    Private Sub f10_Click(sender As Object, e As EventArgs) Handles f10.Click
        If f10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f10.Text
            Me.Close()
        End If
    End Sub

    Private Sub f11_Click(sender As Object, e As EventArgs) Handles f11.Click
        If f11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f11.Text
            Me.Close()
        End If
    End Sub

    Private Sub f12_Click(sender As Object, e As EventArgs) Handles f12.Click
        If f12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f12.Text
            Me.Close()
        End If
    End Sub

    Private Sub f13_Click(sender As Object, e As EventArgs) Handles f13.Click
        If f13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f13.Text
            Me.Close()
        End If
    End Sub

    Private Sub f14_Click(sender As Object, e As EventArgs) Handles f14.Click
        If f14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f14.Text
            Me.Close()
        End If
    End Sub

    Private Sub f15_Click(sender As Object, e As EventArgs) Handles f15.Click
        If f15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f15.Text
            Me.Close()
        End If
    End Sub

    Private Sub f16_Click(sender As Object, e As EventArgs) Handles f16.Click
        If f16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = f16.Text
            Me.Close()
        End If
    End Sub

    Private Sub g1_Click(sender As Object, e As EventArgs) Handles g1.Click
        If g1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g1.Text
            Me.Close()
        End If
    End Sub

    Private Sub g2_Click(sender As Object, e As EventArgs) Handles g2.Click
        If g2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g2.Text
            Me.Close()
        End If
    End Sub

    Private Sub g3_Click(sender As Object, e As EventArgs) Handles g3.Click
        If g3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g3.Text
            Me.Close()
        End If
    End Sub

    Private Sub g4_Click(sender As Object, e As EventArgs) Handles g4.Click
        If g4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g4.Text
            Me.Close()
        End If
    End Sub

    Private Sub g5_Click(sender As Object, e As EventArgs) Handles g5.Click
        If g5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g5.Text
            Me.Close()
        End If
    End Sub

    Private Sub g6_Click(sender As Object, e As EventArgs) Handles g6.Click
        If g6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g6.Text
            Me.Close()
        End If
    End Sub

    Private Sub g7_Click(sender As Object, e As EventArgs) Handles g7.Click
        If g7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g7.Text
            Me.Close()
        End If
    End Sub

    Private Sub g8_Click(sender As Object, e As EventArgs) Handles g8.Click
        If g8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g8.Text
            Me.Close()
        End If
    End Sub

    Private Sub g9_Click(sender As Object, e As EventArgs) Handles g9.Click
        If g9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g9.Text
            Me.Close()
        End If
    End Sub

    Private Sub g10_Click(sender As Object, e As EventArgs) Handles g10.Click
        If g10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g10.Text
            Me.Close()
        End If
    End Sub

    Private Sub g11_Click(sender As Object, e As EventArgs) Handles g11.Click
        If g11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g11.Text
            Me.Close()
        End If
    End Sub

    Private Sub g12_Click(sender As Object, e As EventArgs) Handles g12.Click
        If g12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g12.Text
            Me.Close()
        End If
    End Sub

    Private Sub g13_Click(sender As Object, e As EventArgs) Handles g13.Click
        If g13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g13.Text
            Me.Close()
        End If
    End Sub

    Private Sub g14_Click(sender As Object, e As EventArgs) Handles g14.Click
        If g14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g14.Text
            Me.Close()
        End If
    End Sub

    Private Sub g15_Click(sender As Object, e As EventArgs) Handles g15.Click
        If g15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g15.Text
            Me.Close()
        End If
    End Sub

    Private Sub g16_Click(sender As Object, e As EventArgs) Handles g16.Click
        If g16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = g16.Text
            Me.Close()
        End If
    End Sub

    Private Sub h1_Click(sender As Object, e As EventArgs) Handles h1.Click
        If h1.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h1.Text
            Me.Close()
        End If
    End Sub

    Private Sub h2_Click(sender As Object, e As EventArgs) Handles h2.Click
        If h2.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h2.Text
            Me.Close()
        End If
    End Sub

    Private Sub h3_Click(sender As Object, e As EventArgs) Handles h3.Click
        If h3.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h3.Text
            Me.Close()
        End If
    End Sub

    Private Sub h4_Click(sender As Object, e As EventArgs) Handles h4.Click
        If h4.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h4.Text
            Me.Close()
        End If
    End Sub

    Private Sub h5_Click(sender As Object, e As EventArgs) Handles h5.Click
        If h5.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h5.Text
            Me.Close()
        End If
    End Sub

    Private Sub h6_Click(sender As Object, e As EventArgs) Handles h6.Click
        If h6.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h6.Text
            Me.Close()
        End If
    End Sub

    Private Sub h7_Click(sender As Object, e As EventArgs) Handles h7.Click
        If h7.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h7.Text
            Me.Close()
        End If
    End Sub

    Private Sub h8_Click(sender As Object, e As EventArgs) Handles h8.Click
        If h8.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h8.Text
            Me.Close()
        End If
    End Sub

    Private Sub h9_Click(sender As Object, e As EventArgs) Handles h9.Click
        If h9.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h9.Text
            Me.Close()
        End If
    End Sub

    Private Sub h10_Click(sender As Object, e As EventArgs) Handles h10.Click
        If h10.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h10.Text
            Me.Close()
        End If
    End Sub

    Private Sub h11_Click(sender As Object, e As EventArgs) Handles h11.Click
        If h11.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h11.Text
            Me.Close()
        End If
    End Sub

    Private Sub h12_Click(sender As Object, e As EventArgs) Handles h12.Click
        If h12.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h12.Text
            Me.Close()
        End If
    End Sub

    Private Sub h13_Click(sender As Object, e As EventArgs) Handles h13.Click
        If h13.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h13.Text
            Me.Close()
        End If
    End Sub

    Private Sub h14_Click(sender As Object, e As EventArgs) Handles h14.Click
        If h14.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h14.Text
            Me.Close()
        End If
    End Sub

    Private Sub h15_Click(sender As Object, e As EventArgs) Handles h15.Click
        If h15.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h15.Text
            Me.Close()
        End If
    End Sub

    Private Sub h16_Click(sender As Object, e As EventArgs) Handles h16.Click
        If h16.BackColor = Color.Red Then
            MsgBox("Already Booked")
        Else
            ticket.Show()
            ticket.TextBox6.Text = h16.Text
            Me.Close()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class