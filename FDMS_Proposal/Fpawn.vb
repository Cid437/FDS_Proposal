Imports MySql.Data.MySqlClient
Public Class Fpawn
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        FLogin.Show()
        Me.Hide()
    End Sub

    Private Sub about_Click(sender As Object, e As EventArgs) Handles about.Click
        FAbout.Show()
        Me.Hide()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub buy_Click(sender As Object, e As EventArgs) Handles buy.Click
        Fbuy.Show()
        Me.Hide()
    End Sub

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        FCart.Show()
        Me.Hide()
    End Sub

    Private Sub reloadhistory()
        Dim id = loggedInID
        Try
            conn.Open()

            sql = "SELECT transaction_id, request_id, account_id, collateral, collateral_category, pawned_ammount AS amount, t_status AS final_status " &
                  "FROM transaction WHERE t_status IN ('redeemed', 'forfeited') AND account_id = " & id & " " &
                  "UNION ALL " &
                  "SELECT NULL, request_id, account_id, collateral_name, collateral_category, requested_ammount AS amount, process AS final_status " &
                  "FROM pawn_request WHERE process = 'rejected' AND account_id = " & id

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "record")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "record"

        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub reloaddatagrid()
        Dim id = loggedInID
        Try
            conn.Open()
            sql = "SELECT process, requested_ammount, collateral_name, collateral_category FROM pawn_request WHERE process = 'ongoing' And account_id = " & id

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "pawn_request")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "pawn_request"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub reloaddatagrid6()
        Dim id = loggedInID
        Try
            conn.Open()
            sql = "SELECT * FROM transaction WHERE account_id = " & id

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "accepted")
            DataGridView6.DataSource = ds
            DataGridView6.DataMember = "accepted"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub textboxclear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amount = TextBox1.Text
        Dim collateral = TextBox2.Text
        Dim category = ComboBox1.SelectedItem
        Dim process = "Ongoing"
        Dim id = loggedInID
        'll
        If loggedInUser = "" Then
            MsgBox("Please log in first.")
            Me.Hide()
            FLogin.Show()
            Exit Sub
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Please input proper data")
        Else
            Try
                conn.Open()
                sql = "INSERT INTO pawn_request (account_id, collateral_name, collateral_category, requested_ammount, process) VALUES ('" & id & "', '" & collateral & "', '" & category & "', '" & amount & "', '" & process & "')"
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Request sent")
                Else
                    MsgBox("Request unsuccesful. ")

                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try
        End If
        conn.Close()
        reloaddatagrid()
        textboxclear()

    End Sub

    Private Sub Fpawn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloaddatagrid()
        textboxclear()
        reloaddatagrid6()
        reloadhistory()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reloaddatagrid()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Me.Hide()
        Fhelp.Show()
    End Sub

    Private Sub Pawn_Click(sender As Object, e As EventArgs) Handles Pawn.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If loggedInUser = "" Then
            MsgBox("Please log in first.")
            Me.Hide()
            FLogin.Show()
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            MsgBox("Please Check your inputted data")
        Else
            textboxvalues()
        End If
        conn.Close()
    End Sub

    Private Sub textboxvalues()
        Dim transaction_id As Integer
        Try
            conn.Open()
            transaction_id = Val(TextBox3.Text)
            sql = "SELECT pawned_ammount, date_pawned, date_due FROM transaction WHERE transaction_id = " & transaction_id
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Read()

            TextBox4.Text = dbread("pawned_ammount").ToString()
            TextBox5.Text = dbread("date_pawned").ToString()
            TextBox6.Text = dbread("date_due").ToString()

        Catch ex As MySqlException

        End Try
        conn.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reloaddatagrid6()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim transaction_id As Integer
        Dim amount_to_pay As Decimal

        If TextBox3.Text = "" Then
            MsgBox("Please input data on seach box", MsgBoxStyle.Information)
        ElseIf TextBox7.Text = "" Then
            MsgBox("Please input how much you want to pay", MsgBoxStyle.Information)
        Else
            Try
                conn.Open()

                transaction_id = Val(TextBox3.Text)
                amount_to_pay = Val(TextBox7.Text)

                Dim checkSql As String = "SELECT pawned_ammount FROM transaction WHERE transaction_id = " & transaction_id
                Dim checkComm As New MySqlCommand(checkSql, conn)
                Dim current_balance_checker As Object = checkComm.ExecuteScalar()

                If current_balance_checker Is Nothing Or IsDBNull(current_balance_checker) Then
                    MsgBox("Update failed. The Transaction ID was not found.", MessageBoxIcon.Warning)
                Else
                    Dim current_balance As Decimal = CDec(current_balance_checker)

                    If amount_to_pay < current_balance Then
                        sql = "UPDATE transaction SET pawned_ammount = pawned_ammount - " & amount_to_pay & ", Payment = Payment + " & amount_to_pay & " WHERE transaction_id = " & transaction_id
                        dbcomm = New MySqlCommand(sql, conn)
                        dbcomm.ExecuteNonQuery()
                        MsgBox("Amount deducted successfully.", MsgBoxStyle.Information)

                    Else
                        Dim change As Decimal = amount_to_pay - current_balance
                        sql = "UPDATE transaction SET pawned_ammount = 0, Payment = Payment + " & amount_to_pay & " WHERE transaction_id = " & transaction_id
                        dbcomm = New MySqlCommand(sql, conn)
                        dbcomm.ExecuteNonQuery()

                        MsgBox("Payment complete! Your change is: " & FormatCurrency(change) & vbCrLf & vbCrLf & "please connect with our staff to complete the transaction")

                        TextBox3.Text = ""
                        TextBox4.Text = ""
                        TextBox5.Text = ""
                        TextBox6.Text = ""
                        TextBox7.Text = ""
                    End If
                End If

            Catch ex As Exception
                MsgBox("An error occurred: " & ex.Message)
            End Try

            conn.Close()
            reloaddatagrid6()
            textboxvalues()
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        reloadhistory()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        If loggedInUser = "" Then
            MsgBox("Please log in first.")
            Me.Hide()
            FLogin.Show()
            Exit Sub
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("About Your Completed History" & vbCrLf &
       "------------------------------------" & vbCrLf & vbCrLf &
       "This tab is your personal archive, allowing you to see a history of all your past activity with us." & vbCrLf & vbCrLf &
       "Here you can review:" & vbCrLf &
       "   - Items you have successfully redeemed." & vbCrLf &
       "   - Items you have forfeited." & vbCrLf &
       "   - Any pawn requests that were not approved." & vbCrLf & vbCrLf &
       "Please note: To keep your history view clean and up-to-date, these records will be cleared out periodically.",
       MsgBoxStyle.Information, "Completed Tab Information")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("How to Make a Payment" & vbCrLf &
       "------------------------------------" & vbCrLf & vbCrLf &
       "Follow these simple steps to pay down your balance:" & vbCrLf & vbCrLf &
       "Step 1: Find Your Transaction" & vbCrLf &
       "First, enter your Transaction ID in the space provided and click the 'Search' button to display its information." & vbCrLf & vbCrLf &
       "Step 2: Enter the Amount" & vbCrLf &
       "In the box next to the 'Pay' button, type in the amount you wish to pay." & vbCrLf & vbCrLf &
       "Step 3: Click 'Pay'" & vbCrLf &
       "Press the 'Pay' button to submit your payment. Your remaining balance will be updated instantly.",
       MsgBoxStyle.Information, "Payment Instructions")
    End Sub
End Class