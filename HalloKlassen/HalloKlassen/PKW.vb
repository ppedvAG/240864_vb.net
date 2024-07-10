Public Class PKW
    Inherits Fahrzeug

    Sub New(hersteller As String)
        MyBase.New(hersteller)
    End Sub

    Property Sitze As Integer
    Property HatKofferraum As Boolean

End Class
