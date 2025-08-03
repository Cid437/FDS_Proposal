Public Class Form1
    Dim count As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.shopping_day_medium_1_335746, AudioPlayMode.Background)
        Timer2.Start()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        adder()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        My.Computer.Audio.Play(My.Resources.shopping_day_medium_1_335746, AudioPlayMode.Background)
    End Sub

    Private Sub adder()
        count += 1

        If count > 3 Then
            count = 1
        End If

        Select Case count
            Case 1
                PictureBox1.Image = My.Resources.toyo
            Case 2
                PictureBox1.Image = My.Resources.rick
            Case 3
                PictureBox1.Image = My.Resources.yoyo
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles account.Click
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub buy_Click(sender As Object, e As EventArgs) Handles buy.Click
        Me.Hide()
        Fbuy.Show()
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Me.Hide()
        FAbout.Show()
    End Sub

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        Me.Hide()
        FCart.Show()
    End Sub

    Private Sub Pawn_Click(sender As Object, e As EventArgs) Handles pawn.Click
        Fpawn.Show()
        Me.Hide()
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Me.Hide()
        Fhelp.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

End Class
