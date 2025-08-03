Imports MySql.Data.MySqlClient
Public Class Fhelp
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet
    Private Sub Fhelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Else
                MsgBox("Message not sent.")
            End If
        Catch ex As Exception
            MsgBox("The system is having issues, please try again later")
        End Try
        conn.Close()
    End Sub
End Class