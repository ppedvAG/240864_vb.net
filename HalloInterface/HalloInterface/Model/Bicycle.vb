Public Class Bicycle
    Inherits Things
    Implements IRidable

    Public Property Bell As Boolean
    Public Property NumberOfSeats As Integer

    Public Property MaxSpeed As Integer Implements IRidable.MaxSpeed


    Public Sub Ride() Implements IRidable.Ride
        Console.WriteLine($"Ich fahre Fahrrad ...")
    End Sub
End Class
