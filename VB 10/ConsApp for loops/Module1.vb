Module Module1

    Sub Main()

        Dim i As Integer

        For i = 1 To 10
            Console.WriteLine(i)
        Next

        Console.WriteLine("")

        Dim s As String = "hello"
        Dim c As Char

        For Each c In s
            Console.WriteLine(c)
        Next

        Console.ReadLine()

    End Sub

End Module
