<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataDialog
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
        Me.ButtonLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.DataTable = New System.Windows.Forms.DataGridView()
        Me.XValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SaveData = New System.Windows.Forms.SaveFileDialog()
        Me.ButtonLayout.SuspendLayout()
        CType(Me.DataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonLayout
        '
        Me.ButtonLayout.ColumnCount = 3
        Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ButtonLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.ButtonLayout.Controls.Add(Me.SaveButton, 1, 0)
        Me.ButtonLayout.Controls.Add(Me.OK_Button, 2, 0)
        Me.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonLayout.Location = New System.Drawing.Point(0, 321)
        Me.ButtonLayout.Name = "ButtonLayout"
        Me.ButtonLayout.RowCount = 1
        Me.ButtonLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ButtonLayout.Size = New System.Drawing.Size(268, 29)
        Me.ButtonLayout.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.BackColor = System.Drawing.Color.LimeGreen
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(171, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(94, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Close"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'DataTable
        '
        Me.DataTable.AllowUserToAddRows = False
        Me.DataTable.AllowUserToDeleteRows = False
        Me.DataTable.BackgroundColor = System.Drawing.Color.Black
        Me.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.XValue, Me.YValue})
        Me.DataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTable.Location = New System.Drawing.Point(0, 0)
        Me.DataTable.Name = "DataTable"
        Me.DataTable.Size = New System.Drawing.Size(268, 321)
        Me.DataTable.TabIndex = 1
        '
        'XValue
        '
        Me.XValue.HeaderText = "X"
        Me.XValue.Name = "XValue"
        Me.XValue.ReadOnly = True
        '
        'YValue
        '
        Me.YValue.HeaderText = "Y"
        Me.YValue.Name = "YValue"
        Me.YValue.ReadOnly = True
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.LimeGreen
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveButton.Location = New System.Drawing.Point(71, 3)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(94, 23)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SaveData
        '
        Me.SaveData.Filter = "Comma-seperated table|*.csv"
        '
        'DataDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(268, 350)
        Me.Controls.Add(Me.DataTable)
        Me.Controls.Add(Me.ButtonLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Data Table"
        Me.ButtonLayout.ResumeLayout(False)
        CType(Me.DataTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents DataTable As System.Windows.Forms.DataGridView
    Friend WithEvents XValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SaveData As System.Windows.Forms.SaveFileDialog

End Class
