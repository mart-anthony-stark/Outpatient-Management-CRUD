Public Class Home
    Dim activePanel As String

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeBtn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LoadForm(ByVal form As Form)
        Me.PanelContainer.Controls.Clear()
        activePanel = form.Name
        RefreshBtnsStyles()
        form.TopLevel = False
        form.TopMost = True
        Me.PanelContainer.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatentsBtn.Click
        LoadForm(Patients)
    End Sub

    Private Sub DoctorsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorsBtn.Click
        LoadForm(Doctors)
    End Sub

    Private Sub RefreshBtnsStyles()
        MsgBox(activePanel)
    End Sub
End Class