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


        reloadPawnRequestData()
    End Sub

    Private Sub reloadPawnRequestData()
        Try
            conn.Open()
            sql = "SELECT * FROM pawn_request"

            Dim DataAdapter2 As New MySqlDataAdapter(sql, conn)
            Dim ds2 As New DataSet()
            DataAdapter2.Fill(ds2, "pawn_request")
            DataGridView2.DataSource = ds2
            DataGridView2.DataMember = "pawn_request"

        Catch ex As Exception
            MsgBox("Error in collecting data from the Database. Error is: " & ex.Message)

        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
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
            ' lol '
        Catch ex As Exception
            MsgBox("Item not organized, make sure it has (A unique name, a unique id, a unique description and so)")
        End Try
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Fadmin.Show()
        Me.Hide()
        Button9.Hide()
        Button1.Show()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("Please select a request from the table first.")
            Return
        End If

        Dim monthsInput As String
        monthsInput = InputBox("Enter the loan duration in months (1, 6, or 12):", "Pawn Duration")

        Dim monthsToAdd As Integer
        Select Case monthsInput
            Case "1"
                monthsToAdd = 1
            Case "6"
                monthsToAdd = 6
            Case "12"
                monthsToAdd = 12
            Case Else
                MsgBox("Invalid input. Please enter only 1, 6, or 12.", MsgBoxStyle.Exclamation)
                Return
        End Select

        Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)


        Dim requestId = selectedRow.Cells("request_id").Value
        Dim accountId = selectedRow.Cells("account_id").Value
        Dim collateralName = selectedRow.Cells("collateral_name").Value
        Dim collateralCategory = selectedRow.Cells("collateral_category").Value
        Dim requestedAmount = selectedRow.Cells("requested_ammount").Value
        Dim processStatus = selectedRow.Cells("process").Value


        Dim pawnDate As DateTime = Date.Now
        Dim maturityDate As DateTime = pawnDate.AddMonths(monthsToAdd)

        Dim dbcomm As MySqlCommand
        Dim sql As String

        Try
            conn.Open()


            sql = "INSERT INTO transaction (request_id, account_id, collateral, collateral_category, pawned_ammount, date_pawned, date_due, t_status) VALUES ('" & requestId & "', '" & accountId & "', '" & collateralName & "', '" & collateralCategory & "', '" & requestedAmount & "', '" & pawnDate.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & maturityDate.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & processStatus & "')"

            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery()

            If (i > 0) Then

                sql = "DELETE FROM pawn_request WHERE request_id = '" & requestId & "'"
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                MsgBox("Request Accepted")
            Else
                MsgBox("Accepting failed. The new transaction could not be created.")
            End If

        Catch ex As Exception
            MsgBox("An error occurred during the transfer: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        reloadPawnRequestData()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' First, check if any row is selected in the grid.
        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("Please select a request from the list to reject.", MsgBoxStyle.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)

        ' Get the ID and the current status from the selected row.
        Dim requestIdToUpdate = selectedRow.Cells("request_id").Value
        Dim currentStatus As String = selectedRow.Cells("process").Value.ToString()

        ' It's good practice to check if the request is in a state that can be rejected.
        If currentStatus <> "ongoing" Then
            MsgBox("This request cannot be rejected because its status is already '" & currentStatus & "'.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Ask for confirmation before making a permanent change.
        Dim confirmation = MessageBox.Show("Are you sure you want to reject this request?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()

                ' Build the SQL command to update the 'process' field to 'rejected'
                ' for the specific request_id.
                ' Since request_id is a number, it does not need single quotes.
                sql = "UPDATE pawn_request SET process = 'rejected' WHERE request_id = " & requestIdToUpdate

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Request has been rejected successfully.")
                Else
                    MsgBox("Update failed. The request was not found.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred during the update: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            ' Refresh the grid to show the updated status.
            reloadPawnRequestData()
        End If
    End Sub
End Class