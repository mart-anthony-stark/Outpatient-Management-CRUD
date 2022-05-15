Public Class AdminSettings

    'Delete account
    Private Sub ClearAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAddBtn.Click
        Dim ans As String
        ans = MsgBox("Are you sure you wamt to delete your account?", vbYesNo)
        If ans = vbYes Then
            Try
                readuery("DELETE FROM admin WHERE admin_id=" & userID.Text)
                MsgBox("Account was successfully deleted")
                Login.Show()
                Main.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Edit name and email
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditNameBtn.Click
        EditUsername.FirstnameBox.Text = firstname.Text
        EditUsername.LastnameBox.Text = lastname.Text
        EditUsername.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ChangePassword.Show()
    End Sub
End Class