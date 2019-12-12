Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.History' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.Database1DataSet2.History)


    End Sub
End Class