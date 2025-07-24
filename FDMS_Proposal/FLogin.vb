Imports MySql.Data.MySqlClient
Public Class FLogin
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

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

    Private Sub cart_Click(sender As Object, e As EventArgs) Handles cart.Click
        Me.Hide()
        FCart.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "1" Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            Fstaff.Show()
            Me.Hide()
        End If

        Dim name = TextBox1.Text
        Dim password = TextBox2.Text
        Dim staffconfirm = "staff"

        Try
            conn.Open()
            sql = "SELECT * FROM acs WHERE name = '" & name & "' AND password = '" & password & "'"
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()

            If dbread.Read() Then
                Dim role As String = dbread("role")

                If role = staffconfirm Then
                    MsgBox("Welcome, staff '" & name & "'!")
                    Fstaff.Show()
                    Me.Hide()
                Else
                    MsgBox("Login Successful, welcome '" & name & "'!")
                End If
            Else
                MsgBox("Please check your username or password. If you don't have an account, please sign up.")
            End If

        Catch ex As MySqlException
            MsgBox("Something went wrong. " & ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name = TextBox1.Text
        Dim password = TextBox2.Text
        Dim role = "customer"
        conn.Close()
        Try
            conn.Open()
            sql = "INSERT INTO acs (name, password, role) VALUES ('" & name & "', '" & password & "', '" & role & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Account Created")
            Else
                MsgBox("This account already exists / please try another name or password")
            End If
        Catch ex As Exception
            MsgBox("Please try another password/name")
        End Try
        conn.Close()
    End Sub
End Class