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
                MsgBox("item is already in the cart")

            End If
        Catch ex As MySqlException
            MsgBox("Item not added")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer = 2
        Dim name As String = "Diamond Ring"
        Dim price As Double = 8200.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer = 3
        Dim name As String = "Silver Bracelet"
        Dim price As Double = 1200.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As Integer = 4
        Dim name As String = "Pearl Earrings"
        Dim price As Double = 1800.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim id As Integer = 5
        Dim name As String = "Emerald Pendant"
        Dim price As Double = 2500.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim id As Integer = 6
        Dim name As String = "Platinum Watch"
        Dim price As Double = 9500.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim id As Integer = 7
        Dim name As String = "Samsung Smart TV"
        Dim price As Double = 32000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim id As Integer = 8
        Dim name As String = "Apple MacBook Air"
        Dim price As Double = 65000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim id As Integer = 9
        Dim name As String = "Canon DSLR Camera"
        Dim price As Double = 42000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim id As Integer = 10
        Dim name As String = "Xbox Series X"
        Dim price As Double = 35000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim id As Integer = 11
        Dim name As String = "iPhone 13 Pro"
        Dim price As Double = 58000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim id As Integer = 12
        Dim name As String = "Bluetooth Headphones"
        Dim price As Double = 4500.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim id As Integer = 13
        Dim name As String = "Victorian Clock"
        Dim price As Double = 7000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim id As Integer = 14
        Dim name As String = "Vintage Radio"
        Dim price As Double = 4800.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim id As Integer = 15
        Dim name As String = "Typewriter Remington"
        Dim price As Double = 5300.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim id As Integer = 16
        Dim name As String = "Antique Map"
        Dim price As Double = 3000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim id As Integer = 17
        Dim name As String = "Oil Lamp"
        Dim price As Double = 1600.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim id As Integer = 18
        Dim name As String = "Porcelain Tea Set"
        Dim price As Double = 4500.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim id As Integer = 19
        Dim name As String = "Mountain Bike"
        Dim price As Double = 8500.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim id As Integer = 20
        Dim name As String = "Leather Jacket"
        Dim price As Double = 3000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim id As Integer = 21
        Dim name As String = "Electric Guitar"
        Dim price As Double = 9200.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim id As Integer = 22
        Dim name As String = "Designer Handbag"
        Dim price As Double = 15000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim id As Integer = 23
        Dim name As String = "Luggage Set"
        Dim price As Double = 4000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim id As Integer = 24
        Dim name As String = "Treadmill"
        Dim price As Double = 23000.0
        Dim amount As Integer = 1
        adder(id, name, price, amount)
    End Sub
End Class