Public Class Password
    Public Function Encrypt(ByRef CodeString As String) As String
        Dim character As String, pass As String
        Dim ascii As Integer

        For x = 0 To Len(CodeString) - 1
            character = CodeString.Chars(x)
            ascii = Asc(character) - 42
            pass += Chr(ascii)
            For y = 4 To x
                character = CodeString.Chars(y)
                ascii = Asc(character) - 9
                pass += Chr(ascii)
            Next
        Next
        Encrypt = pass
    End Function
End Class
