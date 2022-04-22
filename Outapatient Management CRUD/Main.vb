Public Class Main
    Dim activePanel As String

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Dashboard)
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeBtn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Public Sub LoadForm(ByVal form As Form)
        Me.PanelContainer.Controls.Clear()
        activePanel = form.Name
        RefreshBtnsStyles()
        form.TopLevel = False
        form.TopMost = True
        Me.PanelContainer.Controls.Add(form)
        form.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientsBtn.Click
        LoadForm(Patients)
    End Sub

    Private Sub DoctorsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorsBtn.Click
        LoadForm(Doctors)
    End Sub

    Private Sub RefreshBtnsStyles()
        DashboardBtn.BackColor = Color.FromArgb(255, 255, 255)
        PatientsBtn.BackColor = Color.FromArgb(255, 255, 255)
        AppointmentsBtn.BackColor = Color.FromArgb(255, 255, 255)
        DoctorsBtn.BackColor = Color.FromArgb(255, 255, 255)

        If (activePanel.Equals("Dashboard")) Then
            DashboardBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Patients")) Then
            PatientsBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Doctors")) Then
            DoctorsBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Appointment")) Then
            AppointmentsBtn.BackColor = Color.FromArgb(239, 243, 246)
        End If
    End Sub

    Private Sub DashboardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardBtn.Click
        LoadForm(Dashboard)
    End Sub
End Class