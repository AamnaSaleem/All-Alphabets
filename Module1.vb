Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim ThisChar As Char
        Dim a, SpaPos As Integer

        Str1 = ""
        Str2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        ThisChar = ""


        Console.Write("Enter string to be processed: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        For a = 1 To Len(Str1)
            ThisChar = Mid(Str1, a, 1)
            SpaPos = InStr(Str2, ThisChar)
            If SpaPos = 0 Then
                Console.WriteLine("The string dosen't have all alphabets")
                Console.ReadKey()
                End
            End If
        Next

        Console.WriteLine("Entered string has all alphabets")
        Console.ReadKey()
    End Sub

End Module
