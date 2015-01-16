<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buttons
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvButtons = New System.Windows.Forms.DataGridView()
        Me.BoardName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvButtons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDone)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 29)
        Me.Panel1.TabIndex = 1
        '
        'btnDone
        '
        Me.btnDone.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnDone.Location = New System.Drawing.Point(209, 0)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 29)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 29)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvButtons
        '
        Me.dgvButtons.AllowUserToAddRows = False
        Me.dgvButtons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvButtons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BoardName, Me.Filename})
        Me.dgvButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvButtons.Location = New System.Drawing.Point(0, 0)
        Me.dgvButtons.Name = "dgvButtons"
        Me.dgvButtons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvButtons.Size = New System.Drawing.Size(284, 233)
        Me.dgvButtons.TabIndex = 2
        '
        'BoardName
        '
        Me.BoardName.HeaderText = "BoardName"
        Me.BoardName.Name = "BoardName"
        '
        'Filename
        '
        Me.Filename.HeaderText = "Filename"
        Me.Filename.Name = "Filename"
        '
        'Buttons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.dgvButtons)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Buttons"
        Me.ShowIcon = False
        Me.Text = "Buttons"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvButtons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvButtons As System.Windows.Forms.DataGridView
    Friend WithEvents BoardName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Filename As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
