Imports System.Runtime.InteropServices

Module Module1

    Sub Main()
        Console.WriteLine("*** Hallo Klassen ***")

        Dim meineZahl As Integer = 12
        Dim geld As Decimal = 185.3837

        Console.WriteLine(meineZahl)
        Verdoppeln(meineZahl)
        Console.WriteLine(meineZahl)

        Dim meinAuto As Fahrzeug 'deklaration
        meinAuto = New Fahrzeug() 'instanzieren
        meinAuto.Hersteller = "Baudi"
        meinAuto.Modell = "711"
        meinAuto.KW = 19
        meinAuto.Getriebe = Getriebeart.Auto
        ShowFahrzeug(meinAuto)

        Dim deinAuto = New Fahrzeug()
        deinAuto.Hersteller = "Skodaaaaaaaaaa"
        deinAuto.Modell = "Käääääfa"
        deinAuto.KW = 683
        deinAuto.Getriebe = Getriebeart.Manuell
        ShowFahrzeug(deinAuto)
        MachDoppelSoSchnell(deinAuto)
        ShowFahrzeug(deinAuto)

        Dim garage = New List(Of Fahrzeug)
        While True
            garage.Add(New Fahrzeug())
        End While


        Console.WriteLine("ENDE")
        Console.ReadKey()
    End Sub

    Sub Verdoppeln(zahl As Integer)
        zahl = zahl * 2
    End Sub

    Sub MachDoppelSoSchnell(ByRef auto As Fahrzeug)
        auto.KW = auto.KW * 2
    End Sub

    Sub ShowFahrzeug(einFahrzeug As Fahrzeug)
        Console.WriteLine($"Hersteller: {einFahrzeug.Hersteller}{vbNewLine}Modell: {einFahrzeug.Modell}{vbNewLine}Leistung: {einFahrzeug.KW}KW{vbNewLine}Getriebe: {einFahrzeug.Getriebe}")
        Console.WriteLine("-------------------------------------------------------------------------------")
    End Sub

End Module
