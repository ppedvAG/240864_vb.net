Public Class Person
    Public Property FirstName As String
    Public Property LastName As String
    Public Property BirthDate As Date
    Public Property City As String

    Public Property Cars As List(Of Car) = New List(Of Car)()

End Class
