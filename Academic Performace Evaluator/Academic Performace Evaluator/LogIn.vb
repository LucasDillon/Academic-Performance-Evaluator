Imports System.Data.OleDb
Public Class frm_logIn
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source =E:\!Colllege\Computer Science\Year 2\NEA\Solutions\apeDatabase.accdb"
    Public userID As Integer
    Public selectedClassID As Integer
    Private Sub btn_logIn_Click(sender As Object, e As EventArgs) Handles btn_logIn.Click

        Dim found As String

        If tbx_teacherIdEntry.Text = "" Or tbx_passwordEntry.Text = "" Then 'Ensures the entry boxes contain data. 

            MsgBox("Please Enter All Details")

        Else

            found = checkDetails()

            If found = "userIdInvalid" Then

                MsgBox("Invalid Teacher ID")
                tbx_teacherIdEntry.Clear()
                tbx_passwordEntry.Clear()

            ElseIf found = "noUserId" Then

                MsgBox("Teacher ID Not Found")
                tbx_teacherIdEntry.Clear()
                tbx_passwordEntry.Clear()

            ElseIf found = "noPassword" Then

                MsgBox("Password Incorrect")
                tbx_passwordEntry.Clear()

            ElseIf found = "yes" Then

                MsgBox("Log In Successful")
                userID = tbx_teacherIdEntry.Text
                openMenu()

            End If

        End If
    End Sub
    Function checkDetails()
        Dim found As String
        Dim password As String = ""
        Dim enteredId As Integer

        Try 'In case tbx_teacherIdEntry does not contain integer.
            enteredId = tbx_teacherIdEntry.Text
        Catch
            found = "userIdInvalid"
            Return found
        End Try

        Dim SQLStatementFindPassword As String = ("SELECT password FROM tbl_teachers WHERE teacherId=" & enteredId & ";") 'Finds password that corrosponds to entered ID.
        Dim conn As New OleDbConnection(connectionString) 'Creates connection object.
        Dim commamd As New OleDbCommand(SQLStatementFindPassword) 'Creates command object.
        commamd.Connection = conn
        conn.Open() 'Opens connection.

        Dim reader As OleDbDataReader

        reader = commamd.ExecuteReader()

        Do While reader.Read()

            password = reader.Item(0)

        Loop

        conn.Close() 'Closes connection.

        If password = tbx_passwordEntry.Text Then

            found = "yes"

        ElseIf password = "" Then

            found = "noUserId"

        Else

            found = "noPassword"

        End If

        Return found
    End Function
    Sub openMenu()
        Dim newForm As New frm_menu
        newForm.StartPosition = FormStartPosition.Manual
        newForm.DesktopLocation = Me.DesktopLocation 'Set frm_menu location the same as current form.
        Me.Hide() 'Hides Current form (frm_logIn).
        newForm.Show() 'Opens frm_menu.
    End Sub
End Class