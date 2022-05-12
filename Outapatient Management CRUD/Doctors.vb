Public Class Doctors
    Private currentPatId As String

    Private Sub Doctors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchData()
        AddControls(DoctorDataGridView)
        ToggleBtns()
    End Sub

    Private Sub FetchData()
        Try
            reload("SELECT doctor_id AS ID, concat(lastname, ', ', firstname) AS Name, specialization AS Specialization, contact_number AS 'Contact Number' from doctor", DoctorDataGridView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Handle Add doctor record'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim lname, fname, specialization, contact As String
        fname = AddFname.Text
        lname = AddLname.Text
        specialization = AddSpec.Text
        contact = AddContact.Text

        If (String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(lname) Or String.IsNullOrEmpty(specialization) Or String.IsNullOrEmpty(contact)) Then
            MsgBox("All fields are required to be filled")
        Else
            readuery("INSERT INTO doctor VALUES(null, '" & fname & "', '" & lname & "', '" & contact & "', '" & specialization & "')")
            FetchData()
            MsgBox("Doctor successfully added to record")
            ClearAddFields()
            Appointments.FetchCmbData()
        End If
    End Sub

    'Clear add fields'
    Private Sub ClearAddFields()
        AddFname.Text = ""
        AddLname.Text = ""
        AddSpec.Text = ""
        AddContact.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClearAddFields()
    End Sub

    'Toggles edit buttons visbility (sav, delete, cancel) '
    Private Sub ToggleBtns()
        Dim state As Boolean = Not String.IsNullOrEmpty(currentPatId)
        EditDeleteBtn.Visible = state
        EditCancelBtn.Visible = state
        EditSaveBtn.Visible = state
    End Sub

    'Clears edit fields'
    Private Sub ClearEditFields()
        currentPatId = Nothing
        EditFname.Text = ""
        EditLname.Text = ""
        EditContact.Text = ""
        EditSpecialization.Text = ""
        ToggleBtns()
    End Sub

    Private Sub SearchData(ByVal id As String)
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT * FROM doctor WHERE doctor_id='" & id & "'"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    currentPatId = cmdread.GetString(0)
                    EditFname.Text = cmdread.GetString(1)
                    EditLname.Text = cmdread.GetString(2)
                    EditSpecialization.Text = cmdread.GetString(4)
                    EditContact.Text = cmdread.GetString(3)
                    ToggleBtns()
                Else
                    MsgBox("Doctor is not found in database using the id you specified")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub


    'Method that handles edit or delete click in datagrid
    Private Sub DoctorDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DoctorDataGridView.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
        Dim row As System.Windows.Forms.DataGridViewRow = DoctorDataGridView.Rows(e.RowIndex)
        Dim id As String = row.Cells(2).Value.ToString
        If TypeOf column Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            If (column.HeaderText Is "Edit") Then
                SearchData(id)
            ElseIf (column.HeaderText Is "Delete") Then
                DeleteDoctor(id)
            End If
        End If
    End Sub

    Private Sub EditCancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCancelBtn.Click
        ClearEditFields()
    End Sub

    'Handle save edit doctor'
    Private Sub EditSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSaveBtn.Click
        Dim fname, lname, specialization, contact As String
        fname = EditFname.Text
        lname = EditLname.Text
        specialization = EditSpecialization.Text
        contact = EditContact.Text
        If (String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(lname) Or String.IsNullOrEmpty(specialization) Or String.IsNullOrEmpty(contact)) Then
            MsgBox("All fields are required to be filled")
        Else
            readuery("UPDATE doctor SET firstname='" & fname & "', lastname='" & lname & "', contact_number='" & contact & "', specialization='" & specialization & "' WHERE doctor_id=" & currentPatId)
            FetchData()
            ClearEditFields()
            MsgBox("Record was updated successfully")
            Appointments.FetchCmbData()
        End If
    End Sub

    'Handle delete doctor record'
    Private Sub DeleteDoctor(ByVal id As String)
        Dim ans As String
        ans = MsgBox("Records in other table that needs this info will also be deleted. Are you sure you want to delete this record?", vbYesNo)
        If ans = vbYes Then
            Try
                readuery("DELETE FROM appointment WHERE doctor=" & id)
                readuery("DELETE FROM doctor WHERE doctor_id=" & id)
                FetchData()
                ClearEditFields()
                MsgBox("Doctor record was successfully deleted")
                Appointments.FetchCmbData()
                Appointments.FetchAppointments()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditDeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDeleteBtn.Click
        DeleteDoctor(currentPatId)
    End Sub
End Class