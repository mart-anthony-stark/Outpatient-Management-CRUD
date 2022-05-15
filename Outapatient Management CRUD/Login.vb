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
            Try
                strconn.Open()
                With cmd
                    .Connection = strconn
                    .CommandText = "SELECT * FROM admin WHERE email='" & email & "'"
                    cmdread = .ExecuteReader
                    If (cmdread.Read()) Then
                        Dim id = cmdread.GetString(0)
                        Dim fname = cmdread.GetString(1)
                        Dim lname = cmdread.GetString(2)
                        Dim _email = cmdread.GetString(3)
                        Dim _pass = cmdread.GetString(4)
                        Dim pass As String = Crypto.Decrypt(_pass, "supersecretstring")
                        'Check equality of passwords
                        If (Not pass.Equals(password)) Then
                            MessageBox.Show("Incorrect password", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            strconn.Close()
                            MsgBox("Logged in Successfully")
                            EmailBox.Text = ""
                            PasswordBox.Text = ""
                            AdminSettings.userID.Text = id
                            AdminSettings.firstname.Text = fname
                            AdminSettings.lastname.Text = lname
                            AdminSettings.email.Text = _email
                            UserPassword = _pass
                            Me.Hide()
                            Main.Show()
                        End If
                    Else
                        MessageBox.Show("The email you entered is not found in the database", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            strconn.Close()
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Signup.Show()
        Me.Hide()
    End Sub
End Class