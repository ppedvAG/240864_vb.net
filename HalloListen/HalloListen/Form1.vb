Imports System.Configuration
Imports System.Globalization
Imports System.IO
Imports System.Xml.Serialization
Imports Bogus
Imports CsvHelper
Imports CsvHelper.Configuration
Imports Newtonsoft.Json

Public Class Form1

    Dim personFaker As Faker(Of Person) = New Faker(Of Person)("de")
    Dim carFaker As Faker(Of Car) = New Faker(Of Car)("de")

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        personFaker.UseSeed(7)
        personFaker.RuleFor(Function(p) p.FirstName, Function(x) x.Name.FirstName())
        personFaker.RuleFor(Function(p) p.LastName, Function(x) x.Name.LastName())
        personFaker.RuleFor(Function(p) p.City, Function(x) x.Address.City())
        personFaker.RuleFor(Function(p) p.BirthDate, Function(x) x.Date.Past(40))
        personFaker.RuleFor(Function(p) p.Cars, Function(f) carFaker.Generate(f.Random.Int(1, 5)).ToList())

        carFaker.UseSeed(7)
        carFaker.RuleFor(Function(p) p.Manufacturer, Function(x) x.Vehicle.Manufacturer())
        carFaker.RuleFor(Function(p) p.Model, Function(x) x.Vehicle.Model())
        carFaker.RuleFor(Function(p) p.Color, Function(x) x.Commerce.Color())
        carFaker.RuleFor(Function(p) p.Power, Function(x) x.Random.Int(20, 1000))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim liste As List(Of Person) = New List(Of Person)

        For index = 1 To 100

            Dim p = New Person
            p.FirstName = $"Fred #{index:000}"
            p.LastName = $"Feuerstein #{index:000}"
            p.BirthDate = Date.Now.AddYears(-40).AddDays(index * 17)
            p.City = "Steintal"

            liste.Add(p)

        Next

        DataGridView1.DataSource = liste

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        DataGridView1.DataSource = personFaker.Generate(100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.DataSource = carFaker.Generate(100)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim persons = TryCast(DataGridView1.DataSource, ICollection(Of Person))

        If persons IsNot Nothing Then
            Dim sw = New StreamWriter("person.csv")

            For Each person In persons
                sw.WriteLine($"{person.FirstName};{person.LastName};{person.BirthDate.ToShortDateString()};{person.City}")
            Next

            sw.Close()
        End If



    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        e.CellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Dim cars = TryCast(e.Value, ICollection(Of Car))
        If cars IsNot Nothing Then
            DataGridView1.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            'Dim txt = ""
            'For Each c In cars
            '    txt += $"{c.Manufacturer} {c.Model} {c.Power}PS {c.Color}{vbNewLine}"
            'Next

            'e.Value = txt.TrimEnd()
            e.Value = String.Join($"{vbNewLine}", cars.Select(Function(c) $"{c.Manufacturer} {c.Model} {c.Power}PS {c.Color}"))

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim persons = TryCast(DataGridView1.DataSource, ICollection(Of Person))

        If persons IsNot Nothing Then
            Using writer As New StreamWriter("personHelp.csv")
                Using csv As New CsvWriter(writer, New CsvConfiguration(CultureInfo.InvariantCulture))
                    ' Schreiben des Headers
                    csv.WriteField("FirstName")
                    csv.WriteField("LastName")
                    csv.WriteField("BirthDate")
                    csv.WriteField("City")
                    csv.WriteField("Cars")
                    csv.NextRecord()

                    ' Schreiben der Personendaten
                    For Each person In persons
                        csv.WriteField(person.FirstName)
                        csv.WriteField(person.LastName)
                        csv.WriteField(person.BirthDate.ToShortDateString())
                        csv.WriteField(person.City)
                        Dim carDetails As String = String.Join(";", person.Cars.Select(Function(c) $"{c.Manufacturer} {c.Model} ({c.Power} HP)"))
                        csv.WriteField(carDetails)
                        csv.NextRecord()
                    Next
                End Using
            End Using
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim persons = TryCast(DataGridView1.DataSource, List(Of Person))

        If persons IsNot Nothing Then
            Dim writer As New StreamWriter("personen.xml")

            Dim serial = New XmlSerializer(GetType(List(Of Person)))
            serial.Serialize(writer, persons)
            writer.Close()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim reader As New StreamReader("personen.xml")

        Dim serial = New XmlSerializer(GetType(List(Of Person)))
        DataGridView1.DataSource = CType(serial.Deserialize(reader), List(Of Person))
        reader.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim persons = TryCast(DataGridView1.DataSource, List(Of Person))

        If persons IsNot Nothing Then

            Dim json = JsonConvert.SerializeObject(persons)
            File.WriteAllText("person.json", json)

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim json = File.ReadAllText("person.json")
        DataGridView1.DataSource = JsonConvert.DeserializeObject(Of List(Of Person))(json)
    End Sub
End Class
