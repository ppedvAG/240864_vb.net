Module Module1

    Sub Main()
        Console.WriteLine(" *** Hallo Vererbung *** ")

        'Dim einFahrzeug = New Fahrzeug()
        'einFahrzeug.Hersteller = "Baudi"
        'einFahrzeug.Modell = "911"
        'ShowFahrzeug(einFahrzeug)

        Dim einPKW = New PKW()
        einPKW.Hersteller = "Pauki"
        einPKW.Modell = "7er"
        einPKW.Sitze = 5
        ShowFahrzeug(einPKW)
        einPKW.Hupen()
        'einPKW.MachSchneller()

        Dim luftBoot = New LuftkissenBoot()
        luftBoot.Hersteller = "Knall"
        luftBoot.Modell = "Rote Gummiboot"
        luftBoot.Luftvolumen = 2349887234687623434
        ShowFahrzeug(luftBoot)


        Console.WriteLine("ENDE")
        Console.ReadKey()
    End Sub

    Sub ShowFahrzeug(einFahrzeug As Fahrzeug)
        Console.WriteLine($"Hersteller: {einFahrzeug.Hersteller}{vbNewLine}Modell: {einFahrzeug.Modell}{vbNewLine}Leistung: {einFahrzeug.KW}KW {vbNewLine}Getriebe: {einFahrzeug.Getriebe}")
        einFahrzeug.Hupen()

        If TypeOf einFahrzeug Is PKW Then 'typ prüfung
            Dim pkw = CType(einFahrzeug, PKW) 'casten = typ umwandlung
            Console.WriteLine($"Das ist ein PKW mit {pkw.Sitze} Sitze")
        End If

        Dim lkb As LuftkissenBoot = TryCast(einFahrzeug, LuftkissenBoot) 'boxing
        If lkb IsNot Nothing Then
            Console.WriteLine($"Das ist ein Luftkissenboot {lkb.Luftvolumen}µm³")
        End If

        Console.WriteLine("-------------------------------------------------------------------------------")

    End Sub

End Module



