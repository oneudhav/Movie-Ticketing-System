<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RouteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookedSeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.frontmain = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.frontmain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.DetailToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 70)
        '
        'BusToolStripMenuItem
        '
        Me.BusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RouteToolStripMenuItem})
        Me.BusToolStripMenuItem.Name = "BusToolStripMenuItem"
        Me.BusToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BusToolStripMenuItem.Text = "Bus"
        '
        'RouteToolStripMenuItem
        '
        Me.RouteToolStripMenuItem.Name = "RouteToolStripMenuItem"
        Me.RouteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.RouteToolStripMenuItem.Text = "Route"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'DetailToolStripMenuItem
        '
        Me.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem"
        Me.DetailToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DetailToolStripMenuItem.Text = "Detail"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BusToolStripMenuItem1, Me.TicketToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 6)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 37)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BusToolStripMenuItem1
        '
        Me.BusToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem1, Me.DetailsToolStripMenuItem1})
        Me.BusToolStripMenuItem1.Image = Global.Menu.My.Resources.Resources.Bus_13
        Me.BusToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BusToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.BusToolStripMenuItem1.Name = "BusToolStripMenuItem1"
        Me.BusToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(4, 0, 120, 0)
        Me.BusToolStripMenuItem1.Size = New System.Drawing.Size(211, 29)
        Me.BusToolStripMenuItem1.Text = "Movie"
        '
        'RegisterToolStripMenuItem1
        '
        Me.RegisterToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.RegisterToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegisterToolStripMenuItem1.Image = Global.Menu.My.Resources.Resources.if_Login_49249
        Me.RegisterToolStripMenuItem1.Name = "RegisterToolStripMenuItem1"
        Me.RegisterToolStripMenuItem1.Size = New System.Drawing.Size(156, 30)
        Me.RegisterToolStripMenuItem1.Text = "Register"
        '
        'DetailsToolStripMenuItem1
        '
        Me.DetailsToolStripMenuItem1.Image = Global.Menu.My.Resources.Resources.account_card_512
        Me.DetailsToolStripMenuItem1.Name = "DetailsToolStripMenuItem1"
        Me.DetailsToolStripMenuItem1.Size = New System.Drawing.Size(156, 30)
        Me.DetailsToolStripMenuItem1.Text = "Details"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookToolStripMenuItem, Me.BookedSeatToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.TicketToolStripMenuItem.Image = Global.Menu.My.Resources.Resources.calendar
        Me.TicketToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 120, 0)
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(232, 29)
        Me.TicketToolStripMenuItem.Text = "Booking"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(143, 30)
        Me.BookToolStripMenuItem.Text = "Seat "
        '
        'BookedSeatToolStripMenuItem
        '
        Me.BookedSeatToolStripMenuItem.Name = "BookedSeatToolStripMenuItem"
        Me.BookedSeatToolStripMenuItem.Size = New System.Drawing.Size(143, 30)
        Me.BookedSeatToolStripMenuItem.Text = "Details"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(143, 30)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.DetailsToolStripMenuItem.Image = Global.Menu.My.Resources.Resources.account_card_512
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 120, 0)
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(226, 29)
        Me.DetailsToolStripMenuItem.Text = "Reports"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Menu.My.Resources.Resources.if_Symbol_Information_49264
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 120, 0)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(212, 29)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.Menu.My.Resources.Resources._768px_Crystal_Clear_action_exit_svg
        Me.LogoutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 100, 0)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(208, 29)
        Me.LogoutToolStripMenuItem.Text = "Log Out"
        Me.LogoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frontmain
        '
        Me.frontmain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.frontmain.Controls.Add(Me.Label5)
        Me.frontmain.Controls.Add(Me.Label4)
        Me.frontmain.Controls.Add(Me.Label3)
        Me.frontmain.Controls.Add(Me.Label2)
        Me.frontmain.Controls.Add(Me.Label1)
        Me.frontmain.Location = New System.Drawing.Point(0, 52)
        Me.frontmain.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.frontmain.Name = "frontmain"
        Me.frontmain.Size = New System.Drawing.Size(1358, 666)
        Me.frontmain.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1122, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1120, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Time:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1188, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1184, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(209, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(826, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOVIE TICKETING SYSTEM"
        '
        'Timer1
        '
        '
        'menu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.frontmain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "menu1"
        Me.Text = "dat"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.frontmain.ResumeLayout(False)
        Me.frontmain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RouteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookedSeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents frontmain As System.Windows.Forms.Panel
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
