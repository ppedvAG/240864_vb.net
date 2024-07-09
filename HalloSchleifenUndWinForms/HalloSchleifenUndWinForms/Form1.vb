Imports System.Runtime.InteropServices

Public Class Form1



    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For index = 0 To 10 Step 3
            ListBox1.Items.Add($"For: {index}")
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim text As String

        For index = 0 To ListBox1.Items.Count - 1

            Dim listBoxEintrag = ListBox1.Items(index)

            If listBoxEintrag.ToString().EndsWith("0") Then
                text += $"Zeile: {index} = {listBoxEintrag}{vbNewLine}"
            End If
        Next

        MessageBox.Show(text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For Each item In ListBox1.Items
            MessageBox.Show(item)
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = My.Resources.Titel
        BackColor = My.Settings.FARBEEE


        Dim b = New Button()

    End Sub
End Class
