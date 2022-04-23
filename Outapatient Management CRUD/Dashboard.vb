Public Class Dashboard


    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT (SELECT COUNT(*) from patient) AS Patients, (SELECT COUNT(*) from doctor) AS Doctors, (SELECT COUNT(*) from appointment) AS Appointments"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    DoctorsCount.Text = cmdread.GetString(0)
                    PatientsCount.Text = cmdread.GetString(1)
                    AppointmentsCount.Text = cmdread.GetString(2)
                Else
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
End Class