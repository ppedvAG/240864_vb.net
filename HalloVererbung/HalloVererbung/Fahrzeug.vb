Public Class PKW
    Inherits Fahrzeug

    Property Sitze As Integer
    Property HatKofferraum As Boolean
    Public Overrides Sub Hupen()
        Console.WriteLine("PKW macht *Huuuup*")
    End Sub

    'Public Overrides Function ToString() As String
    '    Return "SEHR DUMM"
    'End Function
    Public Overrides Sub MachSchneller()
        Console.WriteLine("Drücke aufs Gas")
    End Sub
End Class

Public Class LuftkissenBoot
    Inherits Fahrzeug

    Property Luftvolumen As Long

    Public Overrides Sub Hupen()
        Console.WriteLine("HOOOOOOOOOOOOOOOOOORRRRNNN")
    End Sub
    Public Overrides Sub MachSchneller()
        Console.WriteLine("PUUUUUST 🌬️")
    End Sub
End Class

Public MustInherit Class Fahrzeug


    Public Property Hersteller As String
    Public Property Modell As String
    Public Property KW As Integer
    Public Property Getriebe As Getriebeart

    Public Overridable Sub Hupen()
        Console.WriteLine("Fahrzeug macht *Huuuup*")
    End Sub

    Public MustOverride Sub MachSchneller()


End Class

Class bliioo
    Inherits Object

End Class

Public Enum Getriebeart
    Auto
    Manuell
End Enum
