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
        TextBox4.Text = ""
    End Sub


    Private Sub resetgrid()
        Try
            conn.Open()
            sql = "SELECT * FROM acs"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)
            ds = New DataSet()
            DataAdapter1.Fill(ds, "staffs")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "staffs"


        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Fadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            TextBox4.Text = ""
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
            role = TextBox4.Text.Trim()

            Dim sql As String = ""

            If TextBox1.Text <> "" Then
                sql = "SELECT * FROM acs WHERE account_id = " & account_id
            ElseIf TextBox2.Text <> "" Then
                sql = "SELECT * FROM acs WHERE name LIKE '%" & name & "%'"
            ElseIf TextBox3.Text <> "" Then
                sql = "SELECT * FROM acs WHERE password = '" & password & "'"
            ElseIf TextBox4.Text <> "" Then
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
        Dim Role = TextBox4.Text

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
        Try
            conn.Open()
            Dim id As String = InputBox("enter account id to be deleted", "delete record")
            Dim ans = MessageBox.Show("do you want to delete this account?", "account deleted", MessageBoxButtons.YesNoCancel)
            If id = "" Then
                conn.Close()
            End If


            If ans = DialogResult.Yes Then

                sql = $"DELETE FROM acs WHERE account_id = {id}"
                dbcomm = New MySqlCommand(sql, conn)
                Dim i As Integer = dbcomm.ExecuteNonQuery

                If (i > 0) Then
                    MsgBox("account deleted")
                Else
                    MsgBox("account not deleted")

                End If
            End If
        Catch ex As MySqlException
            MsgBox("Check your inputted data")
        End Try
        conn.Close()
        resetgrid()
        textboxreset()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim account_id = TextBox1.Text.Trim()
        Dim Name = TextBox2.Text.Trim()
        Dim Password = TextBox3.Text.Trim()
        Dim Role = TextBox4.Text.Trim()

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
End Class