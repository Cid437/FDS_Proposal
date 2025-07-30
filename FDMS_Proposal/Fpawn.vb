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

    Private Sub reloaddatagrid()
        Dim id = loggedInID
        Try
            conn.Open()
            sql = "SELECT * FROM pawn_request WHERE account_id = " & id

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amount = TextBox1.Text
        Dim collateral = TextBox2.Text
        Dim category = ComboBox1.SelectedItem
        Dim process = "Ongoing"
        Dim id = loggedInID

        If loggedInUser = "" Then
            MsgBox("Please log in first.")
            Me.Hide()
            FLogin.Show()
            Exit Sub
        End If

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
        conn.Close()
        reloaddatagrid()
    End Sub

    Private Sub Fpawn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloaddatagrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reloaddatagrid()
    End Sub
End Class