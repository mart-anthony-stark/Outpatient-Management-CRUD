Public Class Signup

    Private Sub Signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Signup
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fname, lname, email, password As String
        fname = FnameBox.Text
        lname = LnameBox.Text
        email = EmailBox.Text
        password = PasswordBox.Text

        If (String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(lname) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password)) Then
            MessageBox.Show("All fields are required to be filled", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (password.Length < 8) Then
            MessageBox.Show("Your password must be at least 8 characters long", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Check if email exists
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT * FROM admin WHERE email='" & email & "'"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    MessageBox.Show("The email you entered is already registered. Please enter different email", "Email Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'Hash password
                    strconn.Close()
                    Dim hashedPass As String = Crypto.Encrypt(password, "supersecretstring")
                    readuery("INSERT INTO admin VALUES(null, '" & fname & "', '" & lname & "', '" & email & "', '" & hashedPass & "')")
                    MessageBox.Show("Account created successfully", "Signup Successfull", MessageBoxButtons.OK, MessageBoxIcon.None)

                    Me.Hide()
                    Login.Show()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        strconn.Close()
    End Sub
End Class