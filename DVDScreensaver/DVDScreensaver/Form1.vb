Public Class Form1

    Dim speedY As Integer = 6
    Dim speedX As Integer = 6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SwitchYDirection()
        SwitchXDirection()
    End Sub

    Sub SwitchYDirection()
        speedY = speedY * -1
        ChangeColor()
    End Sub

    Sub SwitchXDirection()
        speedX = speedX * -1
        ChangeColor()
    End Sub

    Private Sub ChangeColor()
        'Task.Run(Sub() Console.Beep(220, 400))
        Dim ran = New Random()
        Button1.BackColor = Color.FromArgb(ran.Next(255), ran.Next(255), ran.Next(255))
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button1.Left += speedY
        Button1.Top += speedX

        If Button1.Left < 0 Or (Button1.Left + Button1.Width) > ClientSize.Width Then
            SwitchYDirection()
        End If

        If Button1.Top < 0 Or Button1.Bottom > ClientSize.Height Then
            SwitchXDirection()
        End If

    End Sub
End Class
