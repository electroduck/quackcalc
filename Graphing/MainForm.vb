<Runtime.InteropServices.ComVisible(True)> _
Public Class MainForm

    Const SINGLE_MIN As Single = CSng(-3.4028235E+38)
    Const SINGLE_MAX As Single = CSng(3.4028235E+38)

    Enum ScreenMode
        Graphing
        Table
    End Enum

    Dim wState As Window
    Dim gPrecision As Double = 0.1
    Dim x As Double
    Public Values As New List(Of PointF)
    Dim PointOfInterest As New PointF(0, 0)
    Dim ShowPOI As Boolean = False
    Dim Mode As ScreenMode = ScreenMode.Graphing
    Public Const NumberFormat As String = "{0,9:0.000}"

    Dim Status As String = "READY."

    Public cScreenBG As Drawing.Color = Color.LimeGreen
    Public cScreenFG As Drawing.Color = Color.Black
    Public cScreenLine As Drawing.Color = Color.Black
    Public cBackground As Drawing.Color = Drawing.Color.FromArgb(64, 64, 64)
    Public cTextboxFG As Drawing.Color = Color.White
    Public cTextboxBG As Drawing.Color = Color.Black
    Public cCancel As Drawing.Color = Color.Red

    Public Property UseAA() As Boolean
        Get
            Return AntialiasedGraphToolStripMenuItem.Checked
        End Get
        Set(ByVal value As Boolean)
            AntialiasedGraphToolStripMenuItem.Checked = value
            GraphBox.Invalidate()
        End Set
    End Property

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        wState.XMin = -10
        wState.XMax = 10
        wState.XInterval = 1
        wState.YMin = -10
        wState.YMax = 10
        wState.YInterval = 1
        UpdateColors()
    End Sub

    Sub UpdateColors()
        GraphBox.BackColor = cScreenBG
        GraphBox.ForeColor = cScreenFG
        Me.BackColor = cBackground
        RunButton.ForeColor = cScreenFG
        If EvalTimer.Enabled Then
            RunButton.BackColor = cCancel
        Else
            RunButton.BackColor = cScreenBG
        End If
        OptionsButton.BackColor = cScreenBG
        OptionsButton.ForeColor = cScreenFG
        ModeButton.BackColor = cScreenBG
        ModeButton.ForeColor = cScreenFG
        ScriptBox.BackColor = cTextboxBG
        ScriptBox.ForeColor = cTextboxFG

        GraphBox.Invalidate()
        Me.Invalidate()
        RunButton.Invalidate()
        OptionsButton.Invalidate()
        ModeButton.Invalidate()
        ScriptBox.Invalidate()
    End Sub

    Sub StartEval()
        Values.Clear()
        x = wState.XMin
        RunButton.Text = "STOP"
        RunButton.BackColor = cCancel
        EvalTimer.Enabled = True
        ShowPOI = False
    End Sub

    Private Sub EvalTimer_Tick(sender As System.Object, e As System.EventArgs) Handles EvalTimer.Tick
        Dim sc As New MSScriptControl.ScriptControl
        Dim formula As String = ScriptBox.Text
        Dim result As Double
        sc.Language = "VBSCRIPT"
        sc.AddObject("x", x)
        Try
            result = CDbl(sc.Eval(formula))
            Values.Add(New PointF(x, result))
            Status = Values.Last.ToString
        Catch ex As Exception
            Status = "ERROR"
        End Try
        x += gPrecision '/ (wState.XMax - wState.XMin)
        If x > wState.XMax Then
            Status = "READY."
            EndEval()
        End If
        GraphBox.Invalidate()
    End Sub

    Sub EndEval()
        EvalTimer.Enabled = False
        RunButton.Text = "EVALUATE"
        RunButton.BackColor = cScreenBG
    End Sub

    Private Sub RunButton_Click(sender As System.Object, e As System.EventArgs) Handles RunButton.Click
        If EvalTimer.Enabled Then
            EndEval()
        Else
            StartEval()
        End If
    End Sub

    Function GetPointFLocation(ByVal pt As PointF, ByVal scW As Double, ByVal scH As Double) As PointF
        Dim offX As Double = 0
        Dim offY As Double = (scH - scW) / 2
        Dim axisX As Double = offX + ((0 - wState.XMin) / (wState.XMax - wState.XMin)) * scW
        Dim axisY As Double = offY + ((0 - wState.YMin) / (wState.YMax - wState.YMin)) * scW
        Dim sizeX As Double = scW / (wState.XMax - wState.XMin)
        Dim sizeY As Double = scW / (wState.YMax - wState.YMin)
        Return New PointF(offX + ((pt.X - wState.XMin) / (wState.XMax - wState.XMin)) * scW, -sizeY * pt.Y + axisY)
    End Function

    Function PointF2Point(ByVal ptf As PointF) As Point
        Dim x As Integer = ptf.X
        Dim y As Integer = ptf.Y
        Return New Point(x, y)
    End Function

    Function GetPointLocation(ByVal pt As PointF, ByVal scW As Double, ByVal scH As Double) As Point
        Return PointF2Point(GetPointFLocation(pt, scW, scH))
    End Function

    Private Sub GraphBox_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles GraphBox.Paint
        Dim scW As Double = e.ClipRectangle.Width
        Dim scH As Double = e.ClipRectangle.Height
        Dim buffer As New Bitmap(CInt(scW), CInt(scH))
        Dim gBuf As Graphics = Graphics.FromImage(buffer)
        If UseAA Then
            gBuf.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            gBuf.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Else
            gBuf.SmoothingMode = Drawing2D.SmoothingMode.None
            gBuf.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
        End If
        REM Status text
        Dim statusBrush As Brush = New SolidBrush(cScreenFG)
        Dim statusFont As New Font("Arial", 9)
        gBuf.DrawString(Status, statusFont, statusBrush, 0, 0)
        If Mode = ScreenMode.Graphing Then
            REM Graphing mode
            Dim lastPos As New PointF(0, 0)
            Dim curPos As New PointF(0, 0)
            Dim axisPen As Pen = New Pen(cScreenFG)
            Dim linePen As Pen = New Pen(cScreenLine)
            REM Axis lines
            gBuf.DrawLine(axisPen, GetPointLocation(New PointF(wState.XMin, 0), scW, scH), _
                          GetPointLocation(New PointF(wState.XMax, 0), scW, scH))
            gBuf.DrawLine(axisPen, GetPointLocation(New PointF(0, wState.YMin), scW, scH), _
                          GetPointLocation(New PointF(0, wState.YMax), scW, scH))
            REM Axis ticks
            Dim pt As PointF
            For i As Double = wState.XMin To wState.XMax Step wState.XInterval
                pt = GetPointLocation(New PointF(i, 0), scW, scH)
                gBuf.DrawLine(axisPen, pt.X, pt.Y - 1, pt.X, pt.Y + 1)
            Next
            For i As Double = wState.YMin To wState.YMax Step wState.YInterval
                pt = GetPointLocation(New PointF(0, i), scW, scH)
                gBuf.DrawLine(axisPen, pt.X - 1, pt.Y, pt.X + 1, pt.Y)
            Next
            REM Graph the line
            Dim first As Boolean = True
            For Each value As PointF In Values
                curPos = GetPointFLocation(value, scW, scH)
                If first Then
                    first = False
                Else
                    gBuf.DrawLine(linePen, lastPos, curPos)
                End If
                lastPos = curPos
            Next
            REM Point of interest
            If ShowPOI And (PointOfInterest.X > wState.XMin) And (PointOfInterest.X < wState.XMax) _
                    And (PointOfInterest.Y > wState.YMin) And (PointOfInterest.Y < wState.YMax) Then
                Dim interest As Point = GetPointLocation(PointOfInterest, scW, scH)
                gBuf.FillEllipse(statusBrush, interest.X - 2, interest.Y - 2, 4, 4)
            End If
        ElseIf Mode = ScreenMode.Table Then
            REM I/O table mode
            Dim mainBrush As New SolidBrush(cScreenFG)
            Dim mainPen As New Pen(cScreenFG)
            Dim yBrush As New SolidBrush(cScreenLine)
            Dim tblFont As New Font("Courier New", 9)
            Dim hdrFont As New Font("Arial", 9, FontStyle.Bold)
            Const offX As Integer = 20
            Const offY As Integer = 20
            Const colW As Integer = 70
            Const rowH As Integer = 12
            Const tblXMax As Integer = offX + (colW * 2)
            Dim numRows As Integer = Values.Count + 1
            Dim tblYMax As Integer = offY + (rowH * numRows) + 1
            gBuf.DrawString("For a better table," & vbNewLine & "right-click and select" & vbNewLine & "Open Data in New Window", _
                            statusFont, mainBrush, tblXMax + 10, offY)
            gBuf.DrawLine(mainPen, offX, offY, tblXMax, offY)
            gBuf.DrawLine(mainPen, offX, offY, offX, tblYMax)
            gBuf.DrawLine(mainPen, offX, tblYMax, tblXMax, tblYMax)
            gBuf.DrawLine(mainPen, tblXMax, offY, tblXMax, tblYMax)
            gBuf.DrawLine(mainPen, offX, offY + rowH, tblXMax, offY + rowH)
            gBuf.DrawLine(mainPen, offX + colW, offY, offX + colW, tblYMax)
            gBuf.DrawString("X", hdrFont, mainBrush, offX, offY)
            gBuf.DrawString("Y", hdrFont, yBrush, offX + colW, offY)
            Dim yPos As Integer
            Dim oldRH As Drawing.Text.TextRenderingHint = gBuf.TextRenderingHint
            gBuf.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
            For i As Integer = 0 To Values.Count - 1
                yPos = offY + ((i + 1) * rowH)
                gBuf.DrawString(String.Format(NumberFormat, Values(i).X), tblFont, mainBrush, New Point(offX, yPos))
                gBuf.DrawString(String.Format(NumberFormat, Values(i).Y), tblFont, yBrush, New Point(offX + colW, yPos))
            Next
            gBuf.TextRenderingHint = oldRH
        End If
        gBuf.Flush()
        e.Graphics.DrawImageUnscaled(buffer, 0, 0)
    End Sub

    Private Sub PrecisionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrecisionToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(0.001, 100000, gPrecision, "Enter precision (larger number = less precise):", "Precision", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            gPrecision = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Private Sub XMinimumToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles XMinimumToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(-100000, wState.XMax, wState.XMin, "Enter minimum X value:", "Minimum X", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            wState.XMin = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Private Sub XMaximumToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles XMaximumToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(wState.XMin, 100000, wState.XMax, "Enter maximum X value:", "Maximum X", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            wState.XMax = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Private Sub XMarkerIntervalsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles XMarkerIntervalsToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(1, 100000, wState.XInterval, "Enter X axis marker interval:", "X Axis Markers", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            wState.XInterval = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Private Sub YMinimumToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YMinimumToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(-100000, wState.YMax, wState.YMin, "Enter minimum Y value:", "Minimum Y", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            wState.YMin = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Private Sub YMaximumToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YMaximumToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(wState.YMin, 100000, wState.YMax, "Enter maximum Y value:", "Maximum Y", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            wState.YMax = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Private Sub YMarkerIntervalsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles YMarkerIntervalsToolStripMenuItem.Click
        Dim nid As New Electroduck.Controls.NumericInputDialog(1, 100000, wState.YInterval, "Enter Y axis marker interval:", "Y Axis Markers", True)
        nid.DecimalPlaces = 3
        If nid.ShowDialog = Windows.Forms.DialogResult.OK Then
            wState.YInterval = nid.result
            GraphBox.Invalidate()
        End If
    End Sub

    Sub PromptForColor(ByRef c As Drawing.Color)
        ColorPicker.Color = c
        If ColorPicker.ShowDialog = Windows.Forms.DialogResult.OK Then
            c = ColorPicker.Color
        End If
        UpdateColors()
    End Sub

    Private Sub ScreenColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ScreenColorToolStripMenuItem.Click
        PromptForColor(cScreenBG)
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        PromptForColor(cBackground)
    End Sub

    Private Sub ForegroundColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ForegroundColorToolStripMenuItem.Click
        PromptForColor(cScreenFG)
    End Sub

    Private Sub BackgroundColorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles BackgroundColorToolStripMenuItem1.Click
        PromptForColor(cTextboxBG)
    End Sub

    Private Sub ForegroundColorToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ForegroundColorToolStripMenuItem1.Click
        PromptForColor(cTextboxFG)
    End Sub

    Private Sub FunctionColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FunctionColorToolStripMenuItem.Click
        PromptForColor(cScreenLine)
    End Sub

    Private Sub AntialiasedGraphToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AntialiasedGraphToolStripMenuItem.Click
        GraphBox.Invalidate()
    End Sub

    Private Sub FindY0ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindY0ToolStripMenuItem.Click
        If Values.Count > 0 Then
            For Each v As PointF In Values
                If v.Y = 0 Then
                    PointOfInterest = v
                    Status = v.ToString
                    ShowPOI = True
                    GraphBox.Invalidate()
                    Return
                End If
            Next
            MsgBox("Y=0 could not be found, try changing precision.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Else
            MsgBox(NO_VALUES, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End If
    End Sub

    Const NO_VALUES As String = "There are no values." & vbNewLine & "Evaluate an expression and try again."

    Private Sub FindMaxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindMaxToolStripMenuItem.Click
        If Values.Count > 0 Then
            Dim max As New PointF(0, SINGLE_MIN)
            For Each v As PointF In Values
                If v.Y > max.Y Then
                    max = v
                End If
            Next
            PointOfInterest = max
            Status = "MAX= " & max.ToString
            ShowPOI = True
            GraphBox.Invalidate()
        Else
            MsgBox(NO_VALUES, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub FindMinToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindMinToolStripMenuItem.Click
        If Values.Count > 0 Then
            Dim min As New PointF(0, SINGLE_MAX)
            For Each v As PointF In Values
                If v.Y > min.Y Then
                    min = v
                End If
            Next
            PointOfInterest = min
            Status = "MIN= " & min.ToString
            ShowPOI = True
            GraphBox.Invalidate()
        Else
            MsgBox(NO_VALUES, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ModeButton_Click(sender As System.Object, e As System.EventArgs) Handles ModeButton.Click
        If Mode = ScreenMode.Graphing Then
            Mode = ScreenMode.Table
            ModeButton.Text = "LINE GRAPH"
        ElseIf Mode = ScreenMode.Table Then
            Mode = ScreenMode.Graphing
            ModeButton.Text = "I/O TABLE"
        End If
        GraphBox.Invalidate()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        GraphBox.Invalidate()
    End Sub

    Function GetScreenAsBitmap(ByVal w As Integer, ByVal h As Integer) As Bitmap
        Dim bmp As New Bitmap(w, h)
        Dim gfx As Graphics = Graphics.FromImage(bmp)
        gfx.FillRectangle(New SolidBrush(cScreenBG), 0, 0, w, h)
        Dim args As New PaintEventArgs(gfx, New Rectangle(0, 0, w, h))
        GraphBox_Paint(New Object, args)
        gfx.Flush()
        Return bmp
    End Function

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetImage(GetScreenAsBitmap(500, 500))
    End Sub

    Private Sub SaveScreenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveScreenToolStripMenuItem.Click
        If SaveScreen.ShowDialog = Windows.Forms.DialogResult.OK Then
            GetScreenAsBitmap(500, 500).Save(SaveScreen.FileName, Drawing.Imaging.ImageFormat.Bmp)
        End If
    End Sub

    Public Shared Function Data2CSV(data As List(Of PointF)) As String
        Dim csv As String = ""
        csv &= "X,Y" & vbNewLine
        For Each v As PointF In data
            csv &= v.X.ToString & "," & v.Y.ToString & vbNewLine
        Next
        Return csv
    End Function

    Public Sub SaveDataTable(ByVal path As String)
        Dim ok As Boolean
attempt_save:
        ok = True
        Try
            IO.File.WriteAllText(path, Data2CSV(Values))
        Catch ex As Exception
            ok = False
            If MsgBox("Unable to save data table: " & ex.Message, MsgBoxStyle.RetryCancel + MsgBoxStyle.Critical, "Error saving") _
                    = MsgBoxResult.Retry Then GoTo attempt_save
        End Try
        If ok Then MsgBox("Data saved successfully.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "File saved")
    End Sub

    Private Sub OpenDataInNewWindowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenDataInNewWindowToolStripMenuItem.Click
        DataDialog.ShowDialog()
    End Sub
End Class

Structure Window
    Dim XMin As Double
    Dim XMax As Double
    Dim YMin As Double
    Dim YMax As Double
    Dim YInterval As Double
    Dim XInterval As Double
End Structure