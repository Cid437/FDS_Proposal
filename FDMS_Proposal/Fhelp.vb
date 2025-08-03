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
        Dim id As Integer
        id = TextBox2.Text
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
        conn.Close()
    End Sub
End Class