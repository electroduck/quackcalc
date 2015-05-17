<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainSplitter = New System.Windows.Forms.SplitContainer()
        Me.GraphBox = New System.Windows.Forms.Panel()
        Me.ScreenMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDataInNewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindY0ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindMaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindMinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BottomHalfLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ModeButton = New System.Windows.Forms.Button()
        Me.ScriptBox = New System.Windows.Forms.TextBox()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.OptionsButton = New Electroduck.Controls.DropDownButton()
        Me.OptionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrecisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XAxisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMinimumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMaximumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMarkerIntervalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YAxisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YMinimumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YMaximumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YMarkerIntervalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ScreenColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForegroundColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AntialiasedGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorPicker = New System.Windows.Forms.ColorDialog()
        Me.SaveScreen = New System.Windows.Forms.SaveFileDialog()
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitter.Panel1.SuspendLayout()
        Me.MainSplitter.Panel2.SuspendLayout()
        Me.MainSplitter.SuspendLayout()
        Me.ScreenMenu.SuspendLayout()
        Me.BottomHalfLayout.SuspendLayout()
        Me.OptionsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainSplitter
        '
        Me.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitter.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitter.Name = "MainSplitter"
        Me.MainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainSplitter.Panel1
        '
        Me.MainSplitter.Panel1.Controls.Add(Me.GraphBox)
        Me.MainSplitter.Panel1MinSize = 100
        '
        'MainSplitter.Panel2
        '
        Me.MainSplitter.Panel2.Controls.Add(Me.BottomHalfLayout)
        Me.MainSplitter.Panel2MinSize = 50
        Me.MainSplitter.Size = New System.Drawing.Size(339, 345)
        Me.MainSplitter.SplitterDistance = 230
        Me.MainSplitter.TabIndex = 0
        '
        'GraphBox
        '
        Me.GraphBox.BackColor = System.Drawing.Color.LimeGreen
        Me.GraphBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GraphBox.ContextMenuStrip = Me.ScreenMenu
        Me.GraphBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GraphBox.Location = New System.Drawing.Point(0, 0)
        Me.GraphBox.Name = "GraphBox"
        Me.GraphBox.Size = New System.Drawing.Size(339, 230)
        Me.GraphBox.TabIndex = 0
        '
        'ScreenMenu
        '
        Me.ScreenMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.CopyToolStripMenuItem, Me.SaveScreenToolStripMenuItem, Me.OpenDataInNewWindowToolStripMenuItem, Me.ToolStripSeparator2, Me.FindY0ToolStripMenuItem, Me.FindMaxToolStripMenuItem, Me.FindMinToolStripMenuItem})
        Me.ScreenMenu.Name = "ScreenMenu"
        Me.ScreenMenu.Size = New System.Drawing.Size(227, 164)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.CopyToolStripMenuItem.Text = "Copy Screen"
        '
        'SaveScreenToolStripMenuItem
        '
        Me.SaveScreenToolStripMenuItem.Name = "SaveScreenToolStripMenuItem"
        Me.SaveScreenToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.SaveScreenToolStripMenuItem.Text = "Save Screen"
        '
        'OpenDataInNewWindowToolStripMenuItem
        '
        Me.OpenDataInNewWindowToolStripMenuItem.Name = "OpenDataInNewWindowToolStripMenuItem"
        Me.OpenDataInNewWindowToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.OpenDataInNewWindowToolStripMenuItem.Text = "Open Data in New Window..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(223, 6)
        '
        'FindY0ToolStripMenuItem
        '
        Me.FindY0ToolStripMenuItem.Name = "FindY0ToolStripMenuItem"
        Me.FindY0ToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FindY0ToolStripMenuItem.Text = "Find Y=0"
        '
        'FindMaxToolStripMenuItem
        '
        Me.FindMaxToolStripMenuItem.Name = "FindMaxToolStripMenuItem"
        Me.FindMaxToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FindMaxToolStripMenuItem.Text = "Find Max"
        '
        'FindMinToolStripMenuItem
        '
        Me.FindMinToolStripMenuItem.Name = "FindMinToolStripMenuItem"
        Me.FindMinToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FindMinToolStripMenuItem.Text = "Find Min"
        '
        'BottomHalfLayout
        '
        Me.BottomHalfLayout.ColumnCount = 3
        Me.BottomHalfLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.BottomHalfLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.BottomHalfLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.BottomHalfLayout.Controls.Add(Me.ModeButton, 0, 1)
        Me.BottomHalfLayout.Controls.Add(Me.ScriptBox, 0, 0)
        Me.BottomHalfLayout.Controls.Add(Me.RunButton, 2, 1)
        Me.BottomHalfLayout.Controls.Add(Me.OptionsButton, 1, 1)
        Me.BottomHalfLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomHalfLayout.Location = New System.Drawing.Point(0, 0)
        Me.BottomHalfLayout.Name = "BottomHalfLayout"
        Me.BottomHalfLayout.RowCount = 2
        Me.BottomHalfLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BottomHalfLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.BottomHalfLayout.Size = New System.Drawing.Size(339, 111)
        Me.BottomHalfLayout.TabIndex = 0
        '
        'ModeButton
        '
        Me.ModeButton.BackColor = System.Drawing.Color.LimeGreen
        Me.ModeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ModeButton.Location = New System.Drawing.Point(3, 84)
        Me.ModeButton.Name = "ModeButton"
        Me.ModeButton.Size = New System.Drawing.Size(107, 24)
        Me.ModeButton.TabIndex = 2
        Me.ModeButton.Text = "I/O TABLE"
        Me.ModeButton.UseVisualStyleBackColor = False
        '
        'ScriptBox
        '
        Me.ScriptBox.BackColor = System.Drawing.Color.Black
        Me.ScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomHalfLayout.SetColumnSpan(Me.ScriptBox, 3)
        Me.ScriptBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScriptBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScriptBox.ForeColor = System.Drawing.Color.White
        Me.ScriptBox.Location = New System.Drawing.Point(3, 3)
        Me.ScriptBox.Multiline = True
        Me.ScriptBox.Name = "ScriptBox"
        Me.ScriptBox.Size = New System.Drawing.Size(333, 75)
        Me.ScriptBox.TabIndex = 0
        Me.ScriptBox.Text = "3*COS(x)"
        '
        'RunButton
        '
        Me.RunButton.BackColor = System.Drawing.Color.LimeGreen
        Me.RunButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RunButton.Location = New System.Drawing.Point(229, 84)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(107, 24)
        Me.RunButton.TabIndex = 1
        Me.RunButton.Text = "EVALUATE"
        Me.RunButton.UseVisualStyleBackColor = False
        '
        'OptionsButton
        '
        Me.OptionsButton.BackColor = System.Drawing.Color.LimeGreen
        Me.OptionsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsButton.Image = CType(resources.GetObject("OptionsButton.Image"), System.Drawing.Image)
        Me.OptionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OptionsButton.Location = New System.Drawing.Point(116, 84)
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.OnclickMenu = Me.OptionsMenu
        Me.OptionsButton.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.OptionsButton.Size = New System.Drawing.Size(107, 24)
        Me.OptionsButton.TabIndex = 3
        Me.OptionsButton.Text = "OPTIONS"
        Me.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.OptionsButton.UseVisualStyleBackColor = False
        '
        'OptionsMenu
        '
        Me.OptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrecisionToolStripMenuItem, Me.XAxisToolStripMenuItem, Me.YAxisToolStripMenuItem, Me.ToolStripSeparator1, Me.ScreenColorToolStripMenuItem, Me.FunctionColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem, Me.ForegroundColorToolStripMenuItem, Me.TextBoxToolStripMenuItem, Me.AntialiasedGraphToolStripMenuItem})
        Me.OptionsMenu.Name = "OptionsMenu"
        Me.OptionsMenu.Size = New System.Drawing.Size(171, 208)
        '
        'PrecisionToolStripMenuItem
        '
        Me.PrecisionToolStripMenuItem.Name = "PrecisionToolStripMenuItem"
        Me.PrecisionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PrecisionToolStripMenuItem.Text = "Precision"
        '
        'XAxisToolStripMenuItem
        '
        Me.XAxisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XMinimumToolStripMenuItem, Me.XMaximumToolStripMenuItem, Me.XMarkerIntervalsToolStripMenuItem})
        Me.XAxisToolStripMenuItem.Name = "XAxisToolStripMenuItem"
        Me.XAxisToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.XAxisToolStripMenuItem.Text = "X Axis"
        '
        'XMinimumToolStripMenuItem
        '
        Me.XMinimumToolStripMenuItem.Name = "XMinimumToolStripMenuItem"
        Me.XMinimumToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.XMinimumToolStripMenuItem.Text = "X Minimum"
        '
        'XMaximumToolStripMenuItem
        '
        Me.XMaximumToolStripMenuItem.Name = "XMaximumToolStripMenuItem"
        Me.XMaximumToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.XMaximumToolStripMenuItem.Text = "X Maximum"
        '
        'XMarkerIntervalsToolStripMenuItem
        '
        Me.XMarkerIntervalsToolStripMenuItem.Name = "XMarkerIntervalsToolStripMenuItem"
        Me.XMarkerIntervalsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.XMarkerIntervalsToolStripMenuItem.Text = "X Marker Intervals"
        '
        'YAxisToolStripMenuItem
        '
        Me.YAxisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YMinimumToolStripMenuItem, Me.YMaximumToolStripMenuItem, Me.YMarkerIntervalsToolStripMenuItem})
        Me.YAxisToolStripMenuItem.Name = "YAxisToolStripMenuItem"
        Me.YAxisToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.YAxisToolStripMenuItem.Text = "Y Axis"
        '
        'YMinimumToolStripMenuItem
        '
        Me.YMinimumToolStripMenuItem.Name = "YMinimumToolStripMenuItem"
        Me.YMinimumToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.YMinimumToolStripMenuItem.Text = "Y Minimum"
        '
        'YMaximumToolStripMenuItem
        '
        Me.YMaximumToolStripMenuItem.Name = "YMaximumToolStripMenuItem"
        Me.YMaximumToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.YMaximumToolStripMenuItem.Text = "Y Maximum"
        '
        'YMarkerIntervalsToolStripMenuItem
        '
        Me.YMarkerIntervalsToolStripMenuItem.Name = "YMarkerIntervalsToolStripMenuItem"
        Me.YMarkerIntervalsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.YMarkerIntervalsToolStripMenuItem.Text = "Y Marker Intervals"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'ScreenColorToolStripMenuItem
        '
        Me.ScreenColorToolStripMenuItem.Name = "ScreenColorToolStripMenuItem"
        Me.ScreenColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ScreenColorToolStripMenuItem.Text = """Screen"" Color"
        '
        'FunctionColorToolStripMenuItem
        '
        Me.FunctionColorToolStripMenuItem.Name = "FunctionColorToolStripMenuItem"
        Me.FunctionColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FunctionColorToolStripMenuItem.Text = "Function Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'ForegroundColorToolStripMenuItem
        '
        Me.ForegroundColorToolStripMenuItem.Name = "ForegroundColorToolStripMenuItem"
        Me.ForegroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ForegroundColorToolStripMenuItem.Text = "Foreground Color"
        '
        'TextBoxToolStripMenuItem
        '
        Me.TextBoxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundColorToolStripMenuItem1, Me.ForegroundColorToolStripMenuItem1})
        Me.TextBoxToolStripMenuItem.Name = "TextBoxToolStripMenuItem"
        Me.TextBoxToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TextBoxToolStripMenuItem.Text = "Text Box"
        '
        'BackgroundColorToolStripMenuItem1
        '
        Me.BackgroundColorToolStripMenuItem1.Name = "BackgroundColorToolStripMenuItem1"
        Me.BackgroundColorToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem1.Text = "Background Color"
        '
        'ForegroundColorToolStripMenuItem1
        '
        Me.ForegroundColorToolStripMenuItem1.Name = "ForegroundColorToolStripMenuItem1"
        Me.ForegroundColorToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ForegroundColorToolStripMenuItem1.Text = "Foreground Color"
        '
        'AntialiasedGraphToolStripMenuItem
        '
        Me.AntialiasedGraphToolStripMenuItem.Checked = True
        Me.AntialiasedGraphToolStripMenuItem.CheckOnClick = True
        Me.AntialiasedGraphToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AntialiasedGraphToolStripMenuItem.Name = "AntialiasedGraphToolStripMenuItem"
        Me.AntialiasedGraphToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AntialiasedGraphToolStripMenuItem.Text = "Smooth Graph"
        '
        'EvalTimer
        '
        Me.EvalTimer.Interval = 10
        '
        'ColorPicker
        '
        Me.ColorPicker.FullOpen = True
        '
        'SaveScreen
        '
        Me.SaveScreen.Filter = "Bitmap image|*.bmp"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 345)
        Me.Controls.Add(Me.MainSplitter)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(260, 260)
        Me.Name = "MainForm"
        Me.Text = "QuackCalc Graphing Calculator"
        Me.MainSplitter.Panel1.ResumeLayout(False)
        Me.MainSplitter.Panel2.ResumeLayout(False)
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitter.ResumeLayout(False)
        Me.ScreenMenu.ResumeLayout(False)
        Me.BottomHalfLayout.ResumeLayout(False)
        Me.BottomHalfLayout.PerformLayout()
        Me.OptionsMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainSplitter As System.Windows.Forms.SplitContainer
    Friend WithEvents GraphBox As System.Windows.Forms.Panel
    Friend WithEvents BottomHalfLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ScriptBox As System.Windows.Forms.TextBox
    Friend WithEvents RunButton As System.Windows.Forms.Button
    Friend WithEvents EvalTimer As System.Windows.Forms.Timer
    Friend WithEvents ModeButton As System.Windows.Forms.Button
    Friend WithEvents OptionsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PrecisionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XAxisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XMinimumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XMaximumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YAxisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YMinimumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YMaximumToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YMarkerIntervalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ScreenColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForegroundColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForegroundColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XMarkerIntervalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsButton As Electroduck.Controls.DropDownButton
    Friend WithEvents ColorPicker As System.Windows.Forms.ColorDialog
    Friend WithEvents FunctionColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AntialiasedGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreenMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindY0ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindMaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindMinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDataInNewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveScreen As System.Windows.Forms.SaveFileDialog

End Class
