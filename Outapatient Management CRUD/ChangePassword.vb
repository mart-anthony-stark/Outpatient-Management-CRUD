Public Class ChangePassword

    Private Sub EditNameBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNameBtn.Click
        Dim current As String = CurrentPassword.Text
        Dim newPass As String = NewPassword.Text
        Dim confirm As String = ConfirmPassword.Text


        If (String.IsNullOrEmpty(current) Or String.IsNullOrEmpty(newPass) Or String.IsNullOrEmpty(confirm)) Then
            MessageBox.Show("All fields must be filled", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (Not current.Equals(Crypto.Decrypt(UserPassword, "supersecretstring"))) Then
            MessageBox.Show("Your inputted password does not match to your current password", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (newPass.Length < 8) Then
            MessageBox.Show("Passwords must be at least 8 characters long", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (Not newPass.Equals(confirm)) Then
            MessageBox.Show("Passwords do not match", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim hashedPass = Crypto.Encrypt(newPass, "supersecretstring")
            readuery("UPDATE admin SET password='" & hashedPass & "' WHERE admin_id=" & AdminSettings.userID.Text)
            MsgBox("User password was updated successfully")
            UserPassword = hashedPass
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
End Class