Public Class Fbuy
    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Me.Hide()
        FAbout.Show()
    End Sub

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        Me.Hide()
        FCart.Show()
    End Sub
End Class