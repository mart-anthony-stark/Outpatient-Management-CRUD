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
                        Dim pass As String = (cmdread.GetString(4))
                        'Check equality of passwords
                        If (Not pass.Equals(password)) Then
                            MessageBox.Show("Incorrect password", "Incorrect Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            strconn.Close()
                            MsgBox("Logged in Successfully")
                            EmailBox.Text = ""
                            PasswordBox.Text = ""
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
End Class