Public Class Register_form


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox10.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        viewdetail.DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text, NumericUpDown1.Value, DateTimePicker1.Value, TextBox4.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text)
        MessageBox.Show("Added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        viewdetail.Show()
    End Sub
End Class