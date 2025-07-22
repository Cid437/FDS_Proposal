Imports MySql.Data.MySqlClient
Public Class Fstaff
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Sub reloaddatagrid()
        Try
            conn.Open()
            sql = "SELECT * FROM items ORDER BY item_id"

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

    Private Sub Fstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            sql = "SELECT * FROM items ORDER BY item_id"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FLogin.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim customer_id As Integer
        Try
            conn.Open()
            customer_id = Val(TextBox1.Text)
            sql = "SELECT * FROM items WHERE item_id = " & customer_id
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()

            TextBox2.Text = dbread("item_name")
            TextBox3.Text = dbread("item_category")
            TextBox4.Text = dbread("item_price")
            TextBox5.Text = dbread("item_quantity")
            TextBox6.Text = dbread("item_description")

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id = TextBox1.Text
        Dim Name = TextBox2.Text
        Dim category = TextBox3.Text
        Dim price = TextBox4.Text
        Dim quantity = TextBox5.Text
        Dim description = TextBox6.Text
        Try
            conn.Open()
            sql = "INSERT INTO items (item_id, item_name, item_category, item_price, item_quantity, item_description) VALUES ('" & id & "','" & Name & "','" & category & "','" & price & "','" & quantity & "','" & description & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Item added")
            Else
                MsgBox("item not added")

            End If
        Catch ex As MySqlException
            MsgBox("Item not created")
            conn.Close()
        End Try
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            conn.Open()
            Dim id As Integer = InputBox("enter customer id to be deleted", "delete record")
            Dim ans = MessageBox.Show("do you want to delete this record?", "record deleted", MessageBoxButtons.YesNoCancel)
            If ans = DialogResult.Yes Then
                sql = $"DELETE FROM items WHERE item_id = {id}"
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Item removed")
                Else
                    MsgBox("item not removed")

                End If
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim id = TextBox1.Text
        Dim Name = TextBox2.Text
        Dim category = TextBox3.Text
        Dim price = TextBox4.Text
        Dim quantity = TextBox5.Text
        Dim description = TextBox6.Text
        Try
            conn.Open()
            sql = "UPDATE items SET item_id = '" & id & "', item_name = '" & Name & "', item_category = '" & category & "', item_price = '" & price & "', item_quantity = '" & quantity & "', item_description = '" & description & "' WHERE Item_id = '" & id & "'"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Item reorganized")
            Else
                MsgBox("Item not reorganized")

            End If

        Catch ex As Exception
            MsgBox("Item not organized, make sure it has (A unique name, a unique id, a unique description and so)")
        End Try
        conn.Close()
        reloaddatagrid()
    End Sub
End Class