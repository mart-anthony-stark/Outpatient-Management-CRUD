Public Class Laboratory

    Private Sub Laboratory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchDiseases()
        FetchLabTests()
        AddControls(DiseaseTbl)
        AddControls(LabtestTbl)
    End Sub

    Private Sub FetchDiseases()
        Try
            reload("SELECT * from disease", DiseaseTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FetchLabTests()
        Try
            reload("SELECT test_id AS ID, test_name As `Test Name`, test_type As `Test Type`, description As Description, cost As Cost from laboratorytest", LabtestTbl)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Method that handles edit or delete click in disease table
    Private Sub DiseaseTbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DiseaseTbl.CellContentClick
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
    End Sub

    Private Sub LabtestTbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LabtestTbl.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim column As System.Windows.Forms.DataGridViewColumn = senderGrid.Columns(e.ColumnIndex)
        Dim row As System.Windows.Forms.DataGridViewRow = LabtestTbl.Rows(e.RowIndex)
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
    End Sub
End Class