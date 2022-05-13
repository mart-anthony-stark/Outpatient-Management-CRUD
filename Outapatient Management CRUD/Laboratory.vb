Public Class Laboratory

    Private Sub Laboratory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchDiseases()
        FetchLabTests()
        AddControls(DiseaseTbl)
        AddEdit(LabtestTbl)
    End Sub

    Private Sub FetchDiseases()
        Try
            reload("SELECT * from disease", DiseaseTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub FetchLabTests()
        Try
            reload("SELECT test_id AS ID, test_name As `Test Name`, test_type As `Test Type`, description As Description, cost As Cost from laboratorytest", LabtestTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Method that handles edit or delete click in disease table
    Private Sub DiseaseTbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DiseaseTbl.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
            Dim row As System.Windows.Forms.DataGridViewRow = DiseaseTbl.Rows(e.RowIndex)
            Dim id As String = row.Cells(2).Value.ToString
            MsgBox(column.HeaderText)
            If TypeOf column Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 Then
                'TODO - Button Clicked - Execute Code Here
                If (column.HeaderText Is "Edit") Then
                    'SearchData(id)
                ElseIf (column.HeaderText Is "Delete") Then
                    'DeleteDoctor(id)
                End If
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub LabtestTbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LabtestTbl.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, DataGridView)
            Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
            Dim row As System.Windows.Forms.DataGridViewRow = LabtestTbl.Rows(e.RowIndex)
            Dim id As String = row.Cells(1).Value.ToString
            'MsgBox(column.HeaderText & id)
            If TypeOf column Is DataGridViewButtonColumn AndAlso
                e.RowIndex >= 0 Then
                'TODO - Button Clicked - Execute Code Here
                If (column.HeaderText Is "Edit") Then
                    SearchData(id)
                ElseIf (column.HeaderText Is "Delete") Then
                    'DeleteDoctor(id)
                End If
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    'Clear labtest inputs
    Private Sub ClearLabtest()
        TestName.Text = Nothing
        TestType.Text = Nothing
        Description.Text = Nothing
        Cost.Value = 0
    End Sub

    'Add labtest record
    Private Sub AddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddBtn.Click
        Dim name As String = TestName.Text
        Dim type As String = TestType.Text
        Dim t_cost As String = Cost.Value
        Dim desc As String = Description.Text

        If (String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(type) Or String.IsNullOrEmpty(desc)) Then
            MessageBox.Show("Input fields must be filled", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                readuery("INSERT INTO laboratorytest VALUES(null,'" & name & "', '" & type & "', '" & desc & "', '" & t_cost & "')")
                MsgBox("Laboratory test record was added successfully")
                ClearLabtest()
                FetchLabTests()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ClearAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAddBtn.Click
        ClearLabtest()
    End Sub

    'Edit Labtest
    Private Sub SearchData(ByVal id As String)
        EditLabtest.idText.Text = id
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = "SELECT * FROM laboratorytest WHERE test_id='" & id & "'"
                cmdread = .ExecuteReader
                If (cmdread.Read()) Then
                    EditLabtest.idText.Text = cmdread.GetString(0)
                    EditLabtest.TestName.Text = cmdread.GetString(1)
                    EditLabtest.TestType.Text = cmdread.GetString(2)
                    EditLabtest.Description.Text = cmdread.GetString(3)
                    EditLabtest.Cost.Value = cmdread.GetInt64(4)
                    EditLabtest.Show()
                Else
                    MsgBox("Labtest Record is not found in database using the id you specified")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub
End Class