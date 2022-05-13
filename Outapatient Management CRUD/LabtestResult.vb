Imports MySql.Data.MySqlClient

Public Class LabtestResult

    Private Sub LabtestResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchLabtests()
        FetchTestResults()
        AddControls(LabtestResultTbl)
    End Sub

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

    Public Sub FetchTestResults()
        Try
            reload("SELECT result_id AS ID, laboratorytest.test_name AS `Laboratory Test`, laboratorytest.description AS `Result Description`, disease.name AS Disease,testresult.date AS Date FROM testresult, laboratorytest, disease WHERE laboratorytest.test_id=testresult.test AND disease.disease_id = testresult.disease", LabtestResultTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim test As String = LabtestCmb.SelectedValue
        Dim disease As String = DiseaseCmb.SelectedValue
        Dim _date As String = Format(ResultDate.Value, "yyyy-MM-dd")
        Dim apt As String = AptID.Text
        Try
            If (String.IsNullOrEmpty(test) Or String.IsNullOrEmpty(_date) Or String.IsNullOrEmpty(apt)) Then
                MessageBox.Show("Test and date fields must be filled", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                readuery("INSERT INTO testresult VALUES(null, '" & test & "', '" & apt & "', '" & disease & "', '" & _date & "')")
                MsgBox("Lab test result was saved into the database")
            End If
            FetchTestResults()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Edit labtest result
    Private Sub EditResult(ByVal id As String)
        EditTestResult.idText.Text = id
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT * FROM testresult WHERE result_id='" & id & "'"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    Dim labtest As String = cmdread.GetString(1)
                    Dim disease As String = cmdread.GetString(3)
                    EditTestResult.ResultDate.Value = cmdread.GetString(4)
                    strconn.Close()
                    EditTestResult.Show()
                    EditTestResult.LabtestCmb.SelectedValue = labtest
                    EditTestResult.DiseaseCmb.SelectedValue = disease
                Else
                    MsgBox("Labtest Result Record is not found in database using the id you specified")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub

    Private Sub DeleteResult(ByVal id As String)
        Dim ans As String
        ans = MsgBox("Are you sure you wamt to delete this record?", vbYesNo)
        If ans = vbYes Then
            Try
                readuery("DELETE FROM testresult WHERE result_id=" & id)
                FetchTestResults()
                MsgBox("Laboratory Test Result record was successfully deleted")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LabtestResultTbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LabtestResultTbl.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
            Dim row As System.Windows.Forms.DataGridViewRow = LabtestResultTbl.Rows(e.RowIndex)
            Dim id As String = row.Cells(2).Value.ToString
            If TypeOf column Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 Then
                'TODO - Button Clicked - Execute Code Here
                If (column.HeaderText Is "Edit") Then
                    EditResult(id)
                ElseIf (column.HeaderText Is "Delete") Then
                    DeleteResult(id)
                End If
                FetchLabtests()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class