<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Soundboard
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlpSounds = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ButtonsToolStripMenuItem
        '
        Me.ButtonsToolStripMenuItem.Name = "ButtonsToolStripMenuItem"
        Me.ButtonsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ButtonsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ButtonsToolStripMenuItem.Text = "Buttons..."
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'tlpSounds
        '
        Me.tlpSounds.AutoSize = True
        Me.tlpSounds.ColumnCount = 10
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSounds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSounds.Location = New System.Drawing.Point(0, 24)
        Me.tlpSounds.Name = "tlpSounds"
        Me.tlpSounds.RowCount = 1
        Me.tlpSounds.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpSounds.Size = New System.Drawing.Size(984, 51)
        Me.tlpSounds.TabIndex = 2
        '
        'Soundboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(984, 75)
        Me.Controls.Add(Me.tlpSounds)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Soundboard"
        Me.ShowIcon = False
        Me.Text = "Soundboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpSounds As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
