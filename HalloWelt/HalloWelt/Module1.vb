Module Module1

    Sub Main()

        Console.WriteLine("Hallo Welt")

        Dim eingabe As String
        eingabe = Console.ReadLine()
        Console.WriteLine($"Du hast eingegeben: {eingabe}")

        'Dim eingabeAlsZahl = Integer.Parse(eingabe) 'string to integer parsing
        Dim eingabeAlsZahl As Integer
        If Integer.TryParse(eingabe, eingabeAlsZahl) Then
            Dim dasDoppelte As Integer = eingabeAlsZahl * 2
            Console.WriteLine($"Das doppelte: {dasDoppelte}")

            Dim eingabeAlsDecimal As Decimal = CDec(eingabeAlsZahl)
            Console.WriteLine($"Eingabe als decimal: {eingabeAlsDecimal}")

        Else
            Console.WriteLine("Das war keine Zahl!")
        End If


        Console.WriteLine("Ende")
        Console.ReadLine()

    End Sub

End Module
