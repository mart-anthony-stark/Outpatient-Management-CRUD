Module GridModule
    Public Sub AddControls(ByVal DTG)
        Dim editBtn, deleteBtn As New DataGridViewButtonColumn
        editBtn.HeaderText = "Edit"
        editBtn.Text = "Edit"
        editBtn.Name = "edit"
        editBtn.UseColumnTextForButtonValue = True
        editBtn.FlatStyle = FlatStyle.Flat
        editBtn.DefaultCellStyle.BackColor = Color.MediumSeaGreen
        editBtn.DefaultCellStyle.ForeColor = Color.White
        DTG.Columns.Insert(DTG.Columns.Count, editBtn)

        deleteBtn.HeaderText = "Delete"
        deleteBtn.Text = "Delete"
        deleteBtn.Name = "Delete"
        deleteBtn.UseColumnTextForButtonValue = True
        deleteBtn.FlatStyle = FlatStyle.Flat
        deleteBtn.DefaultCellStyle.BackColor = Color.IndianRed
        deleteBtn.DefaultCellStyle.ForeColor = Color.White
        DTG.Columns.Insert(DTG.Columns.Count, deleteBtn)
    End Sub

    Public Sub AddEdit(ByVal DTG)
        Dim editBtn As New DataGridViewButtonColumn
        editBtn.HeaderText = "Edit"
        editBtn.Text = "Edit"
        editBtn.Name = "edit"
        editBtn.UseColumnTextForButtonValue = True
        editBtn.FlatStyle = FlatStyle.Flat
        editBtn.DefaultCellStyle.BackColor = Color.MediumSeaGreen
        editBtn.DefaultCellStyle.ForeColor = Color.White
        DTG.Columns.Insert(DTG.Columns.Count, editBtn)
    End Sub

    Public Sub AddLabtestBtn(ByVal DTG)
        Dim labtestBtn As New DataGridViewButtonColumn
        labtestBtn.HeaderText = "Laboratory"
        labtestBtn.Text = "Laboratory Results"
        labtestBtn.Name = "laboratory"
        labtestBtn.UseColumnTextForButtonValue = True
        labtestBtn.FlatStyle = FlatStyle.Flat
        labtestBtn.DefaultCellStyle.BackColor = Color.CadetBlue
        labtestBtn.DefaultCellStyle.ForeColor = Color.White
        DTG.Columns.Insert(DTG.Columns.Count, labtestBtn)
    End Sub
End Module
