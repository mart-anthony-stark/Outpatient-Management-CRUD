Public Class Main
    Dim activePanel As String

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DigitalClock.Text = TimeOfDay
        DateTxt.Text = Today
        LoadForm(Dashboard)
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub MinimizeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        LaboratoryBtn.BackColor = Color.FromArgb(255, 255, 255)

        If (activePanel.Equals("Dashboard")) Then
            DashboardBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Patients")) Then
            PatientsBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Doctors")) Then
            DoctorsBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Appointments")) Then
            AppointmentsBtn.BackColor = Color.FromArgb(239, 243, 246)
        ElseIf (activePanel.Equals("Laboratory")) Then
            LaboratoryBtn.BackColor = Color.FromArgb(239, 243, 246)
        End If
    End Sub

    Private Sub DashboardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardBtn.Click
        LoadForm(Dashboard)
    End Sub

    Private Sub AppointmentsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppointmentsBtn.Click
        LoadForm(Appointments)
    End Sub

    Private Sub ClockTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClockTimer.Tick
        DigitalClock.Text = TimeOfDay
    End Sub

    'Logout'
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans As String
        ans = MsgBox("Are you sure you wamt to log out?", vbYesNo)
        If ans = vbYes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    'Exit'
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    'Minimize'
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        WindowState = FormWindowState.Minimized

    End Sub

    'Laboratory'
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaboratoryBtn.Click
        LoadForm(Laboratory)
    End Sub
End Class