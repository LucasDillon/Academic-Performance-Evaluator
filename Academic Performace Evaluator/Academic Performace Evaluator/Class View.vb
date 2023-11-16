Imports System.Data.OleDb
Public Class frm_classView
    Public userID As Integer
    Public classID As Integer
    Private Sub frm_classView_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown  'When form is opened.
        userID = frm_logIn.userID
        classID = frm_logIn.selectedClassID
        MsgBox("useID " & userID)
        MsgBox("classID " & classID)
    End Sub
    Private Sub btn_toMenu_Click(sender As Object, e As EventArgs) Handles btn_toMenu.Click
        openMenu()
    End Sub
    Private Sub btn_removeClass_Click(sender As Object, e As EventArgs) Handles btn_removeClass.Click
        Dim SQLStatement As String = "DELETE * FROM tbl_classes WHERE tbl_classes.classID=" & classID & ";" 'Deletes all records with current ClassID.
        Dim connectionString As String = frm_logIn.connectionString
        Dim conn As New OleDbConnection(connectionString) 'Creates connection object.
        Dim commamd As New OleDbCommand(SQLStatement) 'Creates command object.
        Dim rowsAffected As Integer = 0

        commamd.Connection = conn
        conn.Open() 'Opens connection.

        rowsAffected = commamd.ExecuteNonQuery 'Executes command and finds number of rows affected.

        conn.Close()

        If rowsAffected > 0 Then
            MsgBox("Class Removed")
            openMenu()
        Else
            MsgBox("Failure")
        End If
    End Sub
    Sub openMenu()
        Dim newForm As New frm_menu
        newForm.StartPosition = FormStartPosition.Manual
        newForm.DesktopLocation = Me.DesktopLocation 'Set frm_menu location the same as current form.
        Me.Hide() 'Hides Current form (frm_classView).
        newForm.Show() 'Opens frm_menu.
    End Sub
End Class