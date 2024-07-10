Imports System.Drawing.Drawing2D

Public Class MyButton
    Inherits Button


    Dim counter As Integer
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)

        'MyBase.OnPaint(pevent)
        pevent.Graphics.FillRectangle(New SolidBrush(Parent.BackColor), ClientRectangle)
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim backBrush = New LinearGradientBrush(ClientRectangle, BackColor, Color.Silver, 90.0F)
        pevent.Graphics.FillEllipse(backBrush, ClientRectangle)

        counter += 1
        Parent.Text = $"Paints: {counter}"
        Dim sf = New StringFormat()
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center
        pevent.Graphics.DrawString("DVD", New Font("Groudy Stout", 24.0F, FontStyle.Bold), Brushes.AliceBlue, ClientRectangle, sf)

    End Sub

End Class
