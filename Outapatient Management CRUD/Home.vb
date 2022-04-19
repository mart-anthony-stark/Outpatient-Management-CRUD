Public Class Home

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Patients.TopLevel = False
        Patients.TopMost = True
        Me.PanelContainer.Controls.Add(Patients)
        Patients.Show()
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeBtn.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class