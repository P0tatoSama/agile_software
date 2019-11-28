Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("iexplore", "http://www.google.com/search?hl=en&q=" + TextBox1.Text + "&aq=f&oq=")
        ListBox1.Items.Add(TextBox1.Text)
    End Sub


End Class
