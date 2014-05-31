<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NsTheme1 = New XBMC_Remote_Keyboard.NSTheme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsButton1 = New XBMC_Remote_Keyboard.NSButton()
        Me.NsTextBox2 = New XBMC_Remote_Keyboard.NSTextBox()
        Me.NsTextBox1 = New XBMC_Remote_Keyboard.NSTextBox()
        Me.NsControlButton1 = New XBMC_Remote_Keyboard.NSControlButton()
        Me.NsLabel1 = New XBMC_Remote_Keyboard.NSLabel()
        Me.ntfyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NsContextMenu1 = New XBMC_Remote_Keyboard.NSContextMenu()
        Me.DisableKeyhookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NsTheme1.SuspendLayout()
        Me.NsContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New XBMC_Remote_Keyboard.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.Label1)
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Controls.Add(Me.NsTextBox2)
        Me.NsTheme1.Controls.Add(Me.NsTextBox1)
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Controls.Add(Me.NsLabel1)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(311, 175)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Cyanlabs XBMC Remote Keyboard"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        Me.NsTheme1.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 91)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BETA RELEASE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Enter IP and Port below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Press ""Apply!"" button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Close " & _
    "window using ""X"" button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4. Press ALT + KEY e.g. ALT + LEFT." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5. Enjoy, Visit C" & _
    "yanlabs.co.uk for more."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'NsButton1
        '
        Me.NsButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsButton1.Location = New System.Drawing.Point(190, 134)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(112, 33)
        Me.NsButton1.TabIndex = 2
        Me.NsButton1.Text = "      Apply!"
        Me.NsButton1.UseWaitCursor = True
        '
        'NsTextBox2
        '
        Me.NsTextBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.NsTextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsTextBox2.Location = New System.Drawing.Point(133, 134)
        Me.NsTextBox2.MaxLength = 32767
        Me.NsTextBox2.Multiline = False
        Me.NsTextBox2.Name = "NsTextBox2"
        Me.NsTextBox2.ReadOnly = False
        Me.NsTextBox2.Size = New System.Drawing.Size(53, 33)
        Me.NsTextBox2.TabIndex = 1
        Me.NsTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox2.UseSystemPasswordChar = False
        Me.NsTextBox2.UseWaitCursor = True
        '
        'NsTextBox1
        '
        Me.NsTextBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.NsTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NsTextBox1.Location = New System.Drawing.Point(11, 134)
        Me.NsTextBox1.MaxLength = 32767
        Me.NsTextBox1.Multiline = False
        Me.NsTextBox1.Name = "NsTextBox1"
        Me.NsTextBox1.ReadOnly = False
        Me.NsTextBox1.Size = New System.Drawing.Size(116, 33)
        Me.NsTextBox1.TabIndex = 1
        Me.NsTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.NsTextBox1.UseSystemPasswordChar = False
        Me.NsTextBox1.UseWaitCursor = True
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = XBMC_Remote_Keyboard.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(286, 3)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 0
        Me.NsControlButton1.Text = "NsControlButton1"
        Me.NsControlButton1.UseWaitCursor = True
        '
        'NsLabel1
        '
        Me.NsLabel1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.NsLabel1.Location = New System.Drawing.Point(125, 121)
        Me.NsLabel1.Name = "NsLabel1"
        Me.NsLabel1.Size = New System.Drawing.Size(130, 39)
        Me.NsLabel1.TabIndex = 3
        Me.NsLabel1.Text = ":"
        Me.NsLabel1.UseWaitCursor = True
        Me.NsLabel1.Value1 = ""
        Me.NsLabel1.Value2 = ":"
        '
        'ntfyIcon
        '
        Me.ntfyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntfyIcon.ContextMenuStrip = Me.NsContextMenu1
        Me.ntfyIcon.Icon = CType(resources.GetObject("ntfyIcon.Icon"), System.Drawing.Icon)
        Me.ntfyIcon.Text = "XBMC Remote Keyboard"
        Me.ntfyIcon.Visible = True
        '
        'NsContextMenu1
        '
        Me.NsContextMenu1.ForeColor = System.Drawing.Color.White
        Me.NsContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisableKeyhookToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.NsContextMenu1.Name = "NsContextMenu1"
        Me.NsContextMenu1.Size = New System.Drawing.Size(162, 98)
        '
        'DisableKeyhookToolStripMenuItem
        '
        Me.DisableKeyhookToolStripMenuItem.Name = "DisableKeyhookToolStripMenuItem"
        Me.DisableKeyhookToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.DisableKeyhookToolStripMenuItem.Text = "Disable Keyhook"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 175)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Opacity = 0.0R
        Me.Text = "Form1"
        Me.UseWaitCursor = True
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        Me.NsContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsTheme1 As XBMC_Remote_Keyboard.NSTheme
    Friend WithEvents NsButton1 As XBMC_Remote_Keyboard.NSButton
    Friend WithEvents NsTextBox1 As XBMC_Remote_Keyboard.NSTextBox
    Friend WithEvents NsControlButton1 As XBMC_Remote_Keyboard.NSControlButton
    Friend WithEvents ntfyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents NsContextMenu1 As XBMC_Remote_Keyboard.NSContextMenu
    Friend WithEvents DisableKeyhookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NsLabel1 As XBMC_Remote_Keyboard.NSLabel
    Friend WithEvents NsTextBox2 As XBMC_Remote_Keyboard.NSTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
