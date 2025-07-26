Imports MySql.Data.MySqlClient
Public Class Fbuy
    Dim conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=DCPT;User=root;Password=;")
    'Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As MySqlCommand
    Public dbread As MySqlDataReader
    Public DataAdapter1 As MySqlDataAdapter
    Public ds As DataSet

    Private Function FindLabel(name As String) As Label
        Return FindControlRecursive(Me, name)
    End Function

    Private Function FindControlRecursive(parent As Control, name As String) As Label
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Label AndAlso ctrl.Name = name Then
                Return CType(ctrl, Label)
            End If

            ' Recursive search
            Dim found As Label = FindControlRecursive(ctrl, name)
            If found IsNot Nothing Then Return found
        Next
        Return Nothing
    End Function


    Private Sub Fbuy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 24
            Dim lbl As Label = FindLabel("Label" & i)
            If lbl IsNot Nothing Then
                setLabel(i, lbl)
            End If
        Next
    End Sub

    Private Sub adder(ByVal id As Integer)
        Dim name As String
        Dim price As Decimal
        Dim amount As Integer = 1

        Try
            conn.Open()

            sql = "SELECT item_name, item_price FROM items WHERE item_id = " & id
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()

            If dbread.Read() Then
                name = dbread("item_name")
                price = dbread("item_price")
            Else
                MsgBox("Item not found.")
                conn.Close()
                Exit Sub
            End If
            dbread.Close()

            sql = "INSERT INTO carts (item_id, item_name, item_price, cart_amount) VALUES (" & id & ", '" & name & "', " & price & ", " & amount & ")"
            dbcomm = New MySqlCommand(sql, conn)
            Dim i As Integer = dbcomm.ExecuteNonQuery()

            If i > 0 Then
                MsgBox("Item " & name & " added.")
            Else
                MsgBox("Failed to add item.")
            End If

        Catch ex As Exception
            MsgBox("Error, item might already be in cart. ")
        End Try

        conn.Close()
    End Sub

    Private Sub setLabel(itemID As Integer, targetLabel As Label)
        Try
            conn.Open()
            sql = "SELECT item_name FROM items WHERE item_id = " & itemID
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()

            If dbread.Read() Then
                targetLabel.Text = "Item: " & dbread("item_name").ToString()
            Else
                targetLabel.Text = "Item not found."
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Me.Hide()
        FLogin.Show()
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
        adder(1)
        setLabel(1, Label1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adder(2)
        setLabel(2, Label2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adder(3)
        setLabel(3, Label3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        adder(4)
        setLabel(4, Label4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        adder(5)
        setLabel(5, Label5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        adder(6)
        setLabel(6, Label6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        adder(7)
        setLabel(7, Label7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        adder(8)
        setLabel(8, Label8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        adder(9)
        setLabel(9, Label9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        adder(10)
        setLabel(10, Label10)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        adder(11)
        setLabel(11, Label11)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        adder(12)
        setLabel(12, Label12)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        adder(13)
        setLabel(13, Label13)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        adder(14)
        setLabel(14, Label14)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        adder(15)
        setLabel(15, Label15)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        adder(16)
        setLabel(16, Label16)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        adder(17)
        setLabel(17, Label17)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        adder(18)
        setLabel(18, Label18)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        adder(19)
        setLabel(19, Label19)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        adder(20)
        setLabel(20, Label20)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        adder(21)
        setLabel(21, Label21)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        adder(22)
        setLabel(22, Label22)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        adder(23)
        setLabel(23, Label23)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        adder(24)
        setLabel(24, Label24)
    End Sub

End Class