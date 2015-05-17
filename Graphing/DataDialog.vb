Imports System.Windows.Forms

Public Class DataDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub DataDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataTable.Rows.Clear()
        Me.BackColor = MainForm.cBackground
        OK_Button.BackColor = MainForm.cScreenBG
        OK_Button.ForeColor = MainForm.cScreenFG
        SaveButton.BackColor = MainForm.cScreenBG
        SaveButton.ForeColor = MainForm.cScreenFG
        DataTable.BackgroundColor = MainForm.cTextboxBG
        DataTable.ForeColor = Color.Black
        DataTable.Font = New Font("Courier New", 9)
        For Each value As PointF In MainForm.Values
            Const fmt As String = "{0,12:0.0000}"
            DataTable.Rows.Add(String.Format(fmt, value.X), String.Format(fmt, value.Y))
        Next
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        If SaveData.ShowDialog = Windows.Forms.DialogResult.OK Then
            MainForm.SaveDataTable(SaveData.FileName)
        End If
    End Sub
End Class
