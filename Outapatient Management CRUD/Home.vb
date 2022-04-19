Public Class Home

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Patients.TopLevel = False
        Patients.TopMost = True
        Me.PanelContainer.Controls.Add(Patients)
        Patients.Show()
    End Sub
End Class