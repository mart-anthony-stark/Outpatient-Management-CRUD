Public Class Doctors

    Private Sub Doctors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FetchData()
    End Sub

    Private Sub FetchData()
        Try
            reload("SELECT doctor_id AS ID, concat(lastname, ', ', firstname) AS Name, specialization AS Specialization, contact_number AS 'Contact Number' from doctor", DoctorDataGridView)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class