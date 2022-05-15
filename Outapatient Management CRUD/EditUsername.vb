Public Class EditUsername

    Private Sub EditNameBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNameBtn.Click
        Dim fname As String = FirstnameBox.Text
        Dim lname As String = LastnameBox.Text

        If (String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(lname)) Then
            MessageBox.Show("All fields must be filled", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                readuery("UPDATE admin SET firstname='" & fname & "', lastname='" & lname & "' WHERE admin_id=" & AdminSettings.userID.Text)
                MsgBox("Username and email was updated successfully")
                AdminSettings.firstname.Text = fname
                AdminSettings.lastname.Text = lname
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub EditUsername_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class