﻿Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            'readuery("INSERT INTO patient VALUES(null, 'Juan', 'Dela Cruz', '2001-09-21', 'M', '09123456789')")'
            reload("SELECT patient_id AS ID, concat(firstname, ' ',lastname) AS Name, date_of_birth AS 'Date of Birth', sex AS Sex, contact_number AS Contact FROM patient", PatientDataGrid)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim firstname, lastname, dob, sex, contact As String
        firstname = FirstnameBox.Text
        lastname = LastnameBox.Text
        dob = Format(DOBPicker.Value, "yyyy-MM-dd")
        If (MaleRadio.Checked) Then
            sex = "M"
        ElseIf (FemaleRadio.Checked) Then
            sex = "F"
        End If
        contact = ContactBox.Text
        If (String.IsNullOrEmpty(firstname) Or String.IsNullOrEmpty(lastname) Or String.IsNullOrEmpty(dob) Or String.IsNullOrEmpty(sex) Or String.IsNullOrEmpty(contact)) Then
            MsgBox("You must fill all input fields to add")
        Else
            Try
                readuery("INSERT INTO patient VALUES(null, '" & firstname & "', '" & lastname & "', '" & dob & "', '" & sex & "', '" & contact & "')")
                MsgBox("Patient was successfully added to database")
                reload("SELECT patient_id AS ID, concat(firstname, ' ',lastname) AS Name, date_of_birth AS 'Date of Birth', sex AS Sex, contact_number AS Contact FROM patient", PatientDataGrid)
                FirstnameBox.Text = ""
                LastnameBox.Text = ""
                MaleRadio.Checked = False
                FemaleRadio.Checked = False
                ContactBox.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchBtn.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleRadio.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
