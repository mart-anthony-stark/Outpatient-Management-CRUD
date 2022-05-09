Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim email, password As String
        email = EmailBox.Text
        password = PasswordBox.Text
        If (String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password)) Then
            MessageBox.Show("Please enter your email and password", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MsgBox("Logged in")
            Me.Hide()
            Main.Show()
        End If
    End Sub
End Class