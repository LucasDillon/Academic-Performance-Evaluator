Imports System.Data.OleDb
Public Class frm_createClass
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        openMenu()
    End Sub
    Private Sub btn_createClass_Click(sender As Object, e As EventArgs) Handles btn_createClass.Click

        If checkInputs() = False Then
            Exit Sub
        End If

        saveClassToDatabase()
        openMenu()
    End Sub
    Function checkInputs()
        Dim valid As Boolean = False

        If tbx_classNameEntryBox.Text = "" And tbx_classSubjectEntryBox.Text = "" Then
            MsgBox("Nothing Entered")

        ElseIf tbx_classNameEntryBox.Text = "" Then
            MsgBox("No Class Name Entered")

        ElseIf tbx_classSubjectEntryBox.Text = "" Then
            MsgBox("No Class Subject Entered")

        ElseIf tbx_classNameEntryBox.Text.Contains("(") Or tbx_classNameEntryBox.Text.Contains(")") Or tbx_classSubjectEntryBox.Text.Contains("(") Or tbx_classSubjectEntryBox.Text.Contains(")") Then
            MsgBox("Cannot Contain Brackets") 'Avoiding potential issues with lbx_classList in frm_menu

        ElseIf tbx_classNameEntryBox.Text.Length < 2 Then
            MsgBox("Class Name is Too Small")

        ElseIf tbx_classSubjectEntryBox.Text.Length < 2 Then
            MsgBox("Class Subject is Too Small")

        Else
            valid = True

        End If

        Return valid
    End Function
    Sub saveClassToDatabase()
        Dim SQLStatement As String = "INSERT INTO tbl_classes (teacherID,className,classSubject) values ('" & frm_logIn.userID & "', '" & tbx_classNameEntryBox.Text & "','" & tbx_classSubjectEntryBox.Text & "');"
        Dim connectionString As String = frm_logIn.connectionString
        Dim conn As New OleDbConnection(connectionString) 'Creates connection object.
        Dim commamd As New OleDbCommand(SQLStatement) 'Creates command object.
        Dim rowsAffected As Integer = 0

        commamd.Connection = conn
        conn.Open() 'Opens connection.

        rowsAffected = commamd.ExecuteNonQuery 'Executes command and finds number of rows affected.

        If rowsAffected > 0 Then
            MsgBox("Class Created")
        Else
            MsgBox("Failure")
        End If

    End Sub
    Sub openMenu()
        Dim newForm As New frm_menu
        newForm.StartPosition = FormStartPosition.Manual
        newForm.DesktopLocation = Me.DesktopLocation 'Set frm_menu location the same as current form.
        Me.Hide() 'Hides Current form (frm_createClass).
        newForm.Show() 'Opens frm_menu.
    End Sub
End Class