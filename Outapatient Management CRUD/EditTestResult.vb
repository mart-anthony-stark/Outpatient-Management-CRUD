Imports MySql.Data.MySqlClient

Public Class EditTestResult

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub EditTestResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        FetchLabtests()
    End Sub

    'Handle retrieve labtest result
    Public Sub FetchLabtests()
        Try
            DiseaseCmb.SelectedText = Nothing
            LabtestCmb.SelectedText = Nothing
            Dim test_table As New DataTable()
            Dim test_adapter As New MySqlDataAdapter("SELECT test_id, concat(test_name,' (',test_type, ')') AS display from laboratorytest", strconn)
            Dim disease_table As New DataTable()
            Dim disease_adapter As New MySqlDataAdapter("SELECT disease_id, concat(name,' (',type, ')') AS display from disease", strconn)

            test_adapter.Fill(test_table)
            LabtestCmb.DataSource = test_table
            LabtestCmb.ValueMember = "test_id"
            LabtestCmb.DisplayMember = "display"

            disease_adapter.Fill(disease_table)
            DiseaseCmb.DataSource = disease_table
            DiseaseCmb.ValueMember = "disease_id"
            DiseaseCmb.DisplayMember = "display"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Save labtest
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim disease As String = DiseaseCmb.SelectedValue
        Dim labtest As String = LabtestCmb.SelectedValue
        Dim _date As String = Format(ResultDate.Value, "yyyy-MM-dd")

        Try
            readuery("UPDATE testresult SET disease='" & disease & "', test='" & labtest & "', date='" & _date & "' WHERE result_id=" & idText.Text)
            MsgBox("Laboratory Test result record was updated successfully")
            LabtestResult.FetchTestResults()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class