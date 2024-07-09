Module Module1

    Sub Main(ParamArray args() As String)

        Console.WriteLine("HALLOOOO")

        For Each arg In args
            Console.WriteLine(arg)
        Next

        Console.WriteLine("ENDE")

        Console.ReadKey()

    End Sub

End Module
