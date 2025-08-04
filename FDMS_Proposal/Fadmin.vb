Imports MySql.Data.MySqlClient
Public Class Fadmin
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Sub textboxreset()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
    End Sub
    Private Sub textboxreset2()
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub textboxreset3()
        TextBox12.Text = ""
        TextBox13.Text = ""
        ComboBox2.Text = ""
    End Sub


    Private Sub resetgrid()
        Try
            conn.Open()
            sql = "SELECT * FROM acs"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "accounts")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "accounts"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub resetgrid2()
        Try
            conn.Open()
            sql = "SELECT * FROM acs WHERE role = 'staff'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "staffs")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "staffs"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub resetgrid3()
        Try
            conn.Open()
            sql = "SELECT * FROM staffs"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "salary")
            DataGridView3.DataSource = ds
            DataGridView3.DataMember = "salary"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub


    Private Sub Fadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resetgrid3()
        resetgrid2()
        resetgrid()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Fstaff.Show()
        Me.Hide()
        Fstaff.Button9.Show()
        Fstaff.Button1.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FLogin.Show()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
            Me.Hide()
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim account_id As Integer
        Dim name As String
        Dim password As String
        Dim role As String

        Try
            conn.Open()
            account_id = Val(TextBox1.Text)
            name = TextBox2.Text.Trim()
            password = TextBox3.Text.Trim()
            role = ComboBox1.Text.Trim()

            Dim sql As String = ""

            If TextBox1.Text <> "" Then
                sql = "SELECT * FROM acs WHERE account_id = " & account_id
            ElseIf TextBox2.Text <> "" Then
                sql = "SELECT * FROM acs WHERE name LIKE '%" & name & "%'"
            ElseIf TextBox3.Text <> "" Then
                sql = "SELECT * FROM acs WHERE password = '" & password & "'"
            ElseIf ComboBox1.Text <> "" Then
                sql = "SELECT * FROM acs WHERE role = '" & role & "'"

            Else
                MsgBox("Input Data on at least 1 textbox")
            End If

            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

        Catch ex As Exception
            MsgBox("Check your inputted data")
        Finally
            conn.Close()
        End Try

        textboxreset()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim account_id = TextBox1.Text
        Dim Name = TextBox2.Text
        Dim Password = TextBox3.Text
        Dim Role = ComboBox1.Text

        Try
            conn.Open()
            sql = "INSERT INTO acs (account_id, name, password, role) VALUES (" & account_id & ",'" & Name & "','" & Password & "','" & Role & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("account added")
            Else
                MsgBox("account not added")

            End If
        Catch ex As MySqlException
            MsgBox("Check your inputted data")

        End Try
        conn.Close()
        resetgrid()
        textboxreset()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Please select the row of the account you want to delete .", MsgBoxStyle.Information)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim idToDelete = selectedRow.Cells("account_id").Value
        Dim ans = MessageBox.Show("Are you sure you want to permanently delete this account? this will permanently delete rows with the same account number in other tables. ", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If ans = DialogResult.Yes Then
            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()

                ' Delete children tables
                sql = "DELETE FROM pawn_request WHERE account_id = " & idToDelete
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                sql = "DELETE FROM help_request WHERE account_id = " & idToDelete
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                sql = "DELETE FROM order_description WHERE account_id = " & idToDelete
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                sql = "DELETE FROM staffs WHERE account_id = " & idToDelete
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                sql = "DELETE FROM transaction WHERE account_id = " & idToDelete
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                ' delete parent table
                sql = "DELETE FROM acs WHERE account_id = '" & idToDelete & "'"
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If (i > 0) Then
                    MsgBox("Request deleted successfully.")
                Else
                    MsgBox("Request not deleted. It might have been removed already.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred while trying to delete the account: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            resetgrid()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim account_id = TextBox1.Text.Trim()
        Dim Name = TextBox2.Text.Trim()
        Dim Password = TextBox3.Text.Trim()
        Dim Role = ComboBox1.Text.Trim()

        Try
            conn.Open()
            Dim sql As String = "UPDATE acs SET name = '" & Name & "', password = '" & Password & "', role = '" & Role & "' WHERE account_id = " & account_id
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Account updated successfully.")
            Else
                MsgBox("No account was updated.")
            End If

        Catch ex As MySqlException
            MsgBox("Check your inputted data")
        End Try
        conn.Close()
        resetgrid()
        textboxreset()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        resetgrid()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim accountId = TextBox4.Text.Trim()
        Dim name = TextBox5.Text.Trim()
        Dim password = TextBox6.Text.Trim()
        Dim salary = TextBox7.Text.Trim()
        Dim position = ComboBox3.Text.Trim()

        If accountId = "" Or name = "" Or password = "" Or salary = "" Or position = "" Then
            MsgBox("Please fill out all fields.")
            Return
        End If


        Try
            conn.Open()

            sql = "INSERT INTO acs (account_id, name, password, role) VALUES ('" & accountId & "', '" & name & "', '" & password & "', 'staff')"
            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.ExecuteNonQuery()


            sql = "INSERT INTO staffs (account_id, name, staff_salary, position) VALUES ('" & accountId & "', '" & name & "', '" & salary & "', '" & position & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery()

            If (i > 0) Then
                MsgBox("Staff account created successfully.")
            Else
                MsgBox("Failed To create staff account.")
            End If

        Catch ex As Exception
            MsgBox("An Error occurred: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        resetgrid()
        resetgrid2()
        resetgrid3()
        textboxreset2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DataGridView2.SelectedRows.Count = 0 Then
            MsgBox("Please select the row of the account you want to delete .", MsgBoxStyle.Information)
            Return
        End If


        Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)


        Dim idToDelete = selectedRow.Cells("account_id").Value


        Dim ans = MessageBox.Show("Are you sure you want to permanently delete this account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)


        If ans = DialogResult.Yes Then
            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()


                sql = "DELETE FROM acs WHERE account_id = '" & idToDelete & "'"
                dbcomm = New MySqlCommand(sql, conn)
                dbcomm.ExecuteNonQuery()

                sql = "DELETE FROM staffs WHERE account_id = '" & idToDelete & "'"
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If (i > 0) Then
                    MsgBox("Request deleted successfully.")
                Else
                    MsgBox("Request not deleted. It might have been removed already.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred while trying to delete the account: " & ex.Message)
            Finally

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try


            resetgrid()
            resetgrid2()
            resetgrid3()
            textboxreset2()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        resetgrid2()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim account_id As String
        Dim name As String
        Dim password As String
        Dim salary As String
        Dim position As String

        Try
            conn.Open()
            account_id = TextBox4.Text.Trim()
            name = TextBox5.Text.Trim()
            password = TextBox6.Text.Trim()
            salary = TextBox7.Text.Trim()
            position = ComboBox3.Text.Trim()

            Dim sql As String = ""

            If TextBox4.Text <> "" Then
                sql = "SELECT * FROM acs WHERE role = 'staff' And account_id = " & account_id
            ElseIf TextBox5.Text <> "" Then
                sql = "SELECT * FROM acs WHERE role = 'staff' And name LIKE '%" & name & "%'"
            ElseIf TextBox6.Text <> "" Then
                sql = "SELECT * FROM acs WHERE role = 'staff' And password = '" & password & "'"
            ElseIf TextBox7.Text <> "" Then
                sql = "SELECT * FROM staffs WHERE staff_salary = " & salary
            ElseIf ComboBox3.Text <> "" Then
                sql = "SELECT * FROM staffs WHERE position = '" & position & "'"

            Else
                MsgBox("Input Data on at least 1 textbox")
            End If

            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView2.DataSource = table

        Catch ex As Exception
            MsgBox("Check your inputted data" & ex.Message)
        Finally
            conn.Close()
        End Try

        textboxreset2()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        resetgrid3()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim account_id As String
        Dim salary As String
        Dim position As String


        Try
            conn.Open()
            account_id = TextBox12.Text.Trim()
            salary = TextBox13.Text.Trim()
            position = ComboBox2.Text.Trim()

            Dim sql As String = ""

            If TextBox12.Text <> "" Then
                sql = "SELECT * FROM staffs WHERE accout_id = '" & account_id & "'"
            ElseIf TextBox13.Text <> "" Then
                sql = "SELECT * FROM staffs WHERE staff_salary = '" & salary & "'"
            ElseIf ComboBox2.Text <> "" Then
                sql = "SELECT * FROM staffs WHERE position = '" & position & "'"

            Else
                MsgBox("Input Data on at least 1 textbox")
            End If

            Dim adapter As New MySqlDataAdapter(sql, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView3.DataSource = table

        Catch ex As Exception
            MsgBox("Check your inputted data" & ex.Message)
        Finally
            conn.Close()
        End Try

        textboxreset3()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If DataGridView3.SelectedRows.Count = 0 Then
            MsgBox("select a row in the datagrid to update the salary")
            Return
        End If

        Dim newSalaryText As String = TextBox13.Text.Trim()

        If newSalaryText <> "" Then
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)
            Dim staffIdToUpdate = selectedRow.Cells("staff_id").Value

            Dim newSalaryValue As Decimal
            If Not Decimal.TryParse(newSalaryText, newSalaryValue) Then
                MsgBox("Please enter a valid number for the salary.")
                Return
            End If

            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()

                sql = "UPDATE staffs SET staff_salary = " & newSalaryValue & " WHERE staff_id = " & staffIdToUpdate

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Salary updated successfully.")
                Else
                    MsgBox("Update failed. The staff member was not found.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred during the update: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            resetgrid3()
            textboxreset3()

        Else
            MsgBox("Please enter a new salary value in the textbox.")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If DataGridView3.SelectedRows.Count = 0 Then
            MsgBox("select a row in the datagrid to update the position")
            Return
        End If

        Dim newPosition As String = ComboBox2.Text.Trim()

        If newPosition <> "" Then
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)
            Dim staffIdToUpdate = selectedRow.Cells("staff_id").Value

            Dim sql As String
            Dim dbcomm As MySqlCommand

            Try
                conn.Open()

                sql = "UPDATE staffs SET position = '" & newPosition & "' WHERE staff_id = " & staffIdToUpdate

                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Position updated successfully.")
                Else
                    MsgBox("Update failed. The staff member was not found.")
                End If

            Catch ex As Exception
                MsgBox("An error occurred during the update: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

            resetgrid3()
            textboxreset3()

        Else
            MsgBox("Please select a new position from the list.")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Not DateTimePicker1.Checked Or Not DateTimePicker2.Checked Then
            MsgBox("please choose date range")
            Return
        End If

        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value

        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd 00:00:00")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd 23:59:59")

        Try
            conn.Open()
            sql = "SELECT transaction_id, date_pawned, pawned_ammount, date_due FROM transaction " &
                  "WHERE date_pawned BETWEEN '" & formattedStartDate & "' AND '" & formattedEndDate & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "transactions")
            DataGridView4.DataSource = ds
            DataGridView4.DataMember = "transactions"

        Catch ex As Exception
            MsgBox("Error collecting data from Database. Error is :" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Not DateTimePicker1.Checked OrElse Not DateTimePicker2.Checked Then
            MsgBox("please choose date range")
            Return
        End If

        Dim startDate As DateTime = DateTimePicker1.Value
        Dim endDate As DateTime = DateTimePicker2.Value

        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd 00:00:00")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd 23:59:59")

        Dim sql As String
        Try
            conn.Open()

            sql = "SELECT SUM(pawned_ammount) AS 'Total Expense' FROM transaction " &
              "WHERE date_pawned BETWEEN '" & formattedStartDate & "' AND '" & formattedEndDate & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "total")
            DataGridView4.DataSource = ds
            DataGridView4.DataMember = "total"

        Catch ex As Exception
            MsgBox("An error occurred while calculating the total: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Not DateTimePicker3.Checked OrElse Not DateTimePicker4.Checked Then
            MsgBox("please choose date range")
            Return
        End If

        Dim startDate As DateTime = DateTimePicker3.Value
        Dim endDate As DateTime = DateTimePicker4.Value

        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd 00:00:00")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd 23:59:59")

        Try
            conn.Open()

            sql = "SELECT date_pawned AS 'Transaction Date', Payment AS 'Amount', 'Pawn Payment' AS 'Type' FROM transaction " &
                  "WHERE date_pawned BETWEEN '" & formattedStartDate & "' AND '" & formattedEndDate & "' " &
                  "UNION ALL " &
                  "SELECT date_ordered AS 'Transaction Date', price AS 'Amount', 'Order' AS 'Type' FROM order_description " &
                  "WHERE date_ordered BETWEEN '" & formattedStartDate & "' AND '" & formattedEndDate & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "financial_report")
            DataGridView5.DataSource = ds
            DataGridView5.DataMember = "financial_report"

        Catch ex As Exception
            MsgBox("Error collecting data from Database. Error is :" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Not DateTimePicker3.Checked OrElse Not DateTimePicker4.Checked Then
            MsgBox("please choose date range")
            Return
        End If

        Dim startDate As DateTime = DateTimePicker3.Value
        Dim endDate As DateTime = DateTimePicker4.Value

        Dim formattedStartDate As String = startDate.ToString("yyyy-MM-dd 00:00:00")
        Dim formattedEndDate As String = endDate.ToString("yyyy-MM-dd 23:59:59")

        Try
            conn.Open()

            sql = "SELECT 'Total Pawn Payments' AS 'Category', SUM(Payment) AS 'Total Amount' FROM transaction " &
                  "WHERE date_pawned BETWEEN '" & formattedStartDate & "' AND '" & formattedEndDate & "' " &
                  "UNION ALL " &
                  "SELECT 'Total Order Sales' AS 'Category', SUM(price) AS 'Total Amount' FROM order_description " &
                  "WHERE date_ordered BETWEEN '" & formattedStartDate & "' AND '" & formattedEndDate & "'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "totals_report")
            DataGridView5.DataSource = ds
            DataGridView5.DataMember = "totals_report"

        Catch ex As Exception
            MsgBox("Error collecting data from Database. Error is :" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class