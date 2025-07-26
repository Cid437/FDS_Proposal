Imports MySql.Data.MySqlClient
Public Class FCart
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Sub FCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            sql = "SELECT * FROM carts ORDER BY item_id"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "carts")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "carts"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub reloaddatagrid()
        Try
            conn.Open()
            sql = "SELECT * FROM carts ORDER BY item_id"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "items")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "items"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'remove button
        Dim id = TextBox1.Text
        Try
            conn.Open()
            sql = $"DELETE FROM carts WHERE item_id = {id}"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Item removed")
            Else
                MsgBox("item not removed")

            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        'search id button
        Dim id As Integer
        Try
            conn.Open()
            id = Val(TextBox1.Text)
            sql = "SELECT * FROM carts WHERE item_id = " & id
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()

            TextBox2.Text = dbread("item_name")
            TextBox4.Text = dbread("item_price")
            'testing
        Catch ex As MySqlException
            MsgBox("Please Enter a valid id")
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn.Open()
            Dim ans = MessageBox.Show("Are you sure you want to clear your cart?", "Cart cleared", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = $"DELETE FROM carts; "
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Cart cleared")
                Else
                    MsgBox("Cart not cleared")

                End If
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'amount button, from textbox3
        Dim id As Integer = Val(TextBox1.Text)
        Dim amountToAdd As Integer = Val(TextBox3.Text)
        Dim availableStock As Integer = 0
        Dim itemName As String = ""
        Dim itemPrice As Decimal = 0

        If id <= 0 Or amountToAdd <= 0 Then
            MsgBox("Please enter valid item ID and amount.")
            Exit Sub
        End If

        Try
            conn.Open()

            ' Get item from original items table
            sql = "SELECT * FROM items WHERE item_id = " & id
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()

            If dbread.Read() Then
                availableStock = Val(dbread("item_quantity")) ' assuming DESCRIPT holds the quantity/stock
                itemName = dbread("item_name")
                itemPrice = dbread("item_price")
            Else
                MsgBox("Item not found.")
                dbread.Close()
                conn.Close()
                Exit Sub
            End If
            dbread.Close()

            If amountToAdd > availableStock Then
                MsgBox("Only " & availableStock & " item(s) available.")
                conn.Close()
                Exit Sub
            End If

            ' Insert into cart with selected amount
            sql = "UPDATE carts SET cart_amount = " & amountToAdd & " WHERE item_id = " & id
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Item added with amount: " & amountToAdd)
            Else
                MsgBox("Item not added.")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reloaddatagrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If loggedInUser = "" Then
            MsgBox("Please log in first.")
            Me.Hide()
            FLogin.Show()
            Exit Sub
        End If

        Dim conn As New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
        Dim sql As String = "SELECT item_name, item_price, cart_amount, COUNT(*) AS quantity " &
                        "FROM carts GROUP BY item_name, item_price"
        Dim dbcomm2 As New MySqlCommand(sql, conn)
        Dim reader As MySqlDataReader
        Dim message As String = ""
        Dim total As Decimal = 0
        Dim today As String = Date.Now.ToString("yyyy-MM-dd")

        Try
            conn.Open()
            reader = dbcomm2.ExecuteReader()

            While reader.Read()
                Dim name As String = reader("item_name")
                Dim price As Decimal = reader("item_price")
                Dim qty As Integer = reader("cart_amount")
                Dim subtotal As Decimal = price * qty

                message &= qty & " x " & name & " = ₱" & subtotal & vbCrLf
                total += subtotal
            End While
            reader.Close()

            message &= vbCrLf & "Total: ₱" & total
            MsgBox(message, MsgBoxStyle.Information, "Purchase Summary")

            sql = "INSERT INTO order_description (account_id, date_ordered , price, order_description) VALUES ('" & loggedInID & "','" & today & "','" & total & "', '" & message & "')"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class