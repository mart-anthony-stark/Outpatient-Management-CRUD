Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Appointments

    Private Sub Appointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchCmbData()
        GetCurrentTime()
        FetchAppointments()
        AddControls(AppointmentTbl)
        AddLabtestBtn(AppointmentTbl)
    End Sub

    Public Sub FetchAppointments()
        reload("SELECT apt_id AS ID, concat(patient.lastname,', ', patient.firstname) AS Patient, concat(doctor.lastname,', ', doctor.firstname) AS Doctor, date AS Date, time AS Time, apt_type AS Type FROM appointment, patient, doctor", AppointmentTbl)
    End Sub

    Public Sub FetchCmbData()
        Try
            Dim patient_table As New DataTable()
            Dim patient_adapter As New MySqlDataAdapter("SELECT patient_id, concat(patient_id,'. ', lastname,', ',firstname) AS fullname FROM patient", strconn)

            Dim doctor_table As New DataTable()
            Dim doctor_adapter As New MySqlDataAdapter("SELECT doctor_id, concat(doctor_id,'. ', lastname,', ',firstname) AS fullname FROM doctor", strconn)

            patient_adapter.Fill(patient_table)
            PatientCmbBox.DataSource = patient_table
            PatientCmbBox.ValueMember = "patient_id"
            PatientCmbBox.DisplayMember = "fullname"

            doctor_adapter.Fill(doctor_table)
            DoctorsCmbBox.DataSource = doctor_table
            DoctorsCmbBox.ValueMember = "doctor_id"
            DoctorsCmbBox.DisplayMember = "fullname"

            PatientCmbBox.SelectedItem = Nothing
            DoctorsCmbBox.SelectedItem = Nothing

            'MsgBox(DoctorsCmbBox.SelectedIndex < 0)
            'MsgBox(DoctorsCmbBox.SelectedValue.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetCurrentTime()
        DateTime.Now.ToString("hh:mm tt")
        Hours.Value = CInt(DateTime.Now.ToString("hh"))
        Minutes.Value = CInt(DateTime.Now.ToString("mm"))
        ampm.SelectedIndex = ampm.FindStringExact(DateTime.Now.ToString("tt"))
    End Sub

    Private Sub CurrentTimeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentTimeBtn.Click
        GetCurrentTime()
    End Sub

    'Clear add inputs
    Private Sub ClearAddInputs()
        PatientCmbBox.SelectedItem = Nothing
        DoctorsCmbBox.SelectedItem = Nothing
        AddAptTypeInput.Text = ""
    End Sub

    Private Sub ClearAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAddBtn.Click
        ClearAddInputs()
    End Sub

    'Add new appointment record
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim patient, doctor, time, apt_type As String
        Dim hrs As Integer = Hours.Value

        If (ampm.Text.Equals("PM") And Hours.Value < 12) Then
            hrs = Hours.Value + 12
        ElseIf (ampm.Text.Equals("AM") And Hours.Value = 12) Then
            hrs = Hours.Value - 12
        End If
        time = String.Format("{0:00}:{1:00}", CInt(Math.Floor(hrs)), Minutes.Value)
        Dim apt_date As String = Format(DatePicker.Value, "yyyy-MM-dd")
        apt_type = AddAptTypeInput.Text

        If (DoctorsCmbBox.SelectedIndex < 0 Or PatientCmbBox.SelectedIndex < 0 Or String.IsNullOrEmpty(time) Or String.IsNullOrEmpty(apt_date) Or String.IsNullOrEmpty(apt_type)) Then
            MessageBox.Show("Input fields must be filled", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            patient = PatientCmbBox.SelectedValue.ToString
            doctor = DoctorsCmbBox.SelectedValue.ToString
            Try
                readuery("INSERT INTO appointment VALUES(null, '" & patient & "', '" & doctor & "', '" & apt_date & "', '" & time & "', '" & apt_type & "')")
                MsgBox("Appointment was successfully added to database")
                ClearAddInputs()
                FetchAppointments()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub DeleteAppointment(ByVal id As String)
        Dim ans As String
        ans = MsgBox("Are you sure you wamt to delete this record?", vbYesNo)
        If ans = vbYes Then
            Try
                readuery("DELETE FROM appointment WHERE apt_id=" & id)
                FetchAppointments()
                MsgBox("Appointment record was successfully deleted")
                'ClearEdit()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Search / Edit Appointment
    Private Sub SearchData(ByVal id As String)
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT apt_id, concat(doctor.lastname,', ', doctor.firstname) As doctor_name, concat(patient.lastname,', ', patient.firstname) As patient_name, date, time, apt_type FROM doctor, patient, appointment WHERE apt_id='" & id & "'"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    EditAppointment.AptId.Text = cmdread.GetString(0)
                    EditAppointment.DoctorName.Text = cmdread.GetString(1)
                    EditAppointment.PatientName.Text = cmdread.GetString(2)
                    EditAppointment.DateTimePicker.Value = cmdread.GetString(3)
                    Dim time As Array = cmdread.GetString(4).Split(":")
                    EditAppointment.AptType.Text = cmdread.GetString(5)

                    Dim suffix As String = "AM"
                    Dim hrs = time(0)
                    If (hrs >= 12) Then
                        suffix = "PM"
                    End If
                    hrs = ((hrs + 11) Mod 12 + 1)

                    EditAppointment.Hours.Value = hrs
                    EditAppointment.Minutes.Value = time(1)
                    EditAppointment.Show()
                Else
                    MsgBox("Appointment Record is not found in database using the id you specified")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub

    'Handle Inline edit and delete button
    Private Sub AppointmentTbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles AppointmentTbl.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
        Dim row As System.Windows.Forms.DataGridViewRow = AppointmentTbl.Rows(e.RowIndex)
        Dim id As String = row.Cells(3).Value.ToString
        'MsgBox(id & " - " & column.HeaderText)
        If TypeOf column Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            If (column.HeaderText Is "Edit") Then
                SearchData(id)
            ElseIf (column.HeaderText Is "Delete") Then
                DeleteAppointment(id)
            ElseIf (column.HeaderText Is "Laboratory") Then
                LabtestResult.AptID.Text = id
                LabtestResult.PatientName.Text = row.Cells(4).Value.ToString
                LabtestResult.DoctorName.Text = row.Cells(5).Value.ToString
                Main.LoadForm(LabtestResult)
            End If
        End If
    End Sub
End Class