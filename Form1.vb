Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = txtusername.Text
        password = txtpass.Text
        If (username = "ABCD" And password = "1234") Then
            MessageBox.Show("Login Success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Register_form.Show()
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpass.Text = ""
            txtusername.Text = ""
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtpass.Text = ""
        txtusername.Text = ""

    End Sub
End Class
