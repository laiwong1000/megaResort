<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.mainformMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.printReservationsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainformToolStrip = New System.Windows.Forms.ToolStrip()
        Me.guestsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.roomsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.reservationsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.printReservationToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.mainformStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.textToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainformContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GuestsContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationsContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainformMenuStrip.SuspendLayout()
        Me.mainformToolStrip.SuspendLayout()
        Me.mainformStatusStrip.SuspendLayout()
        Me.mainformContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainformMenuStrip
        '
        Me.mainformMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainformMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.WindowToolStripMenuItem, Me.PrintToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.mainformMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainformMenuStrip.Name = "mainformMenuStrip"
        Me.mainformMenuStrip.Size = New System.Drawing.Size(1248, 33)
        Me.mainformMenuStrip.TabIndex = 0
        Me.mainformMenuStrip.TabStop = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 30)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(132, 30)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuestsToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.ReservationsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'GuestsToolStripMenuItem
        '
        Me.GuestsToolStripMenuItem.Name = "GuestsToolStripMenuItem"
        Me.GuestsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuestsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.GuestsToolStripMenuItem.Text = "&Guests"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.RoomsToolStripMenuItem.Text = "Roo&ms"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(291, 30)
        Me.ReservationsToolStripMenuItem.Text = "&Reservations"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileHorizontalToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.CascadeToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(90, 29)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.printReservationsToolStripMenuItem1})
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(60, 29)
        Me.PrintToolStripMenuItem1.Text = "&Print"
        '
        'printReservationsToolStripMenuItem1
        '
        Me.printReservationsToolStripMenuItem1.Name = "printReservationsToolStripMenuItem1"
        Me.printReservationsToolStripMenuItem1.Size = New System.Drawing.Size(231, 30)
        Me.printReservationsToolStripMenuItem1.Text = "PrintReservations"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(146, 30)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'mainformToolStrip
        '
        Me.mainformToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainformToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.guestsToolStripButton, Me.roomsToolStripButton, Me.reservationsToolStripButton, Me.printReservationToolStripButton})
        Me.mainformToolStrip.Location = New System.Drawing.Point(0, 33)
        Me.mainformToolStrip.Name = "mainformToolStrip"
        Me.mainformToolStrip.Size = New System.Drawing.Size(1248, 31)
        Me.mainformToolStrip.TabIndex = 1
        Me.mainformToolStrip.TabStop = True
        Me.mainformToolStrip.Text = "ToolStrip1"
        '
        'guestsToolStripButton
        '
        Me.guestsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.guestsToolStripButton.Image = CType(resources.GetObject("guestsToolStripButton.Image"), System.Drawing.Image)
        Me.guestsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.guestsToolStripButton.Name = "guestsToolStripButton"
        Me.guestsToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.guestsToolStripButton.ToolTipText = "Click to manage Guests"
        '
        'roomsToolStripButton
        '
        Me.roomsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.roomsToolStripButton.Image = CType(resources.GetObject("roomsToolStripButton.Image"), System.Drawing.Image)
        Me.roomsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.roomsToolStripButton.Name = "roomsToolStripButton"
        Me.roomsToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.roomsToolStripButton.ToolTipText = "Click to manage rooms"
        '
        'reservationsToolStripButton
        '
        Me.reservationsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.reservationsToolStripButton.Image = CType(resources.GetObject("reservationsToolStripButton.Image"), System.Drawing.Image)
        Me.reservationsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.reservationsToolStripButton.Name = "reservationsToolStripButton"
        Me.reservationsToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.reservationsToolStripButton.ToolTipText = "click to manage reservations"
        '
        'printReservationToolStripButton
        '
        Me.printReservationToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printReservationToolStripButton.Image = CType(resources.GetObject("printReservationToolStripButton.Image"), System.Drawing.Image)
        Me.printReservationToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printReservationToolStripButton.Name = "printReservationToolStripButton"
        Me.printReservationToolStripButton.Size = New System.Drawing.Size(28, 28)
        Me.printReservationToolStripButton.Text = "Print Rservations"
        '
        'mainformStatusStrip
        '
        Me.mainformStatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainformStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.textToolStripStatusLabel, Me.timeToolStripStatusLabel})
        Me.mainformStatusStrip.Location = New System.Drawing.Point(0, 678)
        Me.mainformStatusStrip.Name = "mainformStatusStrip"
        Me.mainformStatusStrip.Size = New System.Drawing.Size(1248, 30)
        Me.mainformStatusStrip.TabIndex = 9
        Me.mainformStatusStrip.Text = "Get it all - Get away to Mega Resorts"
        '
        'textToolStripStatusLabel
        '
        Me.textToolStripStatusLabel.Name = "textToolStripStatusLabel"
        Me.textToolStripStatusLabel.Size = New System.Drawing.Size(0, 25)
        '
        'timeToolStripStatusLabel
        '
        Me.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel"
        Me.timeToolStripStatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.timeToolStripStatusLabel.Size = New System.Drawing.Size(1233, 25)
        Me.timeToolStripStatusLabel.Spring = True
        Me.timeToolStripStatusLabel.Text = "time"
        Me.timeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainformContextMenuStrip
        '
        Me.mainformContextMenuStrip.AllowDrop = True
        Me.mainformContextMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mainformContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuestsContextMenuItem, Me.RoomsContextMenuItem, Me.ReservationsContextMenuItem})
        Me.mainformContextMenuStrip.Name = "mainformContextMenuStrip"
        Me.mainformContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mainformContextMenuStrip.ShowCheckMargin = True
        Me.mainformContextMenuStrip.Size = New System.Drawing.Size(310, 94)
        Me.mainformContextMenuStrip.TabStop = True
        '
        'GuestsContextMenuItem
        '
        Me.GuestsContextMenuItem.Image = CType(resources.GetObject("GuestsContextMenuItem.Image"), System.Drawing.Image)
        Me.GuestsContextMenuItem.Name = "GuestsContextMenuItem"
        Me.GuestsContextMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuestsContextMenuItem.Size = New System.Drawing.Size(309, 30)
        Me.GuestsContextMenuItem.Text = "&Guests"
        Me.GuestsContextMenuItem.ToolTipText = "Click to manage Guests"
        '
        'RoomsContextMenuItem
        '
        Me.RoomsContextMenuItem.Image = CType(resources.GetObject("RoomsContextMenuItem.Image"), System.Drawing.Image)
        Me.RoomsContextMenuItem.Name = "RoomsContextMenuItem"
        Me.RoomsContextMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.RoomsContextMenuItem.Size = New System.Drawing.Size(309, 30)
        Me.RoomsContextMenuItem.Text = "Roo&ms"
        Me.RoomsContextMenuItem.ToolTipText = "Click to manage Rooms"
        '
        'ReservationsContextMenuItem
        '
        Me.ReservationsContextMenuItem.Image = CType(resources.GetObject("ReservationsContextMenuItem.Image"), System.Drawing.Image)
        Me.ReservationsContextMenuItem.Name = "ReservationsContextMenuItem"
        Me.ReservationsContextMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReservationsContextMenuItem.Size = New System.Drawing.Size(309, 30)
        Me.ReservationsContextMenuItem.Text = "&Reservations"
        Me.ReservationsContextMenuItem.ToolTipText = "Click to manage Reservations"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 708)
        Me.ContextMenuStrip = Me.mainformContextMenuStrip
        Me.Controls.Add(Me.mainformStatusStrip)
        Me.Controls.Add(Me.mainformToolStrip)
        Me.Controls.Add(Me.mainformMenuStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mainformMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mega Resorts"
        Me.mainformMenuStrip.ResumeLayout(False)
        Me.mainformMenuStrip.PerformLayout()
        Me.mainformToolStrip.ResumeLayout(False)
        Me.mainformToolStrip.PerformLayout()
        Me.mainformStatusStrip.ResumeLayout(False)
        Me.mainformStatusStrip.PerformLayout()
        Me.mainformContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainformMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainformToolStrip As ToolStrip
    Friend WithEvents guestsToolStripButton As ToolStripButton
    Friend WithEvents roomsToolStripButton As ToolStripButton
    Friend WithEvents reservationsToolStripButton As ToolStripButton
    Friend WithEvents mainformStatusStrip As StatusStrip
    Friend WithEvents timeToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents textToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents mainformContextMenuStrip As ContextMenuStrip
    Friend WithEvents GuestsContextMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsContextMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationsContextMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents printReservationsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents printReservationToolStripButton As ToolStripButton
End Class
