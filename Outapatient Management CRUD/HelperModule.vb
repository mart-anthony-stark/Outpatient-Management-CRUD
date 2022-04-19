Module HelperModule
    Public Function IsInputNumeric(ByVal input As String) As Boolean
        If String.IsNullOrWhiteSpace(input) Then Return False
        If IsNumeric(input) Then Return True
        Dim parts() As String = input.Split("/"c)
        If parts.Length <> 2 Then Return False
        Return IsNumeric(parts(0)) AndAlso IsNumeric(parts(1))
    End Function
End Module
