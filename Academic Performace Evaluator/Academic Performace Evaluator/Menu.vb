Imports System.Data.OleDb
Public Class frm_menu
    Public connectionString As String
    Private Sub frm_menu_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown 'When form is opened.
        Dim userID
        connectionString = frm_logIn.connectionString
        userID = frm_logIn.userID
        getClasses(userID)
    End Sub
    Sub getClasses(userID As Integer)
        lbx_classList.Items.Clear()

        Dim SQLStatement As String = ("SELECT * FROM tbl_classes WHERE teacherID=" & userID & ";")

        Dim conn As New OleDbConnection(connectionString) 'Creates connection object.
        Dim commamd As New OleDbCommand(SQLStatement) 'Creates command object.
        commamd.Connection = conn
        conn.Open() 'Opens connection.

        Dim reader As OleDbDataReader
        reader = commamd.ExecuteReader()

        Do While reader.Read()

            lbx_classList.Items.Add(reader(2).ToString() & "   (" & reader(3).ToString() & ")") 'Adds items to lbx_classList

        Loop

        conn.Close() 'Closes connection.

    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
    Private Sub btn_viewClass_Click(sender As Object, e As EventArgs) Handles btn_viewClass.Click

        If lbx_classList.SelectedItems.Count = 0 Then 'Checks item from lbx_classList has been selected.
            MsgBox("No Class Selected")
            Exit Sub
        End If

        Dim selectedClassID As Integer
        Dim selectedClass As String
        Dim selectedClassArr() As String

        selectedClass = lbx_classList.SelectedItem
        selectedClassArr = Split(selectedClass, "   (") 'Splits className and classSubject apart. Note this means no className can contain "   (".
        selectedClass = selectedClassArr(0)


        selectedClassID = findClassID(selectedClass)
        frm_logIn.selectedClassID = selectedClassID

        openClassView()
    End Sub
    Function findClassID(className As String)
        Dim desiredClassID As Integer

        Dim SQLStatement As String = ("SELECT classID FROM tbl_classes WHERE className='" & className & "';")

        Dim conn As New OleDbConnection(connectionString) 'Creates connection object.
        Dim commamd As New OleDbCommand(SQLStatement) 'Creates command object.
        commamd.Connection = conn
        conn.Open() 'Opens connection.

        Dim reader As OleDbDataReader
        reader = commamd.ExecuteReader()

        Do While reader.Read()

            desiredClassID = reader.Item(0)

        Loop

        conn.Close() 'Closes connection.

        Return desiredClassID
    End Function
    Sub openClassView()
        Dim newForm As New frm_classView
        newForm.StartPosition = FormStartPosition.Manual
        newForm.DesktopLocation = Me.DesktopLocation 'Set frm_classView location the same as current form.
        Me.Hide() 'Hides Current form (frm_menu).
        newForm.Show() 'Opens frm_classView.
    End Sub
    Private Sub btn_createClass_Click(sender As Object, e As EventArgs) Handles btn_createClass.Click
        openCreateClass()
    End Sub
    Sub openCreateClass()
        Dim newForm As New frm_createClass
        newForm.StartPosition = FormStartPosition.Manual
        newForm.DesktopLocation = Me.DesktopLocation 'Set frm_createClass location the same as current form.
        Me.Hide() 'Hides Current form (frm_menu).
        newForm.Show() 'Opens frm_createClass.
    End Sub
End Class