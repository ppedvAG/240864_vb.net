Imports System
Imports System.Net.Http
Imports System.Linq
Imports System.Text.Json.Serialization

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        GetBooks()
        Console.ReadLine()
    End Sub

    Private Async Sub GetBooks()
        Dim url = "https://www.googleapis.com/books/v1/volumes?q=vb.net"
        Dim http = New HttpClient()
        Dim json = Await http.GetStringAsync(url)
        'Console.WriteLine(json)

        Dim result = System.Text.Json.JsonSerializer.Deserialize(Of BooksResult)(json)

        For Each vi In result.items.Select(Function(x) x.volumeInfo)
            Console.WriteLine($"{vi.pageCount} {vi.title}")
        Next


    End Sub
End Module
