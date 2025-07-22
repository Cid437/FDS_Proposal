Public Class FLogin


    Private Sub buy_Click(sender As Object, e As EventArgs) Handles buy.Click
        Me.Hide()
        Fbuy.Show()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        Me.Hide()
        FAbout.Show()
    End Sub

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        Me.Hide()
        FCart.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            Fstaff.Show()
            Me.Hide()
        End If
    End Sub
End Class