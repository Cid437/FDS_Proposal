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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim amount = TextBox1.Text
        Dim collateral = TextBox2.Text
        Dim category = ComboBox1.SelectedItem

        Try
            conn.Open()
            sql = "INSERT INTO pawn_request (account_id, collateral_name, collateral_category, requested_amount) VALUES ('" & loggedInID & "', '" & collateral & "', '" & category & "', '" & amount & "')"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery

            If (i > 0) Then
                MsgBox("Request sent")
            Else
                MsgBox("Request unsuccesful")

            End If
        Catch ex As MySqlException
            MsgBox("Request unsuccesful")
        End Try
        conn.Close()
    End Sub
End Class