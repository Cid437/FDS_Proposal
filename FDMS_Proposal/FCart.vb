Public Class FCart
    Private Sub FCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MerchTorresDataSet1.Cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.MerchTorresDataSet1.Cart)
        Me.GymSitiesTableAdapter.Fill(Me.MerchTorresDataSet.GymSities)
    End Sub

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

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Me.Hide()
        FLogin.Show()
    End Sub
End Class