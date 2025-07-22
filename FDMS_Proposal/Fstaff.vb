Public Class Fstaff
    Private Sub Fstaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class