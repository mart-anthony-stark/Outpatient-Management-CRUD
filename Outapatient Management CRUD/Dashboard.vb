Public Class Dashboard


    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchData()
        FetchLastAppointment()
    End Sub

    Private Sub FetchData()
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT (SELECT COUNT(*) from patient) AS Patients, (SELECT COUNT(*) from doctor) AS Doctors, (SELECT COUNT(*) from appointment) AS Appointments, (SELECT COUNT(*) from laboratorytest) AS Labtests"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    DoctorsCount.Text = cmdread.GetString(1)
                    PatientsCount.Text = cmdread.GetString(0)
                    AppointmentsCount.Text = cmdread.GetString(2)
                    TestCount.Text = cmdread.GetString(3)
                Else
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub

    Private Sub FetchLastAppointment()
        'select apt_id, concat(patient.lastname,', ', patient.firstname) AS Patient, concat(doctor.lastname,', ', doctor.firstname) AS Doctor, date, time, apt_type from appointment, doctor, patient WHERE patient_id=appointment.patient order by apt_id DESC LIMIT 1;
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "select apt_id, concat(patient.lastname,', ', patient.firstname) AS Patient, concat(doctor.lastname,', ', doctor.firstname) AS Doctor, date, time, apt_type from appointment, doctor, patient WHERE patient_id=appointment.patient order by apt_id DESC LIMIT 1"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    PatientName.Text = cmdread.GetString(1)
                    DoctorName.Text = cmdread.GetString(2)
                    DateText.Text = cmdread.GetString(3).Split(" ")(0)
                    TimeText.Text = cmdread.GetString(4)
                    AppointmentType.Text = cmdread.GetString(5)
                Else
                    MsgBox("No appt")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main.LoadForm(Doctors)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Main.LoadForm(Doctors)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Main.LoadForm(Doctors)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.LoadForm(Patients)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main.LoadForm(Appointments)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Main.LoadForm(Laboratory)
    End Sub

    'Refresh
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        FetchData()
        FetchLastAppointment()
    End Sub
End Class