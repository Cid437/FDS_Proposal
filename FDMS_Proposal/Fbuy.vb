Imports MySql.Data.MySqlClient
Public Class Fbuy
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Sub adder(ByVal id As Integer, ByVal name As String, ByVal price As Decimal, ByVal amount As Integer)
        Try
            conn.Open()
            sql = "INSERT INTO carts (item_id, item_name, item_price, cart_amount) VALUES ('" & id & "','" & name & "','" & price & "','" & amount & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Item '" & name & "' added to cart")
            Else
                MsgBox("item not added")

            End If
        Catch ex As MySqlException
            MsgBox("Item not created")
            conn.Close()
        End Try
        conn.Close()
    End Sub
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = 1
        Dim name = "Gold Necklace"
        Dim price = 3500.0
        Dim amount = 1
        adder(id, name, price, amount)
    End Sub
End Class