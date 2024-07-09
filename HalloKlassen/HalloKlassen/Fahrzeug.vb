Public Class Fahrzeug

    Private Hersteller As String

    Public Property KW As Integer 'Auto-Property 

    Public Property Getriebe As Getriebeart 'Auto-Property

    Public ReadOnly Property PS As Integer 'read-only property
        Get
            Return KW / 4
        End Get
    End Property

    Private _modell As String 'backing field

    Public Property Modell As String 'full-property
        Get
            Return _modell
        End Get
        Friend Set(ByVal value As String)
            If value = "711" Then
                _modell = "922"
            Else
                _modell = value
            End If
        End Set
    End Property

    Public Function GetHersteller() As String 'getter func
        Return Hersteller
    End Function

    Friend Sub SetHersteller(name As String) 'setter sub
        If String.IsNullOrWhiteSpace(name) Then
            Hersteller = "NIX"
        Else
            Hersteller = name
        End If
    End Sub

    Public Sub Hupen()
        Console.WriteLine("Huuuup")
    End Sub

End Class

Public Enum Getriebeart
    Auto
    Manuell
End Enum
