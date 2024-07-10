Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For index = 1 To 10
            TextBox1.Text += $"Alles wird gut {index}{vbCrLf}"
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim opendlg = New OpenFileDialog()
        opendlg.Filter = "Textkram|*.txt|Den rest|*.*"
        If opendlg.ShowDialog() = DialogResult.OK Then

            Dim sr = New StreamReader(opendlg.FileName)
            Dim lineNumber As Integer = 1

            While Not sr.EndOfStream

                Dim line = sr.ReadLine()
                TextBox1.Text += lineNumber.ToString() + ": " + line + vbCrLf
                lineNumber += 1

            End While
            sr.Close()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        HalloSub(" ")
        HalloSub("Ein Text")

    End Sub

    Sub HalloSub()
        MessageBox.Show("Hallo von der Sub", "TITEL " + GibMitFünf(23).ToString())
        MessageBox.Show("Hallo von der Sub", "TITEL", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Hand)
    End Sub

    Sub HalloSub(msg As String)

        If String.IsNullOrWhiteSpace(msg) Then
            Return
        End If

        MessageBox.Show(msg)
    End Sub

    Function GibMitFünf(Optional multi As Integer = 1) As Integer

        Return 5 * multi

        MessageBox.Show("Wird nie aufgerufen")

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f = New HalloSchleifenUndWinForms.Form1()
        f.ShowDialog()
    End Sub
End Class
