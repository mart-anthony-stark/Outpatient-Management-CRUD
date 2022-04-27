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
        deleteBtn.DefaultCellStyle.BackColor = Color.Brown
        deleteBtn.DefaultCellStyle.ForeColor = Color.White
        DTG.Columns.Insert(DTG.Columns.Count, deleteBtn)
    End Sub
End Module
