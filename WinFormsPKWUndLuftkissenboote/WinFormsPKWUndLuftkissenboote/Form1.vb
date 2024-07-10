Imports HalloVererbung

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pkw = New PKW
        pkw.Hersteller = $"AAAA #{ListBox1.Items.Count}"

        ListBox1.Items.Add(pkw)

    End Sub

    Private Sub ListBox1_Format(sender As Object, e As ListControlConvertEventArgs) Handles ListBox1.Format

        Dim pkw = TryCast(e.Value, PKW)
        If pkw IsNot Nothing Then
            e.Value = $"{pkw.Hersteller} {pkw.Modell}"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim pkw = TryCast(ListBox1.SelectedItem, PKW)
        If pkw IsNot Nothing Then
            MessageBox.Show($"{pkw.Hersteller}")
        End If
    End Sub
End Class
