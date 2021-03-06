Public Class Patients
    Private currentPatId As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchAllPatients()
        AddControls(PatientDataGrid)
    End Sub

    'Handles add patient'
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim firstname, lastname, dob, sex, contact As String
        firstname = FirstnameBox.Text
        lastname = LastnameBox.Text
        dob = Format(DOBPicker.Value, "yyyy-MM-dd")
        If (MaleRadio.Checked) Then
            sex = "M"
        ElseIf (FemaleRadio.Checked) Then
            sex = "F"
        End If
        contact = ContactBox.Text
        If (String.IsNullOrEmpty(firstname) Or String.IsNullOrEmpty(lastname) Or String.IsNullOrEmpty(dob) Or String.IsNullOrEmpty(sex) Or String.IsNullOrEmpty(contact)) Then
            MsgBox("You must fill all input fields to add")
        Else
            Try
                readuery("INSERT INTO patient VALUES(null, '" & firstname & "', '" & lastname & "', '" & dob & "', '" & sex & "', '" & contact & "')")
                MsgBox("Patient was successfully added to database")
                FetchAllPatients()
                FirstnameBox.Text = ""
                LastnameBox.Text = ""
                MaleRadio.Checked = False
                FemaleRadio.Checked = False
                ContactBox.Text = ""
                Appointments.FetchCmbData()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Handle query for searching patient and populating edit field
    Private Sub SearchData(ByVal id As String)
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT * FROM patient WHERE patient_id=" & id
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    currentPatId = cmdread.GetString(0)
                    EditFname.Text = cmdread.GetString(1)
                    EditLname.Text = cmdread.GetString(2)
                    EditDOB.Value = cmdread.GetDateTime(3)
                    If (cmdread.GetString(4).Equals("M")) Then
                        EditMaleRadio.Checked = True
                    Else
                        EditFemaleRadio.Checked = True
                    End If
                    EditContact.Text = cmdread.GetString(5)
                    ToggleBtns()
                Else
                    MsgBox("Patient is not found in database using the id you specified")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub

    'Handle Delete query'
    Private Sub deletePatient(ByVal id As String)
        Dim ans As String
        ans = MsgBox("Records in other table that needs this details will also be deleted. Are you sure you wamt to delete this record?", vbYesNo)
        If ans = vbYes Then
            Try
                readuery("DELETE FROM appointment WHERE patient=" & id)
                readuery("DELETE FROM patient WHERE patient_id=" & id)
                FetchAllPatients()
                MsgBox("Patient record was successfully deleted")
                ClearEdit()
                Appointments.FetchCmbData()
                Appointments.FetchAppointments()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Clears add fields'
    Private Sub CancelAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelAddBtn.Click
        FirstnameBox.Text = ""
        LastnameBox.Text = ""
        ContactBox.Text = ""
        MaleRadio.Checked = False
        FemaleRadio.Checked = False
        currentPatId = Nothing
        ToggleBtns()
    End Sub

    'Toggles edit buttons visbility (save, delete, cancel) '
    Private Sub ToggleBtns()
        Dim state As Boolean = Not String.IsNullOrEmpty(currentPatId)
        EditCancelBtn.Visible = state
        DeleteBtn.Visible = state
        EditSaveBtn.Visible = state
    End Sub

    Private Sub EditCancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditCancelBtn.Click
        ClearEdit()
    End Sub

    'Removes current patient id to be edited; Clears edit fields; Hides edit buttons'
    Private Sub ClearEdit()
        currentPatId = Nothing
        EditFname.Text = ""
        EditLname.Text = ""
        EditContact.Text = ""
        EditDOB.Value = Today
        EditFemaleRadio.Checked = False
        EditMaleRadio.Checked = False
        SearchBox.Text = ""
        ToggleBtns()
    End Sub

    'Handles updating data for specific patient row'
    Private Sub EditSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSaveBtn.Click
        Dim fname, lname, dob, sex, contact As String
        fname = EditFname.Text
        lname = EditLname.Text
        dob = Format(EditDOB.Value, "yyyy-MM-dd")
        If (EditMaleRadio.Checked) Then
            sex = "M"
        ElseIf (EditFemaleRadio.Checked) Then
            sex = "F"
        End If
        contact = EditContact.Text
        If (String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(lname) Or String.IsNullOrEmpty(dob) Or String.IsNullOrEmpty(sex) Or String.IsNullOrEmpty(contact)) Then
            MsgBox("You must fill all input fields to save record")
        Else
            Try
                readuery("UPDATE patient SET firstname='" & fname & "', lastname='" & lname & "', date_of_birth='" & dob & "', sex='" & sex & "', contact_number='" & contact & "' WHERE patient_id=" & currentPatId & "")
                MsgBox("Patient record was successfully updated")
                FetchAllPatients()
                ClearEdit()
                Appointments.FetchCmbData()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        deletePatient(currentPatId)
    End Sub

    'Get all patient data in db'
    Private Sub FetchAllPatients()
        Try
            reload("SELECT patient_id AS ID, concat(firstname, ' ',lastname) AS Name, date_of_birth AS 'Date of Birth', sex AS Sex, contact_number AS Contact FROM patient", PatientDataGrid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Method that handles edit or delete click in datagrid
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles PatientDataGrid.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
            Dim row As System.Windows.Forms.DataGridViewRow = PatientDataGrid.Rows(e.RowIndex)
            Dim id As String = row.Cells(2).Value.ToString
            If TypeOf column Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 Then
                'TODO - Button Clicked - Execute Code Here
                If (column.HeaderText Is "Edit") Then
                    SearchData(id)
                ElseIf (column.HeaderText Is "Delete") Then
                    deletePatient(id)
                End If
            End If
        Catch ex As Exception

        End Try
        

    End Sub

    'Search name or id
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            reload("SELECT patient_id AS ID, concat(firstname, ' ',lastname) AS Name, date_of_birth AS 'Date of Birth', sex AS Sex, contact_number AS Contact FROM patient WHERE patient_id='" & SearchBox.Text & "' OR firstname='" & SearchBox.Text & "' OR lastname='" & SearchBox.Text & "'", PatientDataGrid)
        Catch ex As Exception

        End Try
    End Sub

    'Refresh
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        SearchBox.Text = ""
        FetchAllPatients()
    End Sub
End Class
