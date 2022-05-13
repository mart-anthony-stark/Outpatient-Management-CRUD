Public Class EditAppointment

    Private Sub EditAppointment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub EditSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSaveBtn.Click
        Dim hrs As Integer = Hours.Value

        If (AMPM.Text.Equals("PM") And Hours.Value < 12) Then
            hrs = Hours.Value + 12
        ElseIf (AMPM.Text.Equals("AM") And Hours.Value = 12) Then
            hrs = Hours.Value - 12
        End If
        Dim time As String = String.Format("{0:00}:{1:00}", CInt(Math.Floor(hrs)), Minutes.Value)
        Dim apt_date As String = Format(DateTimePicker.Value, "yyyy-MM-dd")
        Dim apt_type As String = AptType.Text

        If (String.IsNullOrEmpty(time) Or String.IsNullOrEmpty(apt_date) Or String.IsNullOrEmpty(apt_type)) Then
            MessageBox.Show("Input fields must not be empty", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                readuery("UPDATE appointment SET date='" & apt_date & "', time='" & time & "', apt_type='" & apt_type & "' WHERE apt_id=" & AptId.Text & "")
                MsgBox("Appointment record was successfully updated")
                Appointments.FetchAppointments()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DeleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        Appointments.DeleteAppointment(AptId.Text)
        Me.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class