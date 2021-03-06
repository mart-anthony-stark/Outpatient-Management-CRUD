Imports MySql.Data.MySqlClient
Module DBModule
    Public Function strconnection() As MySqlConnection
        Dim MysqlConn As MySqlConnection
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=;database=outpatient;CharSet=utf8;Convert Zero Datetime=True"
        Return MysqlConn
    End Function

    Public strconn As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public cmdread As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    'METHOD FOR RETRIEVING DATA IN DB'
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
        da.Dispose()
    End Sub

    'METHOD FORM READING AND EXECUTING CUSTOM QUERY'
    Public Sub readuery(ByVal sql As String)
        Try
            strconn.Open()
            With cmd
                .Connection = strconn
                .CommandText = sql
                cmdread = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strconn.Close()
    End Sub
End Module
