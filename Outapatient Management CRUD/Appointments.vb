Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Appointments

    Private Sub Appointments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchCmbData()
        GetCurrentTime()
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
    Private Sub ClearAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAddBtn.Click
        PatientCmbBox.SelectedItem = Nothing
        DoctorsCmbBox.SelectedItem = Nothing
        AddAptTypeInput.Text = ""
    End Sub
End Class