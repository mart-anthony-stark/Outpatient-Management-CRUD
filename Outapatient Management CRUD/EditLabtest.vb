Public Class EditLabtest

    Private Sub EditSaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSaveBtn.Click
        Dim name As String = TestName.Text
        Dim type As String = TestType.Text
        Dim t_cost As String = Cost.Value
        Dim desc As String = Description.Text

        If (String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(type) Or String.IsNullOrEmpty(desc)) Then
            MessageBox.Show("Input fields must be filled", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                readuery("UPDATE laboratorytest SET test_name='" & name & "', test_type='" & type & "', description='" & desc & "', cost='" & t_cost & "' WHERE test_id=" & idText.Text)
                MsgBox("Laboratory test record was added successfully")
                ClearLabtest()
                Laboratory.FetchLabTests()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditLabtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    'Clear labtest inputs
    Private Sub ClearLabtest()
        TestName.Text = Nothing
        TestType.SelectedValue = Nothing
        Description.Text = Nothing
        Cost.Value = 0
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Me.Close()
    End Sub
End Class