Module Module1

    Sub Main()
        ' Erstellen von Objekten und Hinzufügen von Demodaten
        Dim myBicycle As New Bicycle()
        myBicycle.Color = "Red"
        myBicycle.Description = "Mountain Bike"
        myBicycle.Bell = True
        myBicycle.NumberOfSeats = 1

        Dim myCat As New Cat()
        myCat.Name = "Whiskers"
        myCat.Weight = 3
        myCat.FurColor = "Gray"
        myCat.Breed = "Siamese"

        Dim myHorse As New Horse()
        myHorse.Name = "Black Beauty"
        myHorse.Weight = 5
        myHorse.Saddle = "Leather"

        ' Anzeigen der Daten
        DisplayInfo(myBicycle)
        DisplayInfo(myCat)
        DisplayInfo(myHorse)

        ShowIRideable(myBicycle)
        'ShowIRideable(myCat)
        ShowIRideable(myHorse)

        Dim irider As IRidable = myHorse


        Console.ReadLine()
    End Sub

    Sub ShowIRideable(ridable As IRidable)
        ridable.Ride()
    End Sub

    Sub DisplayInfo(obj As Object)
            If TypeOf obj Is Bicycle Then
                Dim bike As Bicycle = CType(obj, Bicycle)
                Console.WriteLine("Bicycle Information:")
                Console.WriteLine($"Color: {bike.Color}")
                Console.WriteLine($"Description: {bike.Description}")
                Console.WriteLine($"Bell: {bike.Bell}")
                Console.WriteLine($"Number of Seats: {bike.NumberOfSeats}")
            ElseIf TypeOf obj Is Cat Then
                Dim cat As Cat = CType(obj, Cat)
                Console.WriteLine("Cat Information:")
                Console.WriteLine($"Name: {cat.Name}")
                Console.WriteLine($"Weight: {cat.Weight}")
                Console.WriteLine($"Fur Color: {cat.FurColor}")
                Console.WriteLine($"Breed: {cat.Breed}")
            ElseIf TypeOf obj Is Horse Then
                Dim horse As Horse = CType(obj, Horse)
                Console.WriteLine("Horse Information:")
                Console.WriteLine($"Name: {horse.Name}")
                Console.WriteLine($"Weight: {horse.Weight}")
                Console.WriteLine($"Saddle: {horse.Saddle}")
            End If
            Console.WriteLine()
        End Sub

    End Module
