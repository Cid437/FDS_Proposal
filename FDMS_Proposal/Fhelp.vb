Imports MySql.Data.MySqlClient
Public Class Fhelp
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Sub reloaddatagrid()
        Dim id As Integer
        id = loggedInID
        Try
            conn.Open()
            sql = "SELECT help_id, help_descrip, reply_descrip FROM help_request WHERE account_id = " & id

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "help_request")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "help_request"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Fhelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloaddatagrid()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim help As String
        Dim id As Integer
        Dim name As String
        id = loggedInID
        help = TextBox1.Text
        name = loggedInUser
        If loggedInUser = "" Then
            MsgBox("Please log in first.")
            Me.Hide()
            FLogin.Show()
        Else
            Try
                conn.Open()
                sql = "INSERT INTO help_request (account_id, name, help_descrip) VALUES ('" & id & "', '" & name & "', '" & help & "')"
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("Message Sent, please wait for some time for the staff's reply.")
                    TextBox1.Text = ""
                Else
                    MsgBox("Message not sent.")
                End If
            Catch ex As Exception
                MsgBox("The system is having issues, please try again later")
            End Try
        End If
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel1.Visible = True
        Label2.Text = "See reply:"
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = True
        TextBox1.ReadOnly = True
        reloaddatagrid()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Panel1.Visible = False
        Label2.Text = "Leave a message for the staff:"
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = False
        TextBox1.ReadOnly = False
        TextBox1.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim id As String
        id = TextBox2.Text
        If id = "" Then
            MsgBox("Please input proper Help ID", MsgBoxStyle.Information)

        Else
            Try
                conn.Open()
                sql = "SELECT help_id, help_descrip, reply_descrip FROM help_request WHERE help_id = " & id
                dbcomm = New MySqlCommand(sql, conn)
                dbread = dbcomm.ExecuteReader()


                If dbread.Read() Then
                    TextBox1.Text = dbread("reply_descrip")
                Else
                    MsgBox("Please check if you typed the correct help id")
                End If


            Catch ex As Exception
                MsgBox("There is no reply yet, please wait for some time")

            End Try
        End If
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("step 1 click the account tab" & vbCrLf &
          "step 2 input name and password" & vbCrLf &
          "step 3 press log in", MsgBoxStyle.Information, "Login Instruction")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Our Simple Pawning Process" & vbCrLf &
       "------------------------------------" & vbCrLf & vbCrLf &
       "1. Submit Your Request" & vbCrLf &
       "First, you submit a request to pawn your item. Our staff will review it shortly." & vbCrLf & vbCrLf &
       "2. Staff Review" & vbCrLf &
       "We will evaluate your item. Once approved, your pawn becomes active." & vbCrLf & vbCrLf &
       "Loan Amount & Interest" & vbCrLf &
       "An interest rate is added to your total loan amount based on the duration:" & vbCrLf &
       "   - 1 Month Loan: +10%% Interest" & vbCrLf &
       "   - 6 Month Loan: +15%% Interest" & vbCrLf &
       "   - 12 Month Loan: +20%% Interest" & vbCrLf & vbCrLf &
       "3. Make Payments" & vbCrLf &
       "You can make payments towards your total loan amount at any time." & vbCrLf & vbCrLf &
       "4. Redeem Your Item" & vbCrLf &
       "Once your balance is fully paid, you can redeem your item!",
       MsgBoxStyle.Information, "How Pawning Works")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("What Items Can You Pawn?" & vbCrLf &
       "------------------------------------" & vbCrLf & vbCrLf &
       "We primarily accept items in categories like:" & vbCrLf &
       "   - Jewelries" & vbCrLf &
       "   - Electronics" & vbCrLf &
       "   - Antiques" & vbCrLf & vbCrLf &
       "However, we will consider pawning almost anything that has a resale value." & vbCrLf & vbCrLf &
       "Please don't hesitate to submit a request for any item. Our staff will evaluate it and let you know if it can be accepted.",
       MsgBoxStyle.Information, "Accepted Collaterals")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("How to Change Your Password" & vbCrLf &
       "------------------------------------" & vbCrLf & vbCrLf &
       "For your security, you can change your password in one of two ways:" & vbCrLf & vbCrLf &
       "1. Visit Us in Person" & vbCrLf &
       "Connect with any of our staff at our physical location, and they will be happy to assist you with changing your password immediately." & vbCrLf & vbCrLf &
       "2. Send a Help Request" & vbCrLf &
       "Use the 'Help' feature in our app to send a message. Please include the following in your message:" & vbCrLf &
       "   - Proof that the account is yours (e.g., mention a recent transaction or pawned item)." & vbCrLf &
       "   - The new password you would like to use." & vbCrLf &
       "   - An email address where we can notify you once the change is complete.",
       MsgBoxStyle.Information, "Password Change Instructions")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class