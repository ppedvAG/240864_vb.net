Public Class Horse
    Inherits Animals
    Implements IRidable

    Public Property Saddle As String

    Public Property MaxSpeed As Integer Implements IRidable.MaxSpeed

    Public Sub Ride() Implements IRidable.Ride
        Console.WriteLine($"Ich reite das Pferd {Name} mit MaxSpeed {MaxSpeed}")
    End Sub
End Class