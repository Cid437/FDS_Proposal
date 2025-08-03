Imports MySql.Data.MySqlClient
Public Class Fstaff
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public DataAdapter2 As MySqlDataAdapter
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

    Private Sub reloadgrid4()

        Try
            conn.Open()
            sql = "SELECT
    transaction_id,
    request_id,
    account_id,
    collateral,
    collateral_category,
    pawned_ammount AS amount,
    t_status AS final_status
FROM
    transaction
WHERE
    t_status IN ('redeemed', 'forfeited')

UNION ALL

SELECT
    NULL, 
    request_id,
    account_id,
    collateral_name,
    collateral_category,
    requested_ammount AS amount,
    process AS final_status
FROM
    pawn_request
WHERE
    process = 'rejected'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "record")
            DataGridView4.DataSource = ds
            DataGridView4.DataMember = "record"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub reloaddatagrid5()
        Try
            conn.Open()
            sql = "SELECT * FROM transaction WHERE t_status = 'ongoing' ORDER BY transaction_id"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "accepted")
            DataGridView5.DataSource = ds
            DataGridView5.DataMember = "accepted"


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
        reloadgrid4()
        reloaddatagrid5()
    End Sub

    Private Sub reloadPawnRequestData()
        Try
            conn.Open()
            sql = "SELECT * FROM pawn_request Where process = 'ongoing'"

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
        Dim interestRate As Decimal

        Select Case monthsInput
            Case "1"
                monthsToAdd = 1
                interestRate = 0.1D
            Case "6"
                monthsToAdd = 6
                interestRate = 0.15D
            Case "12"
                monthsToAdd = 12
                interestRate = 0.2D
            Case Else
                MsgBox("Invalid input. Please enter only 1, 6, or 12.", MsgBoxStyle.Exclamation)
                Return
        End Select

        Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)

        Dim requestId = selectedRow.Cells("request_id").Value
        Dim accountId = selectedRow.Cells("account_id").Value
        Dim collateralName = selectedRow.Cells("collateral_name").Value
        Dim collateralCategory = selectedRow.Cells("collateral_category").Value

        Dim requestedAmountAsDecimal As Decimal = CDec(selectedRow.Cells("requested_ammount").Value)
        Dim finalPawnedAmount As Decimal = requestedAmountAsDecimal + (requestedAmountAsDecimal * interestRate)

        Dim processStatus = selectedRow.Cells("process").Value
        Dim pawnDate As DateTime = Date.Now
        Dim maturityDate As DateTime = pawnDate.AddMonths(monthsToAdd)

        Dim dbcomm As MySqlCommand
        Dim sql As String

        Try
            conn.Open()

            sql = "INSERT INTO transaction (request_id, account_id, collateral, collateral_category, pawned_ammount, date_pawned, date_due, t_status) VALUES ('" & requestId & "', '" & accountId & "', '" & collateralName & "', '" & collateralCategory & "', " & finalPawnedAmount & ", '" & pawnDate.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & maturityDate.ToString("yyyy-MM-dd HH:mm:ss") & "', '" & processStatus & "')"

            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery()

            If (i > 0) Then

                sql = "UPDATE pawn_request SET process = 'accepted' WHERE request_id = '" & requestId & "'"
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
        reloaddatagrid5()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("Please select a request from the list to reject.", MsgBoxStyle.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)


        Dim requestIdToUpdate = selectedRow.Cells("request_id").Value
        Dim currentStatus As String = selectedRow.Cells("process").Value.ToString()

        If currentStatus <> "ongoing" Then
            MsgBox("This request cannot be rejected because its status is already '" & currentStatus & "'.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim confirmation = MessageBox.Show("Are you sure you want to reject this request?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()

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


            reloadPawnRequestData()
            reloadgrid4()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            conn.Open()
            sql = "SELECT help_id, account_id, name, help_descrip FROM help_request WHERE reply_descrip IS NULL ORDER BY account_id"

            DataAdapter2 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter2.Fill(ds, "help_request")
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "help_request"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub requestgrid()
        Try
            conn.Open()
            sql = "SELECT * FROM help_request ORDER BY account_id"

            DataAdapter2 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter2.Fill(ds, "help_request")
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "help_request"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        requestgrid()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            conn.Open()
            sql = "SELECT help_id, account_id, name, reply_descrip, help_descrip FROM help_request WHERE reply_descrip IS NOT NULL ORDER BY account_id"

            DataAdapter2 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter2.Fill(ds, "help_request")
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "help_request"

        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim id As Integer
        Try
            conn.Open()
            id = Val(TextBox9.Text)
            sql = "SELECT * FROM help_request WHERE help_id = " & id
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()

            If dbread.Read() Then

                If Not IsDBNull(dbread("reply_descrip")) Then
                    TextBox7.Text = dbread("reply_descrip")
                Else
                    TextBox7.Text = ""
                End If

                TextBox8.Text = dbread("help_descrip")
                TextBox10.Text = dbread("name")
                TextBox11.Text = dbread("account_id")
            Else
                MsgBox("No data found for that account ID.")
            End If

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        conn.Close()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim id As String
        Dim reply As String
        reply = TextBox7.Text
        id = TextBox9.Text
        Try
            conn.Open()
            sql = "UPDATE help_request SET reply_descrip = ('" & reply & "') WHERE help_id = " & id
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Reply Sent")
            Else
                MsgBox("Reply already sent")

            End If
        Catch ex As MySqlException
            MsgBox("Request id might not exist")
            conn.Close()
        End Try
        conn.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        reloadPawnRequestData()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        reloaddatagrid5()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        reloadgrid4()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If DataGridView5.SelectedRows.Count = 0 Then
            MsgBox("Please select a transaction from the list to redeem.", MsgBoxStyle.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView5.SelectedRows(0)


        Dim transactionIdToUpdate = selectedRow.Cells("transaction_id").Value
        Dim currentStatus As String = selectedRow.Cells("t_status").Value.ToString()

        If currentStatus <> "ongoing" Then
            MsgBox("This item cannot be redeemed because its status is already '" & currentStatus & "'.", MsgBoxStyle.Exclamation)
            Return
        End If


        Dim confirmation = MessageBox.Show("Are you sure you want to mark this item as redeemed?", "Confirm Redemption", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()


                sql = "UPDATE transaction SET t_status = 'redeemed' WHERE transaction_id = " & transactionIdToUpdate

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Transaction has been marked as redeemed.")
                Else
                    MsgBox("Update failed. The transaction was not found.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred during the update: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            reloaddatagrid5()
            reloadgrid4()
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If DataGridView5.SelectedRows.Count = 0 Then
            MsgBox("Please select a transaction from the list to forfeit.", MsgBoxStyle.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView5.SelectedRows(0)


        Dim transactionIdToUpdate = selectedRow.Cells("transaction_id").Value
        Dim currentStatus As String = selectedRow.Cells("t_status").Value.ToString()


        If currentStatus <> "ongoing" Then
            MsgBox("This item cannot be forfeited because its status is already '" & currentStatus & "'.", MsgBoxStyle.Exclamation)
            Return
        End If


        Dim confirmation = MessageBox.Show("Are you sure you want to mark this item as forfeited?", "Confirm Redemption", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmation = DialogResult.Yes Then
            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()


                sql = "UPDATE transaction SET t_status = 'forfeited' WHERE transaction_id = " & transactionIdToUpdate

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Transaction has been marked as forfeited.")
                Else
                    MsgBox("Update failed. The transaction was not found.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred during the update: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try


            reloaddatagrid5()
            reloadgrid4()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If DataGridView4.SelectedRows.Count = 0 Then
            MsgBox("Please select a record from the history to delete.", MsgBoxStyle.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView4.SelectedRows(0)


        Dim status As String = selectedRow.Cells("final_status").Value.ToString()
        Dim sql As String = ""
        Dim targetTable As String = ""
        Dim idToDelete As Object = Nothing
        Dim confirmationMessage As String = ""

        If status = "redeemed" OrElse status = "forfeited" Then

            targetTable = "transaction"
            idToDelete = selectedRow.Cells("transaction_id").Value
            sql = "DELETE FROM " & targetTable & " WHERE transaction_id = " & idToDelete
            confirmationMessage = "Are you sure you want to delete this transaction record?"

        ElseIf status = "rejected" Then

            targetTable = "pawn_request"
            idToDelete = selectedRow.Cells("request_id").Value
            sql = "DELETE FROM " & targetTable & " WHERE request_id = " & idToDelete
            confirmationMessage = "Are you sure you want to delete this rejected request?"

        Else

            MsgBox("This record cannot be deleted. Only 'redeemed', 'forfeited', or 'rejected' records can be removed.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim ans = MessageBox.Show(confirmationMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If ans = DialogResult.Yes Then
            Dim dbcomm As MySqlCommand
            Try
                conn.Open()
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Record deleted successfully from the '" & targetTable & "' table.")
                Else
                    MsgBox("Record not deleted. It might have already been removed.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred during deletion: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try


            reloadgrid4()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim message As String = "Are you sure you want to permanently delete ALL rejected, redeemed, and forfeited records from the database?" & vbCrLf & vbCrLf & "This action CANNOT be undone."
        Dim ans = MessageBox.Show(message, "Confirm Bulk Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If ans = DialogResult.Yes Then
            Dim sqlDeleteTransactions As String
            Dim sqlDeleteRequests As String
            Dim dbcomm As MySqlCommand
            Dim transactionsDeleted As Integer = 0
            Dim requestsDeleted As Integer = 0

            Try
                conn.Open()

                sqlDeleteTransactions = "DELETE FROM transaction WHERE t_status = 'redeemed' OR t_status = 'forfeited'"
                dbcomm = New MySqlCommand(sqlDeleteTransactions, conn)
                transactionsDeleted = dbcomm.ExecuteNonQuery()

                sqlDeleteRequests = "DELETE FROM pawn_request WHERE process = 'rejected'"
                dbcomm = New MySqlCommand(sqlDeleteRequests, conn)
                requestsDeleted = dbcomm.ExecuteNonQuery()

                MsgBox("Operation complete." & vbCrLf & vbCrLf &
                       "Deleted " & transactionsDeleted & " records from Transactions." & vbCrLf &
                       "Deleted " & requestsDeleted & " records from Pawn Requests.",
                       MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox("An error occurred during the delete operation: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            reloadgrid4()
        End If
    End Sub

    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click

    End Sub
End Class