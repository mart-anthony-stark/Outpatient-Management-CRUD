Public Class EditDiseaseForm

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub EditDiseaseForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DisName.Text = ""
        DisDescription.Text = ""
        DisType.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim name As String = DisName.Text
        Dim desc As String = DisDescription.Text
        Dim type As String = DisType.Text
        If (String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(desc) Or String.IsNullOrEmpty(type)) Then
            MessageBox.Show("Input fields must be filled", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                readuery("UPDATE disease SET name='" & name & "', description='" & desc & "', type='" & type & "' WHERE disease_id=" & idText.Text)
                MsgBox("Record was updated successfully")
                Laboratory.FetchDiseases()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class